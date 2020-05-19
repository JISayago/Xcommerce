namespace Presentacion.Login.Usuario
{
    using Presentacion.FormulariosBase;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario;
    using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario.DTO;

    public partial class FormularioUsuario : FormularioBase
    {
        private readonly IUsuarioServicio _usuarioServicio;
        private object entidad;
        public FormularioUsuario()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();

            btnNuevo.Image = Constatntes.Imagenes.ImagenBotonNuevo;
            btnBloquear.Image = Constatntes.Imagenes.ImagenBotonEliminar;
            btnDesbloquear.Image = Constatntes.Imagenes.ImagenBotonImprimir;
            btnActualizar.Image = Constatntes.Imagenes.ImagenBotonActualizar;
            btnSalir.Image = Constatntes.Imagenes.ImagenBotonSalir;

            cbxEstaBloqueado.Visible = false;

            entidad = null;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarDatos(string cadenaBuscar)

        {
            dgvGrilla.DataSource = _usuarioServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            for (int i = 0; i < dgvGrilla.ColumnCount; i++)
            {
                dgvGrilla.Columns[i].Visible = false;
            }


            dgvGrilla.Columns["ApyNom"].Visible = true;
            dgvGrilla.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrilla.Columns["ApyNom"].HeaderText = "Apellido y Nombre";


            dgvGrilla.Columns["Nombre"].Visible = true;
            dgvGrilla.Columns["Nombre"].Width = 190;
            dgvGrilla.Columns["Nombre"].HeaderText = "Nombre de Usuario";

            dgvGrilla.Columns["EstaBloqueadoStr"].Visible = true;
            dgvGrilla.Columns["EstaBloqueadoStr"].Width = 190;
            dgvGrilla.Columns["EstaBloqueadoStr"].HeaderText = "Esta Bloqueado";



        }

        private void FormularioUsuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                entidad = dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                entidad = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (entidad != null)
            {
                var usuarioSeleccionado = (UsuarioDTO)entidad;

                _usuarioServicio.Crear(usuarioSeleccionado.PersonaID, usuarioSeleccionado.ApellidoPersona, usuarioSeleccionado.NombrePersona);

                ActualizarDatos(string.Empty);
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (entidad != null && ((UsuarioDTO)entidad).Nombre != "No Asignado..")
            {
                var usuarioSeleccionado = (UsuarioDTO)entidad;

                _usuarioServicio.CambiarEstado(usuarioSeleccionado.Nombre, true);
                ActualizarDatos(string.Empty);
                MessageBox.Show($"El usuario {usuarioSeleccionado.Nombre} fue Bloqueado Correctamente");
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {

            if (entidad != null && ((UsuarioDTO)entidad).Nombre != "No Asignado..")
            {
                var usuarioSeleccionado = (UsuarioDTO)entidad;

                _usuarioServicio.CambiarEstado(usuarioSeleccionado.Nombre, false);

                ActualizarDatos(string.Empty);

                MessageBox.Show($"El usuario {usuarioSeleccionado.Nombre} fue Desbloqueado Correctamente");
            }
        }
    }
}
