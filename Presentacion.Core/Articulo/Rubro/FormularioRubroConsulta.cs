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
using XCommerce.Servicios.Core.Articulo.Rubro;

namespace Presentacion.Core.Articulo.Rubro
{
    public partial class FormularioRubroConsulta : FormularioBaseConsulta
    {
        private readonly IRubroServicio _rubroServicio;

        public FormularioRubroConsulta() : this(new RubroServicio())
        {
            InitializeComponent();
        }

        public FormularioRubroConsulta(IRubroServicio rubroServicio)
        {
            _rubroServicio = rubroServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Rubro";

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _rubroServicio.ObtenerRubroEliminada(cadenaBuscar);
                toolStrip.Enabled = false;
            }
            else
            {
                grilla.DataSource = _rubroServicio.ObtenerRubro(cadenaBuscar);
                toolStrip.Enabled = true;
            }
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMRubro = new FormularioRubroABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMRubro.ShowDialog();
                ActualizarSegunOperacion(FormularioABMRubro.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
            }
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var FormularioABMRubro = new FormularioRubroABM(TipoOperacion.Modificar, entidadId);
                FormularioABMRubro.ShowDialog();
                ActualizarSegunOperacion(FormularioABMRubro.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMRubro = new FormularioRubroABM(TipoOperacion.Nuevo);
            FormularioABMRubro.ShowDialog();
            ActualizarSegunOperacion(FormularioABMRubro.RealizoAlgunaOperacion);
        }
    }
}
