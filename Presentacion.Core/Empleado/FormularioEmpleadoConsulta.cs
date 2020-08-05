namespace Presentacion.Core.Empleado
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
    using XCommerce.Servicios.Core.Empleado;

    public partial class FormularioEmpleadoConsulta : FormularioBaseConsulta
    {
        private readonly IEmpleadoServicio _empleadoServicio;
        public long? empleadoSeleccionado = null;
        public bool soloSeleccion;
        public FormularioEmpleadoConsulta():this(new EmpleadoServicio())
        {
            InitializeComponent();
            soloSeleccion = false;
        }

        public FormularioEmpleadoConsulta(IEmpleadoServicio empleadoServicio)
        {
            _empleadoServicio = empleadoServicio;
            soloSeleccion = false;
        }

        public FormularioEmpleadoConsulta(bool soloSeleccion) 
        {
            InitializeComponent();
            this.soloSeleccion = soloSeleccion;
            if(soloSeleccion) MessageBox.Show("Seleccione el empleado con doble clock");
            _empleadoServicio = new EmpleadoServicio();
        }
        


        public override void ResetearGrilla(DataGridView grilla)
        {
            base.ResetearGrilla(grilla);


            grilla.Columns["Legajo"].Visible = true;
            grilla.Columns["Legajo"].Width = 80;

            grilla.Columns["ApyNom"].Visible = true;
            grilla.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            
           
            grilla.Columns["DNI"].Visible = true;
            grilla.Columns["DNI"].Width = 100;

            grilla.Columns["Email"].Visible = true;
            grilla.Columns["Email"].Width = 130;

            grilla.Columns["Celular"].Visible = true;
            grilla.Columns["Celular"].Width = 100;

        }

        public override void ActualizarDatos(DataGridView grilla, string cadenaBuscar,CheckBox check,ToolStrip toolStrip)
        {
            base.ActualizarDatos(grilla, cadenaBuscar,check, BarraLateralBotones);

            if (check.Checked)
            {
                grilla.DataSource = _empleadoServicio.ObtenerEmpleadoEliminado(cadenaBuscar);
                toolStrip.Enabled = false;
                
            }
            else
            {
                grilla.DataSource = _empleadoServicio.ObtenerEmpleado(cadenaBuscar);
                toolStrip.Enabled = true;
            }
        }

        public override void EjecutarDobleClickFila()
        {
            if (soloSeleccion)
            {
                Console.WriteLine("In ClienteCons");
                empleadoSeleccionado = (long)entidadId;
                Close();
            }
        }

        public override void EjecutarBtnEliminar()
        {
            base.EjecutarBtnEliminar();
            if (puedeEjecutarComando)
            {
                var FormularioABMEmpleado = new FormularioEmpleadoABM(TipoOperacion.Eliminar, entidadId);
                FormularioABMEmpleado.ShowDialog();
                ActualizarSegunOperacion(FormularioABMEmpleado.RealizoAlgunaOperacion);
            }
        }

        private void ActualizarSegunOperacion(bool realizoOperacion)
        {
            if (realizoOperacion)
            {
                ActualizarDatos(dgvGrilla, string.Empty,cbxEstaEliminado,BarraLateralBotones);
            }
        }

        public override void EjecutarBtnModificar()
        {
            base.EjecutarBtnModificar();
            if (puedeEjecutarComando)
            {
                var FormularioABMEmpleado = new FormularioEmpleadoABM(TipoOperacion.Modificar, entidadId);
                FormularioABMEmpleado.ShowDialog();
                ActualizarSegunOperacion(FormularioABMEmpleado.RealizoAlgunaOperacion);
            }
        }

        public override void EjecutarBtnNuevo()
        {
            var FormularioABMEmpleado = new FormularioEmpleadoABM(TipoOperacion.Nuevo);
            FormularioABMEmpleado.ShowDialog();
            ActualizarSegunOperacion(FormularioABMEmpleado.RealizoAlgunaOperacion);
        }

     
    }
}
