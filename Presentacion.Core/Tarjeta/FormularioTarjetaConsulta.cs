namespace Presentacion.Core.Tarjeta
{
    using System.Windows.Forms;
    using Helpers;
    using Presentacion.FormulariosBase;
    using Presentacion.FormulariosBase.Helpers;
    using XCommerce.Servicios.Core.Tarjeta;
    using XCommerce.Servicios.Core.Tarjeta.DTO;

    public partial class FormularioTarjetaConsulta : FormularioBaseConsulta
    {
        private readonly ITarjetaServicio _tarjetaServicio;

        public FormularioTarjetaConsulta()
            : this(new TarjetaServicio())
        {
            InitializeComponent();
            dgvGrilla.DataSource = _tarjetaServicio.Obtener("");

            ResetearGrilla(dgvGrilla);
        }

        public FormularioTarjetaConsulta(ITarjetaServicio TarjetaServicio)
        {
            _tarjetaServicio = TarjetaServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

         
            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = @"Tarjeta";
            grilla.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        public override void EjecutarBtnNuevo()
        {
            var fTarjetaAbm = new FormularioTarjetaABM(TipoOperacion.Nuevo);
            fTarjetaAbm.ShowDialog();
            dgvGrilla.DataSource = _tarjetaServicio.Obtener("");
        }

        public override void EjecutarBtnModificar()
        {
            if (!entidadId.HasValue) { MessageBox.Show("¡La grilla esta vacia!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            var fTarjetaAbm = new FormularioTarjetaABM(TipoOperacion.Modificar, entidadId);
            fTarjetaAbm.ShowDialog();
            dgvGrilla.DataSource = _tarjetaServicio.Obtener("");

        }

        public override void EjecutarBtnEliminar()
        {
            MessageBox.Show("Eliminar Tarjeta no disponible.");
        }

        


    }
}
