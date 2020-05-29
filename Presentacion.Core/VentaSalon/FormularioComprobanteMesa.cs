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
using XCommerce.Servicios.Core.Caja.DetalleCaja;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Empleado.Mozo;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioComprobanteMesa : FormularioBase
    {
        private readonly long _mesaId;
       
        private readonly long _comproId;
        
        private readonly IComprobanteSalonServicio _comprobanteSalonServicio;

        private readonly IMovimientoServicio _movimientoServicio;

        private readonly IDetalleCajaServicio _detalleCajaServicio;

        private readonly IProductoServicio _productoServicio;

        private readonly IMozoServicio _mozoServicio;

        private readonly IMesaServicio _mesaServicio;

        private  TipoFormaPago _tfPAgo;

        private  TipoPago _tPago;


        public FormularioComprobanteMesa() : this(new ComprobanteSalonServicio(),
                                                  new ProductoServicio(),
                                                  new MozoServicio(),
                                                  new MovimientoServicio(),
                                                  new DetalleCajaServicio(),
                                                  new MesaServicio())
        {
            InitializeComponent();


        }
        public FormularioComprobanteMesa(IComprobanteSalonServicio comprobanteSalonServicio, 
                                         IProductoServicio productoServicio,
                                         IMozoServicio mozoServicio,
                                         IMovimientoServicio movimientoServicio,
                                         IDetalleCajaServicio detalleCajaServicio,
                                         IMesaServicio mesaServicio)
        {
            _comprobanteSalonServicio = comprobanteSalonServicio;
            _productoServicio = productoServicio;
            _mozoServicio = mozoServicio;
            _movimientoServicio = movimientoServicio;
            _detalleCajaServicio = detalleCajaServicio;
            _mesaServicio = mesaServicio;


        }

     
        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["CodigoProducto"].Visible = true;
            grilla.Columns["CodigoProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CodigoProducto"].HeaderText = "Codigo del Producto";

            grilla.Columns["DescripcionProducto"].Visible = true;
            grilla.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["DescripcionProducto"].HeaderText = "Descripcion";

            grilla.Columns["CantidadProducto"].Visible = true;
            grilla.Columns["CantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CantidadProducto"].HeaderText = "Cantidad";

            grilla.Columns["PrecioUnitario"].Visible = true;
            grilla.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";

            grilla.Columns["SubtotalLinea"].Visible = true;
            grilla.Columns["SubtotalLinea"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["SubtotalLinea"].HeaderText = "Sub-Total";

        }
        public FormularioComprobanteMesa(long mesaId, int _numeroMesa, bool cerrarMesa) : this()
        {
            if (cerrarMesa)
            {
                cerrarLaMesa(mesaId, _numeroMesa);
            }
        }
        

        public FormularioComprobanteMesa(long mesaId, int _numeroMesa,long comproId) : this()
        {
            this.Text = $"Venta -- Mesa: {_numeroMesa}";
            _mesaId = mesaId;
          
            ObtenerComprobanteMesa(mesaId,comproId);

            ResetearGrilla(dgvGrilla);
            _comproId = comproId;
        }
             

        private void ObtenerComprobanteMesa(long mesaId, long comproId = -1)
        {
            var comprobanteMesaDTO = new ComprobanteMesaDTO();
            if (comproId == -1)
            {
                 comprobanteMesaDTO = _comprobanteSalonServicio.Obtener(mesaId);
            }
            else
            {
                comprobanteMesaDTO = _comprobanteSalonServicio.ObtenerPorId(mesaId, comproId);
            }

            if(comprobanteMesaDTO == null)
            {
                MessageBox.Show("Ocurrió un Error");
                this.Close();
            }

            txtMozoLegajo.Text = Convert.ToString(comprobanteMesaDTO.Legajo);
            txtApyNomMozo.Text = comprobanteMesaDTO.ApyNomMozo;
            

            nudSubTotal.Value = comprobanteMesaDTO.SubTotal;
            nudDescuento.Value = comprobanteMesaDTO.Descuento;
            nudTotal.Value = comprobanteMesaDTO.Total;

            dgvGrilla.DataSource = comprobanteMesaDTO.Items.ToList();

            

        }


        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                busquedaArticulo();
            }
        }

        private void busquedaArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                MessageBox.Show("Por favor ingrese un codigo");
                return;
            }
            var producto = _productoServicio.ObtenerPorCodigo(_mesaId, txtCodigoBarras.Text);

            if (producto != null)
            {
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = Convert.ToString(producto.Precio);
                _comprobanteSalonServicio.AgregarItems(_mesaId, nudCantidadArticulo.Value, producto);

                ObtenerComprobanteMesa(_mesaId);
            }
        }

        private void txtMozoLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                buscarMozo();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            busquedaArticulo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarMozo();
        }

        private void buscarMozo()
        {
            if (string.IsNullOrEmpty(txtMozoLegajo.Text))
            {
                MessageBox.Show("Por favor ingrese un legajo");
                return;
            }

            var mozo = _mozoServicio.ObtenerMozoPorLegajo(Convert.ToInt32(txtMozoLegajo.Text));

            if (mozo != null)
            {
                txtMozoLegajo.Text = Convert.ToString(mozo.Legajo);
                txtApyNomMozo.Text = mozo.ApyNom;
                _mozoServicio.asignarMozoAMesa(_mesaId, mozo);

            }
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            var mesaNumero = _mesaServicio.ObtenerPorId(_mesaId).Numero;
            cerrarLaMesa(_mesaId, mesaNumero);
            
        }


        private void cerrarLaMesa(long mesaId,int numeroMesa)
        {
           
            if(rdbCheque.Checked == true)
            {
               _tfPAgo = TipoFormaPago.Cheque;
               
            }
            if(rdbEfectivo.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Efectivo;
                _tPago = TipoPago.Efectivo;
            }
            if(rdbTarjeta.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Tarjeta;
                _tPago = TipoPago.Tarjeta;
            }
            if(rdbCtaCte.Checked == true)
            {
                _tfPAgo = TipoFormaPago.CuentaCorriente;
                _tPago = TipoPago.CtaCte;
            }

            var comprobanteMesaDto = _comprobanteSalonServicio.Obtener(mesaId);
            _comprobanteSalonServicio.CambiarEstadoComprobante(mesaId, comprobanteMesaDto.ComprobanteId);
            
            var mesaParaCerrar = _mesaServicio.ObtenerPorId(mesaId);
            mesaParaCerrar.estadoMesa = EstadoMesa.Cerrada;
            _mesaServicio.Modificar(mesaParaCerrar);          
            
            _movimientoServicio.GenerarMovimiento(DatosSistema.CajaId, comprobanteMesaDto.ComprobanteId, TipoMovimiento.Ingreso, DatosSistema.UsuarioId, nudTotal.Value, $" Ingreso de Mesa n°:{numeroMesa}");
            _detalleCajaServicio.GenerarDetalleCaja(DatosSistema.CajaId, nudTotal.Value, _tPago);

            this.Close();
            

        }

        private void nudCantidadArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                if (string.IsNullOrEmpty(txtCodigoBarras.Text))
                {
                    txtCodigoBarras.Focus();
                }
                else
                {
                    busquedaArticulo();
                }
            }
        }
    }
}
