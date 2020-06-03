using Presentacion.FormulariosBase;
using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.DetalleCaja;
using XCommerce.Servicios.Core.DetalleCaja.DTO;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Movimiento.DTO;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Producto.DTO;

namespace Presentacion.Core.Kiosco
{
    public partial class FormularioKiosco : FormularioBase
    {
        //private readonly IArticuloServicio _articuloServicio;
        private readonly IProductoServicio _productoServicio;
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IDetalleCajaServicio _detalleCajaServicio;
        private readonly IMovimientoServicio _movimientoServicio;
        private Dictionary<string, DetalleComprobanteDTO> detalles;

        public FormularioKiosco()
        {
            InitializeComponent();
            //ResetearGrilla(dgvGrilla);
            _productoServicio = new ProductoServicio();
            _comprobanteServicio = new ComprobanteServicio();
            _detalleCajaServicio = new DetalleCajaServicio();
            _movimientoServicio = new MovimientoServicio();

            detalles = new Dictionary<string, DetalleComprobanteDTO>();
            txtNombreEmpleado.Text = DatosSistema.NombreUsuario;
            SetConsumidorFinal();
        }

        private void SetConsumidorFinal()
        {
            if (cbConsumidorFinal.Checked)
            {
                txtDniCliente.Text = "99999999";
                txtDniCliente.Enabled = false;
                txtNombreCliente.Text = "Consumidor";
                txtNombreCliente.Enabled = false;
                txtApellidoCliente.Text = "Final";
                txtApellidoCliente.Enabled = false;
            } else
            {
                txtDniCliente.Text = "";
                txtDniCliente.Enabled = true;
                txtNombreCliente.Text = "";
                txtNombreCliente.Enabled = true;
                txtApellidoCliente.Text = "";
                txtApellidoCliente.Enabled = true;
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
                det.CantidadProducto += nudCantidadArticulo.Value;
            }
            else
            {
                ProductoMesaDTO producto = _productoServicio.ObtenerPorCodigoKiosco(txtCodigoBarras.Text);

                if (producto != null)
                {
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
                    MessageBox.Show("Articulo no existe o no esta en lista precio kiosco.");
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

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (!DatosSistema.EstaCajaAbierta)
            {
                MessageBox.Show("Error al facturar: la caja no está abierta");
                return;
            }
            else
            {
                ComprobanteDTO comprobante = new ComprobanteDTO
                {
                    Fecha = DateTime.Now,
                    UsuarioId = DatosSistema.UsuarioId,
                    ClienteId = 2,
                    Descuento = nudDescuento.Value,
                    Items = detalles.Values.ToList()
                };

                DetalleCajaDTO detalleCaja = new DetalleCajaDTO
                {
                    CajaId = DatosSistema.CajaId,
                    Monto = comprobante.Total,
                    TipoPago = TipoPago.Efectivo //directo de acceso datos??
                };

                //detallecajadto detallecaja = new detallecaja;
                long comproboante_id = _comprobanteServicio.Generar(comprobante);
                _detalleCajaServicio.Generar(detalleCaja);

                MovimientoDTO movimiento = new MovimientoDTO
                {
                    CajaID = DatosSistema.CajaId,
                    ComprobanteID = comproboante_id,
                    TipoMovimiento = TipoMovimiento.Ingreso,
                    UsuarioID = DatosSistema.UsuarioId,
                    Monto = comprobante.Total,
                    Fecha = DateTime.Now,
                    Descripcion = "_____",
                };
                _movimientoServicio.GenerarMovimiento(movimiento);

                MessageBox.Show("factura3");
                Close();
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
    }
}
