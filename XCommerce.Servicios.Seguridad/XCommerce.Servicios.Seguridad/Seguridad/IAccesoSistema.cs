

namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Seguridad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAccesoSistema
    {
        bool VerificarExisteUsuario(string nombreUsuario, string contraseñaUsuario);

        bool VerificarSiEstaBloqueado(string nombreUsuario);

    }
}
