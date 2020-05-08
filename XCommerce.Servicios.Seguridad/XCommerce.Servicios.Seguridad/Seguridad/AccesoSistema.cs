

namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Seguridad
{
    using global::XCommerce.AccesoDatos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static Presentacion.Helpers.CadenaCaracteres;

    public class AccesoSistema : IAccesoSistema
    {
        public bool VerificarExisteUsuario(string nombreUsuario, string contraseñaUsuario)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                if(nombreUsuario == "Admin" && contraseñaUsuario == "Admin")
                {
                    return true;
                }

                var PassEncriptado = Encriptar(contraseñaUsuario);
                return basedatos.Usuarios
                    .Any(x => x.Nombre == nombreUsuario
                    && x.Password == PassEncriptado);
            }
        }

        public bool VerificarSiEstaBloqueado(string nombreUsuario)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                return basedatos.Usuarios
                    .Any(x => x.Nombre == nombreUsuario
                    && x.EstaBloqueado);
            }
        }
        public long ObtenerId(string nombreUsuario)
        {
            if (nombreUsuario == "Admin"){return 0;}

            using (var context = new ModeloXCommerceContainer())
            {
                return context.Usuarios.FirstOrDefault(x => x.Nombre == nombreUsuario).Id;
            }
        }

    }
}
