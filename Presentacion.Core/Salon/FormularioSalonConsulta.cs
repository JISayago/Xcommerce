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
using XCommerce.Servicios.Core.Salon;

namespace Presentacion.Core.Salon
{
    public partial class FormularioSalonConsulta : FormularioBaseConsulta
    {
        private readonly ISalonServicio _salonServicio;

        public FormularioSalonConsulta() : this(new SalonServicio())
        {
            InitializeComponent();
        }

        public FormularioSalonConsulta(ISalonServicio salonServicio)
        {
            _salonServicio = salonServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Salon";

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _salonServicio.ObtenerSalonEliminado(cadenaBuscar);
                toolStrip.Enabled = false;
            }
            else
            {
                grilla.DataSource = _salonServicio.ObtenerSalon(cadenaBuscar);
                toolStrip.Enabled = true;
            }




        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMSalon.ShowDialog();
                ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
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
                var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Modificar, entidadId);
                FormularioABMSalon.ShowDialog();
                ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMSalon = new FormularioSalonABM(TipoOperacion.Nuevo);
            FormularioABMSalon.ShowDialog();
            ActualizarSegunOperacion(FormularioABMSalon.RealizoAlgunaOperacion);
        }

    }
}

