using System.Windows.Forms;
using XCommerce.Servicios.Core.Caja.DetalleCaja;

namespace Presentacion.Core.DetalleCaja
{
    public partial class FormularioDetalleCaja : Form
    {

        private IDetalleCajaServicio _detalleCajaServicio;

        public FormularioDetalleCaja()
        {
            InitializeComponent();

            _detalleCajaServicio = new DetalleCajaServicio();

            Filtrar();
        }

        private void Filtrar()
        {
            var detalles = _detalleCajaServicio.Obtener(null, null);

            if (detalles != null)
            {
                dgvGrilla.DataSource = detalles;
            }
        }
    }
}
