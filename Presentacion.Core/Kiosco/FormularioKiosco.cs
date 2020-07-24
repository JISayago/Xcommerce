using Presentacion.Core.Cliente;
using Presentacion.Core.Empleado;
using Presentacion.FormulariosBase;
using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.DetalleCaja;
using XCommerce.Servicios.Core.DetalleCaja.DTO;
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Movimiento.DTO;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Producto.DTO;
using XCommerce.Servicios.Core.Tarjeta;
using XCommerce.Servicios.Core.Tarjeta.DTO;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta;

namespace Presentacion.Core.Kiosco
{
    public partial class FormularioKiosco : FormularioBase
    {
        private readonly IArticuloServicio _articuloServicio;
        private readonly IProductoServicio _productoServicio;
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IDetalleCajaServicio _detalleCajaServicio;
        private readonly IMovimientoServicio _movimientoServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly ITarjetaServicio _tarjetaServicio;
        private readonly IPlanTarjetaServicio _planTarjetaServicio;
        private readonly IEmpleadoServicio _empleadoServicio;

        private Dictionary<string, DetalleComprobanteDTO> detalles;
        private long idCliente;

        public bool delivery = false;

        public FormularioKiosco()
        {
            InitializeComponent();
            //ResetearGrilla(dgvGrilla);
            _articuloServicio = new ArticuloServicio();
            _productoServicio = new ProductoServicio();
            _comprobanteServicio = new ComprobanteServicio();
            _detalleCajaServicio = new DetalleCajaServicio();
            _movimientoServicio = new MovimientoServicio();
            _clienteServicio = new ClienteServicio();
            _tarjetaServicio = new TarjetaServicio();
            _planTarjetaServicio = new PlanTarjetaServicio();
            _empleadoServicio = new EmpleadoServicio();

            detalles = new Dictionary<string, DetalleComprobanteDTO>();
            txtUsuarioEmpleado.Text = DatosSistema.NombreUsuario;
            SetConsumidorFinal();
            cargarCbTarjetaPlan();

        }
        public FormularioKiosco(long idCliente) : this()
        {
            this.idCliente = idCliente;
        }

        public FormularioKiosco(bool delivery) : this()
        {
            this.delivery = delivery;
            if (this.delivery)
            {
                groupBoxEmpleado.Text = "Cadete";
                this.Text = "Formulario Delivery";
                btnBuscarEmpleado.Enabled = true;
            }
        }

        private void cargarCbTarjetaPlan()
        {

            CargarComboBox(cbTarjeta, _tarjetaServicio.Obtener(""), "Descripcion", "Id");
            if (cbTarjeta.Items.Count != 0)
            {
                CargarComboBox(cbPlan, _planTarjetaServicio.ObtenerPorIdTarjeta(((TarjetaDTO)cbTarjeta.SelectedItem).Id), "Descripcion", "Id");
            }
            else
            {
                CargarComboBox(cbPlan, _planTarjetaServicio.Obtener(""), "Descripcion", "Id");
            }
        }
        private void SetConsumidorFinal()
        {
            if (rbCtaCte.Checked)
            {
                txtDniCliente.Text = "";
                txtDniCliente.Enabled = true;
                txtNombreCliente.Text = "";
                txtNombreCliente.Enabled = true;
                txtApellidoCliente.Text = "";
                txtApellidoCliente.Enabled = true;
                btnBuscarCliente.Enabled = false;
                btnBuscarCliente.Enabled = true;

            }
            else //if (rbEfectivo.Checked)
            {
                txtDniCliente.Text = "99999999";
                txtDniCliente.Enabled = false;
                txtNombreCliente.Text = "Consumidor";
                txtNombreCliente.Enabled = false;
                txtApellidoCliente.Text = "Final";
                txtApellidoCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
            }
        }


        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.ReadOnly = false;

            grilla.Columns["CodigoProducto"].Visible = true;
            grilla.Columns["CodigoProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CodigoProducto"].HeaderText = "Codigo del Producto";
            grilla.Columns["CodigoProducto"].ReadOnly = true;

            grilla.Columns["DescripcionProducto"].Visible = true;
            grilla.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["DescripcionProducto"].HeaderText = "Descripcion";
            grilla.Columns["DescripcionProducto"].ReadOnly = true;

            grilla.Columns["CantidadProducto"].Visible = true;
            grilla.Columns["CantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CantidadProducto"].HeaderText = "Cantidad";


            grilla.Columns["PrecioUnitario"].Visible = true;
            grilla.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            grilla.Columns["PrecioUnitario"].ReadOnly = true;

            //grilla.Columns["SubtotalLinea"].Visible = true;
            //grilla.Columns["SubtotalLinea"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //grilla.Columns["SubtotalLinea"].HeaderText = "Sub-Total";


        }

