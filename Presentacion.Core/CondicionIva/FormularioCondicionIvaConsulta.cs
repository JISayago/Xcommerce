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
using XCommerce.Servicios.Core.CondicionIva;

namespace Presentacion.Core.CondicionIva
{
    public partial class FormularioCondicionIvaConsulta : FormularioBaseConsulta
    {
        private readonly ICondicionIvaServicio _condicionIvaServicio;

        public FormularioCondicionIvaConsulta() : this(new CondicionIvaServicio())
        {
            
        }

        public FormularioCondicionIvaConsulta(ICondicionIvaServicio condicionIvaServicio)
        {
            _condicionIvaServicio = condicionIvaServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Condición Iva";

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            
                
            
                grilla.DataSource = _condicionIvaServicio.ObtenerCondicionIva(cadenaBuscar);
                toolStrip.Enabled = true;
            
        }
        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMCondicionIva = new FormularioCondicionIvaABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMCondicionIva.ShowDialog();
                ActualizarSegunOperacion(FormularioABMCondicionIva.RealizoAlgunaOperacion);
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
                var FormularioABMCondicionIva = new FormularioCondicionIvaABM(TipoOperacion.Modificar, entidadId);
                FormularioABMCondicionIva.ShowDialog();
                ActualizarSegunOperacion(FormularioABMCondicionIva.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMCondicionIva = new FormularioCondicionIvaABM(TipoOperacion.Nuevo);
            FormularioABMCondicionIva.ShowDialog();
            ActualizarSegunOperacion(FormularioABMCondicionIva.RealizoAlgunaOperacion);
        }
    }
}
