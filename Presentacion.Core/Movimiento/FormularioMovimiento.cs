using Presentacion.Core.Comprobante;
using Presentacion.Core.Empleado;
using System;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.Movimiento;

namespace Presentacion.Core.Movimiento
{
    public partial class FormularioMovimiento : Form
    {
        private IMovimientoServicio _movimientoServicio;
        private IEmpleadoServicio _empleadoServicio;
        private enum _TipoMov { Ingreso = 1, Egreso = -1, Ambos = 0}
        private long? idEmpleado = null; 
        public FormularioMovimiento()
        {
            InitializeComponent();

            cmbTipo.DataSource = Enum.GetValues(typeof(_TipoMov));

            _movimientoServicio = new MovimientoServicio();
            _empleadoServicio = new EmpleadoServicio();
            Filtrar();
            ResetearGrilla(dgvGrilla);
        }

        public  void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["Tipo"].Visible = true;
            grilla.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Tipo"].HeaderText = "Tipo de Movimiento";

            grilla.Columns["Monto"].Visible = true;
            grilla.Columns["Monto"].Width = 100;
            grilla.Columns["Monto"].HeaderText = "Monto";

            grilla.Columns["Fecha"].Visible = true;
            grilla.Columns["Fecha"].Width = 130;
            grilla.Columns["Fecha"].HeaderText = "Fecha";

            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].Width = 130;
            grilla.Columns["Descripcion"].HeaderText = "Descripcion";

        }

        private void Filtrar()
        {
            //var movimientos = _movimientoServicio.Obtener(DateTime.MinValue, DateTime.Now, null, null, null);
            TipoMovimiento? tipo = null;
            long? _idEmpleado = null;
            if (cmbTipo.SelectedItem != null && (_TipoMov)cmbTipo.SelectedItem != _TipoMov.Ambos) tipo = (TipoMovimiento)cmbTipo.SelectedItem;
            if (idEmpleado != null) _idEmpleado = idEmpleado;

            var movimientos = _movimientoServicio.Obtener(dtDesde.Value, dtHasta.Value, tipo, _idEmpleado, null);
            
            if (movimientos != null)
            {
                dgvGrilla.DataSource = movimientos;
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idEmpleado = ((Func<long?>)(() => 
            {
                var f_ = new FormularioEmpleadoConsulta(true);
                f_.ShowDialog();
                return f_.empleadoSeleccionado;
            }))();

            Console.WriteLine(idEmpleado);
            if(idEmpleado != null) txtNombreUsuario.Text = _empleadoServicio.ObtenerEmpleadoPorId((long)idEmpleado).ApyNom;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idEmpleado = null;
            txtNombreUsuario.Text = "";
        }

        long? comprobanteSeleccionadoId = null;
        private void btnComprobante_Click(object sender, EventArgs e)
        {
           
            if (comprobanteSeleccionadoId != null)
            {
                var f_ = new FormularioComprobante((long)comprobanteSeleccionadoId);
                f_.Show();
            }

        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                comprobanteSeleccionadoId = (long?)dgvGrilla["Id", e.RowIndex].Value;
            }

        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            dtDesde.MaxDate = dtHasta.Value;
        }
    }
}
