using System.Linq;
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

            Filtrar(true);
        }

        private void Filtrar(bool todas_fechas)
        {
            var detalles = _detalleCajaServicio.Obtener(null, null);

            if (!todas_fechas) detalles = detalles.Where(x => x.caja.FechaCierre >= dtDesde.Value && x.caja.FechaCierre <= dtHasta.Value).ToList();
            if (detalles != null)
            {
                dgvGrilla.DataSource = detalles;
            }

            dgvGrilla.Columns["Monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Caja"].Visible = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Filtrar(false);
        }
    }
}
