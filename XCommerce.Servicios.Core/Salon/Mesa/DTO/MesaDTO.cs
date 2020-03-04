using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Salon.Mesa.DTO
{
    public class MesaDTO
    {
        public long Id { get; set; }

        public int Numero { get; set; }

        public string Descripcion { get; set; }

        public bool EstaEliminado { get; set; }

        public long SalonId { get; set; }

        public EstadoMesa estadoMesa { get; set; }
        
    }
}
