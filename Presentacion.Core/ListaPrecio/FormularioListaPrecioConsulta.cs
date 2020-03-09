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
using XCommerce.Servicios.Core.ListaPrecio;
using XCommerce.Servicios.Core.ListaPrecio.DTO;

namespace Presentacion.Core.ListaPrecio
{
    public partial class FormularioListaPrecioConsulta : FormularioBaseConsulta
    {
        private IListaPrecioServicio _listaPrecioServicio;
        public FormularioListaPrecioConsulta() : this(new ListaPrecioServicio())
        {
            InitializeComponent();
        }

        public FormularioListaPrecioConsulta(IListaPrecioServicio listaPrecioServicio)
        {
            _listaPrecioServicio = listaPrecioServicio;
        }

        public override void ResetearGrilla(DataGridView grilla)
     {
            base.ResetearGrilla(grilla);
            grilla.Columns["Descripcion"].Visible = true;
            grilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Descripcion"].HeaderText = "Descripcion";
            grilla.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grilla.Columns["Rentabilidad"].Visible = true;
            grilla.Columns["Rentabilidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["Rentabilidad"].HeaderText = "Rentabilidad";
            grilla.Columns["Rentabilidad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {
            base.ActualizarDatos(grilla, cadenaBuscar, check, BarraLateralBotones);

            bool obtenerEliminados = false;

            if (check.Checked)
            {
                obtenerEliminados = true;
            }

            grilla.DataSource = _listaPrecioServicio.Obtener(cadenaBuscar, obtenerEliminados);
            toolStrip.Enabled = true;
        }


        public override void EjecutarBtnNuevo()
        {
            var fListaPrecio = new FormularioListaPrecioABM(TipoOperacion.Nuevo);
            fListaPrecio.ShowDialog();
            ActualizarSegunOperacion(fListaPrecio.RealizoAlgunaOperacion);
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var fListaPrecioABM = new FormularioListaPrecioABM(TipoOperacion.Modificar, entidadId);
                fListaPrecioABM.ShowDialog();
                ActualizarSegunOperacion(fListaPrecioABM.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var fListaPrecioABM = new FormularioListaPrecioABM(TipoOperacion.Eliminar, entidadId);
                fListaPrecioABM.ShowDialog();
                ActualizarSegunOperacion(fListaPrecioABM.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty,cbxEstaEliminado,BarraLateralBotones);
            }
        }

    }
}
