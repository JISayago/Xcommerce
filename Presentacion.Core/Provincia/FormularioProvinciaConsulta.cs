namespace Presentacion.Core.Provincia
{
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
    using XCommerce.Servicios.Core.Provincia;

    public partial class FormularioProvinciaConsulta : FormularioBaseConsulta
    {
        private readonly IProvinciaServicio _provinciaServicio;

        public FormularioProvinciaConsulta() : this(new ProvinciaServicio())
        {
            InitializeComponent();
        }

        public FormularioProvinciaConsulta(IProvinciaServicio provinciaServicio)
        {
            _provinciaServicio = provinciaServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Provincia";

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check,ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check,toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _provinciaServicio.ObtenerProvinciaEliminada(cadenaBuscar);
                toolStrip.Enabled = false;
            }
            else
            {
                grilla.DataSource = _provinciaServicio.ObtenerProvincia(cadenaBuscar);
                toolStrip.Enabled = true;
            }

            

           
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMProvincia.ShowDialog();
                ActualizarSegunOperacion(FormularioABMProvincia.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty,cbxEstaEliminado,BarraLateralBotones);
            }
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Modificar, entidadId);
                FormularioABMProvincia.ShowDialog();
                ActualizarSegunOperacion(FormularioABMProvincia.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMProvincia = new FormularioProvinciaABM(TipoOperacion.Nuevo);
            FormularioABMProvincia.ShowDialog();
            ActualizarSegunOperacion(FormularioABMProvincia.RealizoAlgunaOperacion);
        }

    }
}