        private bool ChequearDisponibilidadArticulo(string codigo, decimal cantidad)
        {
            var articulo = _articuloServicio.Obtener(codigo).First();

            Func<bool,string,bool> check_showm = (c,m) => { if(c) MessageBox.Show(m); return false; };

            if (articulo.EstaDiscontinuado) { MessageBox.Show("Articulo descontinuado"); return false; }
            if (articulo.EstaEliminado)     { MessageBox.Show("Articulo eliminado"); return false; }

            if (articulo.DescuentaStock) {
                if (!articulo.PermiteStockNegativo
                    && articulo.Stock - cantidad < 0) { MessageBox.Show("Stock insuficiente"); return false; }

                if (articulo.Stock - cantidad < articulo.StockMinimo) { MessageBox.Show("Stock minimo superado"); return false; }
            }

            //if(check_showm(articulo.EstaDiscontinuado, "Articulo descontinuado") ||
            //check_showm(articulo.EstaEliminado, "Articulo eliminado")) return false;

            //if (articulo.DescuentaStock)
            //    if(check_showm(!articulo.PermiteStockNegativo && articulo.Stock - cantidad < 0, "Stock insuficiente") ||
            //    check_showm(articulo.Stock - cantidad < articulo.StockMinimo, "Stock minimo superado")) return false;

            return true;
        }
        private void AgregarArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                MessageBox.Show("Por favor ingrese un codigo");
                return;
            }

            if (detalles.Values.Count == 0 && !DatosSistema.EstaCajaAbierta)
            {
                MessageBox.Show("Advertencia: No se podrá facturar sin la caja abierta.");
            }

            //if (productos.TryGetValue(txtCodigoBarras.Text, out decimal cantidad))
            //{
            //    productos[txtCodigoBarras.Text] = cantidad + nudCantidadArticulo.Value;
            //}
            //if(detalles.FirstOrDefault(x => x.CodigoProducto == txtCodigoBarras.Text))
            //else list_detalles.add)= new detalle_comprobante y cuando aprieto facturar, new comprobante y listo?


            if (detalles.TryGetValue(txtCodigoBarras.Text, out DetalleComprobanteDTO det))
            {
                
                if (!ChequearDisponibilidadArticulo(txtCodigoBarras.Text, nudCantidadArticulo.Value + det.CantidadProducto))
                    return;

                det.CantidadProducto += nudCantidadArticulo.Value;
            }
            else
            {
                //ProductoMesaDTO producto = _productoServicio.ObtenerPorCodigoKiosco(txtCodigoBarras.Text);
                ProductoMesaDTO producto = _productoServicio.ObtenerPorCodigoSalon(delivery ? "Delivery" : "Kiosco", txtCodigoBarras.Text);  ;

                if (producto != null)
                {
                    if (!ChequearDisponibilidadArticulo(txtCodigoBarras.Text, 1)) return;
                    detalles[txtCodigoBarras.Text] =
                        new DetalleComprobanteDTO
                        {
                            ProductoId = producto.Id,
                            CodigoProducto = producto.Codigo,
                            DescripcionProducto = producto.Descripcion,
                            PrecioUnitario = producto.Precio,
                            CantidadProducto = nudCantidadArticulo.Value,
                        };
                }
                else
                {
                    MessageBox.Show(string.Format("Articulo no existe o no esta en lista precio {0}", delivery ? "delivery" : "kiosco")) ;
                }
            }

            ActualizarNudsGrid();
        }

        private void SetCantidad(string codigo, decimal cantidad)
        {
            if (detalles.TryGetValue(codigo, out DetalleComprobanteDTO det))
            {
                Console.WriteLine(cantidad);
                if (cantidad == 0) throw new Exception("No tendría que permitir producto con cantidad 0¿?");
                det.CantidadProducto = cantidad;
            } else
            {
                throw new Exception("Error al obtener el detalle desde el diccionario");
            }


            //ActualizarNudsGrid();

        }

        private void ActualizarNudsGrid()
        {
            dgvGrilla.DataSource = detalles.Values.ToList();
            ResetearGrilla(dgvGrilla);

            nudSubTotal.Value = detalles.Values.Sum(x => x.SubtotalLinea);
            nudTotal.Value = nudSubTotal.Value;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo();
        }

        private long consumidorFinalId = 2; // temporal, para no perder la referencia
        private void Facturar()
        {

            ////////////////
            //Comprobante//
            ////////////////
            ComprobanteDTO comprobante = new ComprobanteDTO
            {
                Fecha = DateTime.Now,
                UsuarioId = DatosSistema.UsuarioId,
                ClienteId = rbCtaCte.Checked ? idCliente : consumidorFinalId,
                Descuento = nudDescuento.Value,
                Items = detalles.Values.ToList()
            };

            //Forma Pago
            var formaDePago = TipoPago.Efectivo;
            if (rbCtaCte.Checked)
            {
                formaDePago = TipoPago.CtaCte;
            }
            if (rbTarjeta.Checked)
            {
                formaDePago = TipoPago.Tarjeta;
            }

            //formadepago.generar()

            ////////////////
            //Detalle Caja//
            ////////////////
            DetalleCajaDTO detalleCaja = new DetalleCajaDTO
            {
                CajaId = DatosSistema.CajaId,
                Monto = comprobante.Total,
                TipoPago = formaDePago
            };
            _detalleCajaServicio.Generar(detalleCaja);

            if (rbCtaCte.Checked)
            {
                if (_clienteServicio.DescontarDeCuenta(idCliente, comprobante.Total))
                {
                    //nada?
                }
                else
                {
                    throw new Exception("Si tiene menos de 0 deberia un cartel que no deje que siga el tema ya vemos yadayadayada");
                }
            }

            if (rbTarjeta.Checked)
            {
                //todo: generar comprobante tarjeta?
            }

            long comprobante_id;
            if (delivery)
            {
                comprobante_id = _comprobanteServicio.GenerarComprobanteDelivery(comprobante);
            }
            else
            {
                comprobante_id = _comprobanteServicio.Generar(comprobante);
            }

            //////////////
            //Movimiento//
            //////////////
            MovimientoDTO movimiento = new MovimientoDTO
            {
                CajaID = DatosSistema.CajaId,
                ComprobanteID = comprobante_id,
                TipoMovimiento = TipoMovimiento.Ingreso,
                UsuarioID = DatosSistema.UsuarioId,
                Monto = comprobante.Total,
                Fecha = DateTime.Now,
                Descripcion = "_____",
            };

            _movimientoServicio.GenerarMovimiento(movimiento);

            foreach (var d in detalles)
            {
                //todo:producto tendria que tener si descuenta stock o no...
                _articuloServicio.DescontarStock(d.Value.ProductoId, d.Value.CantidadProducto);
            }

            MessageBox.Show("Factura3", "Kiosco");
            Close();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (!DatosSistema.EstaCajaAbierta)
            {
                MessageBox.Show("Error al facturar: la caja no está abierta");
                return;
            }
            else
            {
                if (detalles.Count > 0)
                {
                    Facturar();
                }
                else
                {
                    MessageBox.Show("Cargue algun producto para facturar");
                }
            }
        }

        private void CbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            SetConsumidorFinal();
            
        }

        private void NudDescuento_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudSubTotal.Value - (nudSubTotal.Value * nudDescuento.Value) / 100;

            Console.WriteLine("Test debug");
        }

        private void DgvGrilla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int counter;
            
            //TODO que no acepte cero de cantidad(ninguno de los chequeos anda)
            for (counter = 1; counter < (dgvGrilla.Rows.Count - 1); counter++)
            {
                string codigo = dgvGrilla.Rows[counter].Cells["CodigoProducto"].Value.ToString();
                if (codigo != null)
                {
                    if (decimal.TryParse(dgvGrilla.Rows[counter].Cells["CantidadProducto"].Value.ToString(), out decimal cantidad))
                    {
                        SetCantidad(codigo, cantidad);
                    }

                }
            }

            ActualizarNudsGrid();
        }


        private void DgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dgvGrilla.Rows[e.RowIndex].Cells["CodigoProducto"].Value.ToString();
            detalles.Remove(codigo);
            ActualizarNudsGrid();
        }

        private void RbCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            SetConsumidorFinal();
            actualizarCbTarjeta();
        }

        private void RbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            SetConsumidorFinal();
            actualizarCbTarjeta();
        }

        private void actualizarCbTarjeta()
        {
            if (rbTarjeta.Checked)
            {
                cbTarjeta.Enabled = true;
                cbPlan.Enabled = true;
            }
            else
            {
                cbTarjeta.Enabled = false;
                cbPlan.Enabled = false;
            }
        }
        
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool vieneDeSelecFPago = true;
            FormularioClienteConsulta f = new FormularioClienteConsulta(vieneDeSelecFPago);

            f.ShowDialog();

            idCliente = f.clienteSeleccionado;

            //idCliente = ((Func<long>)(() => {FormularioClienteConsulta f_ = new FormularioClienteConsulta(true);f_.ShowDialog();return f_.clienteSeleccionado;}))();

            var cliente = _clienteServicio.ObtenerClientePorId(idCliente);
            if (cliente != null)
            {
                txtDniCliente.Text = cliente.Dni;
                txtApellidoCliente.Text = cliente.Apellido;
                txtNombreCliente.Text = cliente.Nombre;
            }
            
            //ObtenerClientePorId
            
            Console.WriteLine(idCliente);
            Console.WriteLine("Cerró");
        }

        private void cbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBox(cbPlan, _planTarjetaServicio.ObtenerPorIdTarjeta(((TarjetaDTO)cbTarjeta.SelectedItem).Id), "Descripcion", "Id");
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            long? idEmpleado = ((Func<long>)(() => { 
                var f_ = new FormularioEmpleadoConsulta(true); 
                f_.ShowDialog();
                return f_.empleadoSeleccionado; 
            }))();

            if (idEmpleado != null)
            {
                var empleado = _empleadoServicio.ObtenerEmpleadoPorId((long)idEmpleado);
                if (empleado != null)
                {
                    txtUsuarioEmpleado.Text = "";
                    txtNombreEmpleado.Text = empleado.Nombre;
                    txtApellidoEmpleado.Text = empleado.Apellido;
                }
            }

        }
    }
}
