using Presentacion.Core.Articulo;
using Presentacion.FormulariosBase;
using Presentacion.FormulariosBase.Helpers;
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
using XCommerce.Servicios.Core.Articulo.DTO;

using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.CondicionIva;
using XCommerce.Servicios.Core.DetalleCaja;
using XCommerce.Servicios.Core.DetalleCaja.DTO;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Movimiento.DTO;
using XCommerce.Servicios.Core.Proveedor;

namespace Presentacion.Core.Proveedor
{
    public partial class FormularioIngresoArticulos : FormularioBase
    {
        private readonly IProveedorServicio _proveedorServicio;
        private readonly ICondicionIvaServicio _condicionIvaServicio;
        private readonly IArticuloServicio _articuloServicio;
        private readonly IMovimientoServicio _movimientoServicio;
        private readonly IComprobanteServicio _comprobanteServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IDetalleCajaServicio _detalleCajaServicio;
        private Dictionary<string, DetalleComprobanteDTO> detalles;
        private long idArticulo;
        private long idProveedor;

        public FormularioIngresoArticulos()
        {
            InitializeComponent();

            _proveedorServicio = new ProveedorServicio();
            _condicionIvaServicio = new CondicionIvaServicio();
            _articuloServicio = new ArticuloServicio();
            _movimientoServicio = new MovimientoServicio();
            _comprobanteServicio = new ComprobanteServicio();
            _clienteServicio = new ClienteServicio();
            _detalleCajaServicio = new DetalleCajaServicio();
            detalles = new Dictionary<string, DetalleComprobanteDTO>();


            AgregarControlesObligatorios(txtContacto, "Contacto");
            AgregarControlesObligatorios(txtEmail, "Email");
            AgregarControlesObligatorios(txtRazonSocial, "RazonSocial");
            AgregarControlesObligatorios(txtTelefono, "Telefono");
            AgregarControlesObligatorios(txtCondicionIva, "CondicionIva");
        }

        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["CodigoProducto"].Visible = true;
            grilla.Columns["CodigoProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CodigoProducto"].HeaderText = "Codigo";

            grilla.Columns["DescripcionProducto"].Visible = true;
            grilla.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["DescripcionProducto"].HeaderText = "Descripcion";

            grilla.Columns["PrecioUnitario"].Visible = true;
            grilla.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioUnitario"].HeaderText = "Precio Costo";

            grilla.Columns["CantidadProducto"].Visible = true;
            grilla.Columns["CantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CantidadProducto"].HeaderText = "Stock";
            grilla.Columns["CantidadProducto"].DefaultCellStyle.Format = "N2";

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormularioProveedorABM fAbm = new FormularioProveedorABM(FormulariosBase.Helpers.TipoOperacion.Nuevo);
            fAbm.ShowDialog();
        }


        private void ActualizarNudsGrid()
        {
            dgvGrilla.DataSource = detalles.Values.ToList();
            ResetearGrilla(dgvGrilla);

            nudSubTotal.Value = detalles.Values.Sum(x => x.SubtotalLinea);
            nudTotal.Value = nudSubTotal.Value;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            bool vieneDeProveedor = true;
            FormularioProveedorConsulta f = new FormularioProveedorConsulta(vieneDeProveedor);

            f.ShowDialog();

            idProveedor = f.proveedorSelecionaso;

           
            var proveedor = _proveedorServicio.ObtenerPorId(idProveedor);
           
            if (proveedor != null)
            {
                var condicionIva = _condicionIvaServicio.ObtenerPorId(proveedor.CondicionIvaId);
                txtCondicionIva.Text = condicionIva.Descripcion;
                txtContacto.Text = proveedor.Contacto;
                txtEmail.Text = proveedor.Email;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtTelefono.Text = proveedor.Telefono;
            }
      
        }

        private void btnArticuloNuevo_Click(object sender, EventArgs e)
        {
            var fArtAlta = new FormularioArticuloABM(TipoOperacion.Nuevo);
            fArtAlta.ShowDialog();
        }

