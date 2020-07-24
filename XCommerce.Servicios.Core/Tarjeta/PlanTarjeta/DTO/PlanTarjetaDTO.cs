using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO
{
    public class PlanTarjetaDTO
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }

        public decimal Alicuota { get; set; }

        public string TarjetaNombre { get; set; }

        public long TarjetaId { get; set; }
    }
}
