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
using XCommerce.Servicios.Core.Articulo.BajaArticulo;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja;

namespace Presentacion.Core.Articulo.BajaArticulo
{
    public partial class FormularioBajaArticuloConsulta : FormularioBaseConsulta
    {
        private readonly IBajaArticuloServicio _bajaArticuloServicio;

        public FormularioBajaArticuloConsulta() : this(new BajaArticuloServicio())
        {
            InitializeComponent();

        }

        public FormularioBajaArticuloConsulta(IBajaArticuloServicio bajaArticuloServicio)
        {
            _bajaArticuloServicio = bajaArticuloServicio;
        }

        /*public FormularioBajaArticuloConsulta()
        {
            InitializeComponent();
            BarraLateralBotones.Visible = false;
        }

        public FormularioBajaArticuloConsulta(IMotivoBajaServicio motivoBajaServicio, IBajaArticuloServicio bajaArticuloServicio)
        {
            _motivoBajaServicio = motivoBajaServicio;

            _bajaArticuloServicio = bajaArticuloServicio;
        }*/

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            /*grilla.Columns["Descripcion"].Visible = true;

            grilla.Columns["ProvinciaDescrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["Descripcion"].HeaderText = "Localidad";


            grilla.Columns["ProvinciaDescrip"].Visible = true;

            grilla.Columns["Descripcion"].Width = 250;

            grilla.Columns["ProvinciaDescrip"].HeaderText = "Provincia";
            */

            grilla.Columns["Fecha"].Visible = true;
            grilla.Columns["Fecha"].Width = 100;
            grilla.Columns["Fecha"].HeaderText = "Fecha";

            grilla.Columns["ArticuloDescrip"].Visible = true;
            grilla.Columns["ArticuloDescrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["ArticuloDescrip"].HeaderText = "Articulo";

            grilla.Columns["Observacion"].Visible = true;
            grilla.Columns["Observacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Observacion"].HeaderText = "Observacion";

            grilla.Columns["MotivoDescrip"].Visible = true;
            grilla.Columns["MotivoDescrip"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["MotivoDescrip"].HeaderText = "Motivo";

            grilla.Columns["Cantidad"].Visible = true;
            grilla.Columns["Cantidad"].Width = 60;
            grilla.Columns["Cantidad"].HeaderText = "Cantidad";

        }



        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            if (check.Checked)
            {
                grilla.DataSource = _bajaArticuloServicio.Obtener(cadenaBuscar);

            }
            else
            {
                grilla.DataSource = _bajaArticuloServicio.Obtener(cadenaBuscar);
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
                var fBajaArticuloABM = new FormularioBajaArticuloABM(TipoOperacion.Modificar, entidadId);
                fBajaArticuloABM.ShowDialog();
                ActualizarSegunOperacion(fBajaArticuloABM.RealizoAlgunaOperacion);
            }
        }
    }
}
