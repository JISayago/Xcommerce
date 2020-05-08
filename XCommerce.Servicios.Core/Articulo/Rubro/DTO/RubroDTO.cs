using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Articulo.Rubro.DTO
{
    public class RubroDTO
    {
        public long Id { get; set; }

        public string Descripcion { get; set; }

        public bool EstaEliminado { get; set; }
    }
}
