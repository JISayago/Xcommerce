using Presentacion.Core.Articulo.BajaArticulo;
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
using XCommerce.Servicios.Core.Articulo;

namespace Presentacion.Core.Articulo
{
    public partial class FormularioArticuloConsulta : FormularioBaseConsulta
    {
        private IArticuloServicio _articuloServicio;
        public FormularioArticuloConsulta() : this(new ArticuloServicio())
        {
            InitializeComponent();
        }
        public FormularioArticuloConsulta(IArticuloServicio articuloServicio)
        {
            _articuloServicio = articuloServicio;
            ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
        }

        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);

            grilla.Columns["Codigo"].Visible = true;
            grilla.Columns["Codigo"].Width = 75;

            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grilla.Columns["CodigoBarra"].Visible = true;
            grilla.Columns["CodigoBarra"].HeaderText = @"Codigo de Barra";
            grilla.Columns["CodigoBarra"].Width = 100;

            /*grilla.Columns["Precio"].Visible = true;
            grilla.Columns["Precio"].HeaderText = @"Precio Unitario";
            grilla.Columns["Precio"].Width = 75;

            grilla.Columns["PrecioCosto"].Visible = true;
            grilla.Columns["PrecioCosto"].HeaderText = @"Precio Costo";
            grilla.Columns["PrecioCosto"].Width = 75;*/

            grilla.Columns["Stock"].Visible = true;
            grilla.Columns["Stock"].Width = 75;

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {
            base.ActualizarDatos(grilla, cadenaBuscar, check, BarraLateralBotones);

            bool obtenerEliminados = false;

            if (check.Checked)
            {
                obtenerEliminados = true;
            }
            
            grilla.DataSource = _articuloServicio.Obtener(cadenaBuscar, obtenerEliminados);
            toolStrip.Enabled = true;
        }

        public override void EjecutarBtnEliminar()
        {
            var eliminarDarBAja = new FormularioEliminarDarBaja();
            eliminarDarBAja.ShowDialog();

           /* DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have clicked Ok Button");
                //Some task…  
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
                //Some task…  
            }
            
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var fArticuloABM = new FormularioArticuloABM(TipoOperacion.Eliminar, entidadId);
                fArticuloABM.ShowDialog();
                ActualizarSegunOperacion(fArticuloABM.RealizoAlgunaOperacion);
            }*/

            
            var FormularioBajaArticulo = new FormularioBajaArticuloABM(TipoOperacion.Nuevo, entidadId);
            FormularioBajaArticulo.Show();
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
                var fArticuloABM = new FormularioArticuloABM(TipoOperacion.Modificar, entidadId);
                fArticuloABM.ShowDialog();
                ActualizarSegunOperacion(fArticuloABM.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var fArticuloABM = new FormularioArticuloABM(TipoOperacion.Nuevo);
            fArticuloABM.ShowDialog();
            ActualizarSegunOperacion(fArticuloABM.RealizoAlgunaOperacion);
        }

    }
}