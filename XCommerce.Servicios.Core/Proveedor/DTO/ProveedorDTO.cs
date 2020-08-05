using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Proveedor.DTO
{
    public class ProveedorDTO
    {
        public long Id { get; set; }
        public string RazonSocial { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public long CondicionIvaId { get; set; }
    }
}
