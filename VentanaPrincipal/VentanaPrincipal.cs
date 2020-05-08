

namespace VentanaPrincipal
{
    using Presentacion.Core.Articulo;
    using Presentacion.Core.Articulo.Marca;
    using Presentacion.Core.Articulo.Rubro;
    using Presentacion.Core.Cliente;
    using Presentacion.Core.Empleado;
    using Presentacion.Core.Provincia;
    using Presentacion.Core.Provincia.Localidad;
    using Presentacion.Core.Salon;
    using Presentacion.Core.Salon.Mesa;
    using Presentacion.Core.VentaSalon;
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

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var FormularioConsultaSalon = new FormularioSalonConsulta();
            FormularioConsultaSalon.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var FormularioConsultaMesa = new FormularioMesaConsulta();
            FormularioConsultaMesa.Show();
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var FormularioConsultaArticulo = new FormularioArticuloConsulta();
            FormularioConsultaArticulo.Show();
        }

        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var FormularioventaSalon = new FormularioVentaSalon();
            FormularioventaSalon.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaMarca = new FormularioMarcaConsulta();
            FormularioConsultaMarca.Show();
        }

        private void rubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormularioConsultaRubro = new FormularioRubroConsulta();
            FormularioConsultaRubro.Show();
        }

        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var FormularioConsultaCliente = new FormularioClienteConsulta();
            FormularioConsultaCliente.Show();
        }
    }
}
