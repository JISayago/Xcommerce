namespace Presentacion.Core.Banco
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
    using XCommerce.Servicio.Core.Banco;

    public partial class FormularioBancoConsulta : FormularioBaseConsulta
    {
        private readonly IBancoServicio _bancoServicio;

        public FormularioBancoConsulta() : this(new BancoServicio())
        {
            InitializeComponent();
        }

        public FormularioBancoConsulta(IBancoServicio bancoServicio)
        {
            _bancoServicio = bancoServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Banco";

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {

            base.ActualizarDatos(grilla, cadenaBuscar, check, toolStrip);

            grilla.DataSource = _bancoServicio.Obtener(cadenaBuscar);

        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMBanco = new FormularioBancoABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMBanco.ShowDialog();
                ActualizarSegunOperacion(FormularioABMBanco.RealizoAlgunaOperacion);
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
                var FormularioABMBanco = new FormularioBancoABM(TipoOperacion.Modificar, entidadId);
                FormularioABMBanco.ShowDialog();
                ActualizarSegunOperacion(FormularioABMBanco.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMBanco = new FormularioBancoABM(TipoOperacion.Nuevo);
            FormularioABMBanco.ShowDialog();
            ActualizarSegunOperacion(FormularioABMBanco.RealizoAlgunaOperacion);
        }

    }
}

