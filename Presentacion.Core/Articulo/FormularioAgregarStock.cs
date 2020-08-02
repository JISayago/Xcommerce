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
using XCommerce.Servicios.Core.Articulo.BajaArticulo;

namespace Presentacion.Core.Articulo
{
    public partial class FormularioAgregarStock : Form
    {
        private IArticuloServicio _articuloServicio;

        public FormularioAgregarStock(long entidadId)
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e, long entidadId)
        {

            _articuloServicio = new ArticuloServicio();

            //sumar el stock a articulo
            decimal stockAgregar = nudCantidad.Value;

            //_articuloServicio.AgregarStock(entidadId, stockAgregar);

            this.Close();
        }
    }
}
