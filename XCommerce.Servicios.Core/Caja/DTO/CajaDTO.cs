using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Caja.DTO
{
    public class CajaDTO
    {
        public long Id { get; set; }
        public decimal MontoApertura { get; set; }
        public DateTime FechaApertura { get; set; }
        public long UsuarioAperturaId { get; set; }

        public DateTime FechaCierre { get; set; }
        public decimal MontoCierre { get; set; }
        public decimal MontoSistema { get; set; }
        public decimal Diferencia => MontoSistema - MontoCierre;
        public long UsuarioCierreId { get; set; }

    }
}
