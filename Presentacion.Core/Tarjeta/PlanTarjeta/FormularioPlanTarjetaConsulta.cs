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
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta;

namespace Presentacion.Core.Tarjeta.PlanTarjeta
{
    public partial class FormularioPlanTarjetaConsulta : FormularioBaseConsulta
    {
        private readonly IPlanTarjetaServicio _planTarjetaServicio;

        public FormularioPlanTarjetaConsulta()
            : this(new PlanTarjetaServicio())
        {
            InitializeComponent();
            dgvGrilla.DataSource = _planTarjetaServicio.Obtener("");

            ResetearGrilla(dgvGrilla);
        }

        public FormularioPlanTarjetaConsulta(IPlanTarjetaServicio PlanTarjetaServicio)
        {
            _planTarjetaServicio = PlanTarjetaServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = @"Descripcion";
            grilla.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["TarjetaNombre"].Visible = true;
            grilla.Columns["TarjetaNombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["TarjetaNombre"].HeaderText = @"Tarjeta";
            grilla.Columns["TarjetaNombre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Alicuota"].Visible = true;
            grilla.Columns["Alicuota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Alicuota"].HeaderText = @"Alicuota";
            grilla.Columns["Alicuota"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }



        public override void EjecutarBtnNuevo()
        {
            var fPlanTarjetaAbm = new FormularioPlanTarjetaABM(TipoOperacion.Nuevo);
            fPlanTarjetaAbm.ShowDialog();
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();

           
            var fPlanTarjetaAbm = new FormularioPlanTarjetaABM(TipoOperacion.Modificar, entidadId);
            fPlanTarjetaAbm.ShowDialog();

        }

        public override void EjecutarBtnEliminar()
        {
         
            var fPlanTarjetaAbm = new FormularioPlanTarjetaABM(TipoOperacion.Eliminar, entidadId);

            fPlanTarjetaAbm.ShowDialog();

            
        }
    }
}
