using Presentacion.Core.Articulo;
using Presentacion.FormulariosBase;
using Presentacion.FormulariosBase.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Articulo.DTO;
using XCommerce.Servicios.Core.CondicionIva;
using XCommerce.Servicios.Core.Proveedor;

namespace Presentacion.Core.Proveedor
{
    public partial class FormularioIngresoArticulos : FormularioBase
    {
        private readonly IProveedorServicio _proveedorServicio;
        private readonly ICondicionIvaServicio _condicionIvaServicio;
        private readonly IArticuloServicio _articuloServicio;
        public List<ArticuloDTO> listaIngresos;
        private long idArticulo;
        private long idProveedor;
        public FormularioIngresoArticulos()
        {
            InitializeComponent();

            _proveedorServicio = new ProveedorServicio();
            _condicionIvaServicio = new CondicionIvaServicio();
            _articuloServicio = new ArticuloServicio();
            listaIngresos = new List<ArticuloDTO>();
        }

        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["Codigo"].Visible = true;
            grilla.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Codigo"].HeaderText = "Codigo";

            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Descripcion";

            grilla.Columns["PrecioCosto"].Visible = true;
            grilla.Columns["PrecioCosto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioCosto"].HeaderText = "Precio Costo";

            grilla.Columns["Stock"].Visible = true;
            grilla.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Stock"].HeaderText = "Stock";
            grilla.Columns["Stock"].DefaultCellStyle.Format = "N2";

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormularioProveedorABM fAbm = new FormularioProveedorABM(FormulariosBase.Helpers.TipoOperacion.Nuevo);
            fAbm.ShowDialog();
        }


        private void ActualizarNudsGrid()
        {
            dgvGrilla.DataSource = listaIngresos;
            ResetearGrilla(dgvGrilla);

            //nudSubTotal.Value = detalles.Values.Sum(x => x.SubtotalLinea);
            //nudTotal.Value = nudSubTotal.Value;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            bool vieneDeProveedor = true;
            FormularioProveedorConsulta f = new FormularioProveedorConsulta(vieneDeProveedor);

            f.ShowDialog();

            idProveedor = f.proveedorSelecionaso;

           
            var proveedor = _proveedorServicio.ObtenerPorId(idProveedor);
            var condicionIva = _condicionIvaServicio.ObtenerPorId(proveedor.CondicionIvaId);
            if (proveedor != null)
            {
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

            

            var articulo = _articuloServicio.ObtenerPorId(idArticulo);
            if (articulo != null)
            {
                var dto = new ArticuloDTO()
                {
                    Descripcion = articulo.Descripcion,
                    Abreviatura = articulo.Abreviatura,
                    Codigo = articulo.Codigo,
                    CodigoBarra = articulo.CodigoBarra,
                    ActivarLimiteVenta = articulo.ActivarLimiteVenta,
                    DescuentaStock = articulo.DescuentaStock,
                    Detalle = articulo.Detalle,
                    EstaDiscontinuado = articulo.EstaDiscontinuado,
                    EstaEliminado = articulo.EstaEliminado,
                    Foto = articulo.Foto,
                    Id = articulo.Id,
                    LimiteVenta = articulo.LimiteVenta,
                    MarcaId = articulo.MarcaId,
                    PermiteStockNegativo = articulo.PermiteStockNegativo,
                    RubroId = articulo.RubroId,
                    Stock = articulo.Stock,
                    StockMaximo = articulo.StockMaximo,
                    StockMinimo = articulo.StockMinimo

                };
                listaIngresos.Add(dto);

                ActualizarNudsGrid();
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

     
    }
}
