using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Caja.DetalleCaja.DTO
{
    public class DetalleCajaDTO
    {
        public long Id { get; set;}
        public long cajaId { get; set; }
        public decimal monto { get; set; }
        public TipoPago tipoPago { get; set; }

        public AccesoDatos.Caja caja { get; set; }
    }
}
