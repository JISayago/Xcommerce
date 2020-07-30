using Presentacion.Core.Articulo;
using Presentacion.Core.Cliente;
using Presentacion.Core.Empleado;
using Presentacion.FormulariosBase;
using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicio.Core.Banco;
using XCommerce.Servicio.Core.Banco.DTO;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.DetalleCaja;
using XCommerce.Servicios.Core.DetalleCaja.DTO;
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.FormaPago;
using XCommerce.Servicios.Core.FormaPago.DTO;
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Movimiento.DTO;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Producto.DTO;
using XCommerce.Servicios.Core.Tarjeta;
using XCommerce.Servicios.Core.Tarjeta.DTO;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO;

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
        private readonly IListaPrecioServicio _listaPrecioServicio;
        private readonly IFormaPagoServicio _formaPagoServicio;
        private readonly IBancoServicio _bancoServicio;

        private Dictionary<string, DetalleComprobanteDTO> detalles;
        private long idCliente;
        private long idArticulo;

        public bool delivery = false;

        private string listaPrecio;

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
            _listaPrecioServicio = new ListaPrecioServicio();
            _formaPagoServicio = new FormaPagoServicio();
            _bancoServicio = new BancoServicio();

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

            listaPrecio = delivery ? "Delivery" : "Kiosco";
            if (!_listaPrecioServicio.Existe(listaPrecio))
            {
                MessageBox.Show(string.Format("Lista precio {0} no existe, imposible operar. Creala o kcyo", listaPrecio));
            }

            CargarComboBox(cbBanco, _bancoServicio.Obtener(""), "Descripcion", "Id");
            Set_Rbs();
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
                txtNombreCliente.Text = "";
                txtApellidoCliente.Text = "";
            }
            else 
            {
                txtDniCliente.Text = "99999999";
                txtNombreCliente.Text = "Consumidor";
                txtApellidoCliente.Text = "Final";
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
                ProductoMesaDTO producto = _productoServicio.ObtenerPorCodigoListaPrecio(listaPrecio, txtCodigoBarras.Text);

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
                    MessageBox.Show(string.Format("Articulo no existe o no esta en lista precio {0}", listaPrecio)) ;
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
            //TODO importante
            //faltan bocha de chequeos* SI o SI aca no al final ni en el medio porque si no se
            //puede cerrar el programa sin generar una de todas las huevadas que generamos acá
            //o generando un par y las otras no

            //*bocha de chequeos: txtclave y nombre tarjeta, cliente no en blanco, tarjeta con plan (o sin?)
            //y bueno asi, tambien dependiendo si estan checked o no los checkbox
            //me pa que deberia ir en otro metodo este ya ta full

            //atte: Juan
           
            //esto en un metodo aparte
            if (rbCtaCte.Checked)
            {
            }
            if (rbCheque.Checked)
            {
            }
            if (rbEfectivo.Checked)
            {
            }
            if (rbTarjeta.Checked)
            {
            }


            /////////////////
            ///COMPROBANTE///
            /////////////////
            ComprobanteDTO comprobante = new ComprobanteDTO
            {
                Fecha = DateTime.Now,
                UsuarioId = DatosSistema.UsuarioId,
                ClienteId = rbCtaCte.Checked ? idCliente : consumidorFinalId,
                Descuento = nudDescuento.Value,
                Items = detalles.Values.ToList()
            };

            long comprobante_id;
            if (delivery)
            {
                comprobante_id = _comprobanteServicio.GenerarComprobanteDelivery(comprobante);
            }
            else
            {
                comprobante_id = _comprobanteServicio.Generar(comprobante);
            }

            ////////////////
            //Detalle Caja//
            ////////////////
            //tipo pago
            var formaDePago = TipoPago.Efectivo;
            if (rbCtaCte.Checked)
            {
                formaDePago = TipoPago.CtaCte;
            }
            if (rbTarjeta.Checked)
            {
                formaDePago = TipoPago.Tarjeta;
            }
            DetalleCajaDTO detalleCaja = new DetalleCajaDTO
            {
                CajaId = DatosSistema.CajaId,
                Monto = comprobante.Total,
                TipoPago = formaDePago
            };
            _detalleCajaServicio.Generar(detalleCaja);

            ////////////////
            ///FORMA PAGO///
            ////////////////

            if (rbEfectivo.Checked)
            {
                FormaPagoEfectivoDTO fp = new FormaPagoEfectivoDTO
                {
                    TipoFormaPago = TipoFormaPago.Efectivo,
                    Monto = nudTotal.Value,
                    ComprobanteId = comprobante_id,
                };
                _formaPagoServicio.Generar(fp);
            }

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

                FormaPagoCtaCteDTO fp = new FormaPagoCtaCteDTO
                {
                    TipoFormaPago = TipoFormaPago.CuentaCorriente,
                    Monto = nudTotal.Value,
                    ComprobanteId = comprobante_id,
                    ClienteId = idCliente,
                };
                _formaPagoServicio.Generar(fp);
            }

            if (rbCheque.Checked)
            {
                FormaPagoChequeDTO fp = new FormaPagoChequeDTO
                {
                    TipoFormaPago = TipoFormaPago.Cheque,
                    Monto = nudTotal.Value,
                    ComprobanteId = comprobante_id,
                    BancoId = ((BancoDTO)cbBanco.SelectedItem).Id,
                    Dias = (int)nudDiasCheque.Value,
                    EnteEmisor = txtEnteCheque.Text,
                    FechaEmision = dtFechaCheque.Value,
                    Numero = txtNumeroCheque.Text,
                };

                _formaPagoServicio.Generar(fp);
            }

            if (rbTarjeta.Checked)
            {
                FormaPagoTarjetaDTO fp = new FormaPagoTarjetaDTO
                {
                    TipoFormaPago = TipoFormaPago.Tarjeta,
                    Monto = nudTotal.Value,
                    ComprobanteId = comprobante_id,
                    Numero = txtNumeroTarjeta.Text, 
                    Cupon = "", //TODO ????
                    PlanTarjetaId = ((PlanTarjetaDTO)cbPlan.SelectedItem).Id,
                    NumeroTarjeta = txtClaveTarjeta.Text
                };

                _formaPagoServicio.Generar(fp);
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


        //pasarle el parametro e que viene del evento de la grilla
        private void EliminarProducto(DataGridViewCellEventArgs e)
        {
            string codigo = dgvGrilla.Rows[e.RowIndex].Cells["CodigoProducto"].Value.ToString();
            detalles.Remove(codigo);
            ActualizarNudsGrid();
        }
        private void DgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EliminarProducto(e);
        }

        //rbs == los checkbox no se xq
        private void Set_Rbs()
        {
            SetConsumidorFinal();

            if (rbCtaCte.Checked) CambiarEnableControlsGb(gbCliente, true); else CambiarEnableControlsGb(gbCliente, false);
            if (rbTarjeta.Checked) CambiarEnableControlsGb(gbTarjeta, true); else CambiarEnableControlsGb(gbTarjeta, false);
            if (rbCheque.Checked) CambiarEnableControlsGb(gbCheque, true); else CambiarEnableControlsGb(gbCheque, false);
        }

        private void RbCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            Set_Rbs();
        }

        private void RbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            Set_Rbs();
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            Set_Rbs();
        }

        private void CambiarEnableControlsGb(GroupBox gb, bool enable)
        {
            foreach (Control c in gb.Controls)
            {
                c.Enabled = enable;
                Console.WriteLine(c.Name);
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarArticulo();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            bool vieneDeMesaKiosco = true;
            FormularioArticuloConsulta fAConsulta = new FormularioArticuloConsulta(vieneDeMesaKiosco);

            fAConsulta.ShowDialog();

            idArticulo = fAConsulta.articuloSeleccionado;

            if (idArticulo == 0)
            {
                MessageBox.Show("No se seleccionó ningún artículo");
            }
            else
            {
                var articulo = _articuloServicio.ObtenerPorId(idArticulo);
                if (articulo == null)
                {
                    MessageBox.Show("Articulo no existe o no se encuentra en lista precio de este Salon.");
                }
                else
                {                    
                    var producto = _productoServicio.ObtenerPorCodigoListaPrecio(listaPrecio, articulo.Codigo);
                    if (producto != null)
                    {
                        txtCodigoBarras.Text = producto.CodigoBarra;
                        txtDescripcion.Text = producto.Descripcion;
                        txtPrecio.Text = Convert.ToString(producto.Precio);

                    }
                    else
                    {
                        MessageBox.Show("Articulo no existe o no se encuentra en lista precio de este Salon.");

                    }
                }
            }        
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                AgregarArticulo();
            }
        }
    }
}