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
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.Salon.Mesa
{
    public partial class FormularioMesaConsulta : FormularioBaseConsulta
    {
        private readonly IMesaServicio _mesaServicio;

        private readonly ISalonServicio _salonServicio;

        public FormularioMesaConsulta() : this(new MesaServicio(), new SalonServicio())
        {
            InitializeComponent();
        }

        public FormularioMesaConsulta(IMesaServicio mesaServicio, ISalonServicio salonServicio)
        {
            _mesaServicio = mesaServicio;

            _salonServicio = salonServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;

            grilla.Columns["SalonDescripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["Descripcion"].HeaderText = "Descripcion";


            grilla.Columns["Numero"].Visible = true;

            grilla.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["Numero"].HeaderText = "Mesa";


            grilla.Columns["estadoMesa"].Visible = true;

            grilla.Columns["estadoMesa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["estadoMesa"].HeaderText = "Estado";


            grilla.Columns["SalonDescripcion"].Visible = true;

            grilla.Columns["Descripcion"].Width = 250;

            grilla.Columns["SalonDescripcion"].HeaderText = "Salon";

        }



        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _mesaServicio.ObtenerMesaEliminada(cadenaBuscar);
                toolStrip.Enabled = false;
            }
            else
            {
                grilla.DataSource = _mesaServicio.ObtenerMesa(cadenaBuscar);
            }
        }
        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();

            if (puedeEjecutarComando)

            {
                var FormularioABMMesa = new FormularioMesaABM(TipoOperacion.Eliminar, entidadId);

                FormularioABMMesa.ShowDialog();

                ActualizarSegunOperacion(FormularioABMMesa.RealizoAlgunaOperacion);
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
                var FormularioABMMesa = new FormularioMesaABM(TipoOperacion.Modificar, entidadId);

                FormularioABMMesa.ShowDialog();

                ActualizarSegunOperacion(FormularioABMMesa.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMMesa = new FormularioMesaABM(TipoOperacion.Nuevo);

            FormularioABMMesa.ShowDialog();

            ActualizarSegunOperacion(FormularioABMMesa.RealizoAlgunaOperacion);
        }

    }
}




        
      