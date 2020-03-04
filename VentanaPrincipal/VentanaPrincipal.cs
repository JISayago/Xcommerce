

namespace VentanaPrincipal
{
    using Presentacion.Core.Empleado;
    using Presentacion.Core.Provincia;
    using Presentacion.Core.Provincia.Localidad;
    using Presentacion.Login.Usuario;
    using System;
    using System.Windows.Forms;

    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

           

        private void consultaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var FormularioConsultaProvincia = new FormularioProvinciaConsulta();
            FormularioConsultaProvincia.Show();
        }

      
     
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaEmpleado = new FormularioEmpleadoConsulta();
            FormularioConsultaEmpleado.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioUsuarios = new FormularioUsuario();
            FormularioUsuarios.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaLocalidad = new FormularioLocalidadConsulta();
            FormularioConsultaLocalidad.Show();
        }
    }
}
