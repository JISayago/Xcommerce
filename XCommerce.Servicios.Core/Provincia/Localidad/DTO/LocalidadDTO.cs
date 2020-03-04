using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Localidad.DTO
{
    public class LocalidadDTO
    {
        public long Id { get; set; }

        public long ProvinciaId { get; set; }

        public string Descripcion { get; set; }

        public bool EstaEliminado { get; set; }

        public string ProvinciaDescrip { get; set; }
    }
}
