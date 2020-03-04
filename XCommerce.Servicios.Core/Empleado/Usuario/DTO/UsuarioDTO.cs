using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario.DTO
{
    public class UsuarioDTO
    {
        public long Id { get; set; }

        public long PersonaID { get; set; }

        public string ApellidoPersona { get; set; }

        public string NombrePersona { get; set; }

        public string ApyNom => $"{ApellidoPersona} {NombrePersona}";

        public string Nombre { get; set; }

        public bool EstaBloqueado { get; set; }

        public string EstaBloqueadoStr => EstaBloqueado ? "Si" : "No";

    }
}
