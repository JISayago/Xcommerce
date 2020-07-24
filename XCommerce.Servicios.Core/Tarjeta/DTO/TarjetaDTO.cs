using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Tarjeta.DTO
{
    public class TarjetaDTO
    {
        public long Id { get; set; }

        public bool EstaEliminado { get; set; }
        public string Descripcion { get; set; }
    }
}