        private void btnArticuloExistente_Click(object sender, EventArgs e)
        {

            bool vieneDeSelecArticulo = true;
            FormularioArticuloConsulta formArticulo = new FormularioArticuloConsulta(vieneDeSelecArticulo);

            formArticulo.ShowDialog();

            idArticulo = formArticulo.articuloSeleccionado;

            if(idArticulo != 0)
            {

                var formularioModificar = new FormularioArticuloABM(TipoOperacion.Modificar, idArticulo);
                formularioModificar.ShowDialog();

                var articulo = _articuloServicio.ObtenerPorId(idArticulo);
                if (articulo != null)
                {
                    detalles[$"{articulo.Codigo}"] =
                                new DetalleComprobanteDTO
                                {
                                    ProductoId = articulo.Id,
                                    CodigoProducto = articulo.Codigo,
                                    DescripcionProducto = articulo.Descripcion,
                                    PrecioUnitario = articulo.PrecioCosto,
                                    CantidadProducto = 0m,

                                };
                }               
            }
            ActualizarNudsGrid();

        }

        private void btnAgragarAlInventario_Click(object sender, EventArgs e)
        {
            bool vieneDeSelecArticulo = true;
            FormularioArticuloConsulta formArticulo = new FormularioArticuloConsulta(vieneDeSelecArticulo);

            formArticulo.ShowDialog();

            idArticulo = formArticulo.articuloSeleccionado;

            var articulo = _articuloServicio.ObtenerPorId(idArticulo);
            if (articulo != null)
            {
                detalles[$"{articulo.Codigo}"] =
                           new DetalleComprobanteDTO
                           {
                               ProductoId = articulo.Id,
                               CodigoProducto = articulo.Codigo,
                               DescripcionProducto = articulo.Descripcion,
                               PrecioUnitario = articulo.PrecioCosto,
                               CantidadProducto = 0m,
                           };

            }

            ActualizarNudsGrid();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (DatosSistema.EstaCajaAbierta)
            {
                if (detalles != null)
                {
                    foreach (var item in detalles)
                    {
                        int i = 0;
                        if (decimal.TryParse(dgvGrilla.Rows[i].Cells["CantidadProducto"].Value.ToString(), out decimal cantidad))
                        {
                            _articuloServicio.AgregarStock(item.Key, cantidad);
                            i++;
                        }

                    }
                    RegistrarListadoArticulos();
                }
                else
                {
                    MessageBox.Show("No se puede Registrar una lista de articulos vacía.", "Advertencia");

                }
            } else
            {
                MessageBox.Show("La caja debe estar abierta.", "Advertencia");
            }
        }

        private bool RegistrarListadoArticulos()
        {
            if (!VerificarDatosObligatorios())
            {
                MessageBox.Show(@"Por favor ingrese los campos Obligatorios.", @"Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            /////////////////
            ///COMPROBANTE///
            /////////////////
            ///
            long clienteId = _clienteServicio.ObtenerClientePorDni("99999999").Id;
            long proveedorId = _proveedorServicio.ObtenerRazonSocial(txtRazonSocial.Text).Id;
            
            ComprobanteCompraDTO comprobante = new ComprobanteCompraDTO
            {
                 
                Fecha = DateTime.Now,
                ProveedorId = proveedorId,
                UsuarioId = DatosSistema.UsuarioId,                
                ClienteId = clienteId,
                Descuento = nudDescuento.Value,         
               
                Items = detalles.Values.ToList()
            };

            long comprobante_id;
         
            comprobante_id = _comprobanteServicio.GenerarComprobanteCompra(comprobante);

            DetalleCajaDTO detalleCaja = new DetalleCajaDTO
            {
                CajaId = DatosSistema.CajaId,
                Monto = comprobante.Total,
                TipoPago = TipoPago.Efectivo
            };
            _detalleCajaServicio.Generar(detalleCaja);

            //////////////
            //Movimiento//
            //////////////
            MovimientoDTO movimiento = new MovimientoDTO
            {
                CajaID = DatosSistema.CajaId,
                ComprobanteID = comprobante_id,
                Tipo = TipoMovimiento.Egreso,
                UsuarioID = DatosSistema.UsuarioId,
                Monto = comprobante.Total,
                Fecha = DateTime.Now,
             };

            _movimientoServicio.GenerarMovimiento(movimiento);
          
            
            Close();

            return true;

        }

        private void dgvGrilla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarNudsGrid();
        }
    }

}
