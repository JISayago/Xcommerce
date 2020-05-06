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
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.ListaPrecio.DTO;
using XCommerce.Servicios.Core.Precio;
using XCommerce.Servicios.Core.Precio.DTO;

namespace Presentacion.Core.Precio
{
    public partial class FormularioActualizarPrecio : FormularioBaseABM
    {
        private IPrecioServicio _precioServicio;
        private IArticuloServicio _articuloServicio;
        private IListaPrecioServicio _listaPrecioServicio;
        long? entidadId = null; 
        public FormularioActualizarPrecio()
        {
            InitializeComponent();
        }

        public override void FormularioBaseABM_Load(object sender, EventArgs e)
        {
            base.FormularioBaseABM_Load(sender, e);
            Inicializador(EntidadId);
        }
        public FormularioActualizarPrecio(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();


            _precioServicio = new PrecioServicio();
            _listaPrecioServicio = new ListaPrecioServicio();
            _articuloServicio = new ArticuloServicio();

            CargarComboBox(cmbArticulo, _articuloServicio.Obtener(string.Empty), "Descripcion", "Id");
            CargarComboBox(cmbListaPrecio, _listaPrecioServicio.Obtener(string.Empty), "Descripcion", "Id");

            this.entidadId = entidadId;
            CargarDatos(entidadId);
        }

        public override void Inicializador(long? entidadId)
        {
            if (entidadId.HasValue) return;


        }

        public override void CargarDatos(long? entidadId)
        {
            if (!entidadId.HasValue)
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.Close();
            }

            if (TipoOperacion == TipoOperacion.Eliminar)
            {
                btnLimpiar.Enabled = false;
            }

           
            var precio = _precioServicio.ObtenerPorId(entidadId.Value);

            if (precio != null)
            {

                lblNombreArticulo.Text = precio.DescripcionArticulo;
                nudPrecioCosto.Value = precio.PrecioCosto;
                nudPrecioPublico.Value = precio.PrecioPublico;

                //todo chquear
                int index = cmbArticulo.FindString(precio.DescripcionArticulo); 
                cmbArticulo.SelectedIndex = index;

                index = cmbListaPrecio.FindString(precio.NombreListaPrecio);
                cmbListaPrecio.SelectedIndex = index;

            }
            else
            {
                MessageBox.Show(@"Ocurrio un Error Grave", @"Error Grave", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public override bool EjecutarComandoNuevo()
        {
            var precioNuevo = new PrecioDTO
            {
                ArticuloId = ((ArticuloDTO)cmbArticulo.SelectedItem).Id,
                PrecioCosto = nudPrecioCosto.Value,
                PrecioPublico = nudPrecioPublico.Value,
                ListaPrecioId = ((ListaPrecioDTO)cmbListaPrecio.SelectedItem).Id,
                ActivarHoraVenta = false,
                FechaActualizacion = DateTime.Now,
                HoraVenta = DateTime.Now,
            };

            _precioServicio.Insertar(precioNuevo);
            return true;

        }

        public override bool EjecutarComandoModificar()
        {
            EjecutarComandoNuevo();
            return true;

        }

        private void ActualizarNudPrecios()
        {
            ArticuloDTO art = (ArticuloDTO)cmbArticulo.SelectedItem;
            ListaPrecioDTO lp = (ListaPrecioDTO)cmbListaPrecio.SelectedItem;
            var precio = _precioServicio.ObtenerPorArticuloListaPrecio(art.Id, lp.Id);
            EntidadId = art.Id;

            if (precio != null)
            {

                nudPrecioPublico.Value = precio.PrecioPublico;
                nudPrecioCosto.Value = precio.PrecioCosto;
            }
            else
            {
                nudPrecioPublico.Value = 0;
                nudPrecioCosto.Value = 0;
            }

        }


        private void CmbArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualizarNudPrecios();
        }

        private void CmbListaPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualizarNudPrecios();
        }
    }
}
