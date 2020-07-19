namespace Presentacion.FormulariosBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FormularioBaseConsulta : FormularioBase
    {
        protected long? entidadId;
        protected bool puedeEjecutarComando;

        public FormularioBaseConsulta()
        {
            InitializeComponent();

            btnImprimir.Visible = false;
            btnNuevo.Image = Constantes.Imagenes.ImagenBotonNuevo;
            btnModificar.Image = Constantes.Imagenes.ImagenBotonModificar;
            btnEliminar.Image = Constantes.Imagenes.ImagenBotonEliminar;
            btnImprimir.Image = Constantes.Imagenes.ImagenBotonImprimir;
            btnActualizar.Image = Constantes.Imagenes.ImagenBotonActualizar;
            btnSalir.Image = Constantes.Imagenes.ImagenBotonSalir;           


            entidadId = null;
            puedeEjecutarComando = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EjecutarBtnNuevo();
        }

        public virtual void EjecutarBtnNuevo()
        {
         
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EjecutarBtnEliminar();
        }

        private bool HayDatosCargados()
        {
            return dgvGrilla.RowCount > 0;
        }

        public virtual void EjecutarDobleClickFila()
        {

        }

        public virtual void EjecutarBtnEliminar()
        {
            if (HayDatosCargados())
            {
                if (!entidadId.HasValue)
                {
                    MessageBox.Show("Por favor seleccione un registro.");
                    puedeEjecutarComando = false;
                    return;
                }
                else
                {
                    puedeEjecutarComando = true;
                }
            }
            else
            {
                MessageBox.Show("No hay Datos Cargados.");
            }
        }

        public virtual void BtnModificar_Click(object sender, EventArgs e)
        {
            EjecutarBtnModificar();
        }

        public virtual void EjecutarBtnModificar()
        {
            if (HayDatosCargados())
            {
                if (!entidadId.HasValue)
                {
                    MessageBox.Show("Por favor seleccione un registro.");
                    puedeEjecutarComando = false;
                    return;
                }
                else
                {
                    puedeEjecutarComando = true;
                }
            }
            else
            {
                MessageBox.Show("No hay Datos Cargados.");
            }
        }

        public virtual void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
        }

        public virtual void BtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(dgvGrilla, txtBuscar.Text, cbxEstaEliminado, BarraLateralBotones);
        }

        public virtual void ActualizarDatos(DataGridView grilla, string cadenaBuscar, CheckBox check, ToolStrip toolStrip)
        {
            if (check.Checked)
            {
                btnEliminar.Enabled = false;

                btnNuevo.Enabled = false;

                btnModificar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;

                btnNuevo.Enabled = true;

                btnModificar.Enabled = true;
            }

        }

        private void DgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter(e);
        }

        public virtual void RowEnter(DataGridViewCellEventArgs e)
        {
            if (HayDatosCargados())
            {
                entidadId = (long?)dgvGrilla["Id", e.RowIndex].Value;
            }
            else
            {
                entidadId = null;
            }
        }

        private void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            EjecutarBtnEliminarLoad();
            ResetearGrilla(dgvGrilla);
        }

        public virtual void EjecutarBtnEliminarLoad()
        {
            ActualizarDatos(dgvGrilla, string.Empty, cbxEstaEliminado, BarraLateralBotones);
        }

        public virtual void ResetearGrilla(DataGridView grilla)
        {
            for(int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }
        }

        private void FormularioBaseConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void DgvGrilla_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EjecutarDobleClickFila();
        }
    }
}
