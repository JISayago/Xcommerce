

namespace VentanaPrincipal
{
    using Presentacion.Helpers;
    using Presentacion.Login;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            var login = new Login();
            login.ShowDialog();

            if (login.PuedeAccederSistema)
            {
                DatosSistema.NombreUsuario =  login.NombreUsuario;
                DatosSistema.UsuarioId = login.IdUsuario;
                Application.Run(new VentanaPrincipal());
                
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
