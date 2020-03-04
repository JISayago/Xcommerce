using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario.DTO;

namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario
{
    public interface IUsuarioServicio
    {
        void CambiarEstado(string NombreUsuario, bool Estado);

        IEnumerable<UsuarioDTO> Obtener(string cadenaBuscar);

        void Crear(long personaId, string apellido, string nombre);
    }
}
