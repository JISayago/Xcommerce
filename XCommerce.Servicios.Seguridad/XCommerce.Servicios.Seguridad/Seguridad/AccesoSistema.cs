

namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Seguridad
{
    using global::XCommerce.AccesoDatos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccesoSistema : IAccesoSistema
    {
        

        public bool VerificarExisteUsuario(string nombreUsuario, string contraseñaUsuario)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                return basedatos.Usuarios
                    .Any(x => x.Nombre == nombreUsuario
                    && x.Password == contraseñaUsuario);
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
    }
}
