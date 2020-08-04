using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.Servicios.Core.Caja;

namespace Presentacion.Core.Caja
{
    public partial class FormularioArqueos : Form
    {
        private readonly ICajaServicio _cajaServicio;
        public FormularioArqueos()
        {
            InitializeComponent();

            _cajaServicio = new CajaServicio();

            dgvGrilla.DataSource = _cajaServicio.ObtenerTodas();

            resetear_grilla();
        }

        void Filtrar()
        {
            var data = _cajaServicio.ObtenerTodas().Where(x => x.FechaCierre >= dtDesde.Value && x.FechaCierre <= dtHasta.Value).ToList();
            dgvGrilla.DataSource = data;

            if(data.Any()) resetear_grilla();
        }

        private void resetear_grilla()
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;


            }

            dgvGrilla.Columns["Id"].Visible = true;
            dgvGrilla.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Id"].HeaderText = "Id";


            dgvGrilla.Columns["MontoCierre"].Visible = true;
            dgvGrilla.Columns["MontoCierre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["MontoCierre"].HeaderText = "Cierre";


            dgvGrilla.Columns["MontoSistema"].Visible = true;
            dgvGrilla.Columns["MontoSistema"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["MontoSistema"].HeaderText = "Sistema";

            dgvGrilla.Columns["Diferencia"].Visible = true;
            dgvGrilla.Columns["Diferencia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["Diferencia"].HeaderText = "Diferencia";

            dgvGrilla.Columns["FechaCierre"].Visible = true;
            dgvGrilla.Columns["FechaCierre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["FechaCierre"].HeaderText = "Fecha";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
