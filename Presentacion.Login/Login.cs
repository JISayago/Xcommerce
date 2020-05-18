

namespace Presentacion.Login
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
    using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Seguridad;
    using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario;

    public partial class Login : Form
    {
        private readonly IAccesoSistema _accesoSistema;
        private readonly IUsuarioServicio _usuarioServicio;

        private int CantidadFallos;

        public bool PuedeAccederSistema { get; protected set; }


        public String NombreUsuario { get; private set; }
        public long IdUsuario { get; private set; }

      
        public Login():this(new AccesoSistema(), new UsuarioServicio())
        {
            InitializeComponent();

           
         
        }
        public Login(IAccesoSistema accesoSistema, IUsuarioServicio usuarioServicio)
        {
            _accesoSistema = accesoSistema;
            _usuarioServicio = usuarioServicio;
            CantidadFallos = 0;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresoAlSistema();
        }
           

        private bool VerficarDatosObligatorios()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El nombre de Usuario es Obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("La Contraseña es Obligatoria.");
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void IngresoAlSistema()
        {
            if (VerficarDatosObligatorios())
            {
                if (_accesoSistema.VerificarExisteUsuario(txtUsuario.Text, txtContraseña.Text))
                {
                    if (!_accesoSistema.VerificarSiEstaBloqueado(txtUsuario.Text))
                    {
                        NombreUsuario = txtUsuario.Text;
                        IdUsuario = _accesoSistema.ObtenerId(NombreUsuario);
                        if (NombreUsuario.ToLower() == "admin") IdUsuario = 0;

                        PuedeAccederSistema = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El usuario " + txtUsuario.Text + " se encuentra bloqueado. Comunicarse con la Administración.");
                        CantidadFallos = 0;
                        PuedeAccederSistema = false;
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos.");
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                    CantidadFallos++;
                    PuedeAccederSistema = false;
                    if (CantidadFallos >= 3)
                    {
                        try
                        {
                            _usuarioServicio.CambiarEstado(txtUsuario.Text, true);

                            MessageBox.Show("¡" + txtUsuario.Text + ", su usuario fue Bloqueado!.");
                            Application.Exit();
                        }
                        catch (Exception exception)
                        {

                            MessageBox.Show(exception.Message);
                            txtContraseña.Clear();
                            txtContraseña.Focus();
                        }
                    }

                    return;

                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IngresoAlSistema();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IngresoAlSistema();
        }
    }
}
