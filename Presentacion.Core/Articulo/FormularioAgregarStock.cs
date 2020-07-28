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
        private readonly long entidadId;
        private IArticuloServicio _articuloServicio;

        public FormularioAgregarStock(long entidadId)
        {
            InitializeComponent();
            this.entidadId = entidadId;

        }

        private void ArticuloAgregarStock(long entidadId)
        {
            _articuloServicio = new ArticuloServicio();

            decimal stockAgregar = nudCantidad.Value;

            _articuloServicio.AgregarStock(entidadId, stockAgregar);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ArticuloAgregarStock(entidadId);

            this.Close();
        }
    }
}
