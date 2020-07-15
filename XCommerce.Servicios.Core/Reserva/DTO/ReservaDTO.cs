using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Reserva.DTO
{
    public class ReservaDTO
    {
        public long Id { get; set; }

        public DateTime FechaReserva { get; set; }

        public long MesaId { get; set; }       
        public int MesaNumero { get; set; }

        public long ClienteId { get; set; }
        public string ClienteApyNom { get; set; }

        public decimal Senia { get; set; }

        public string EstadoReserva { get; set; }

        public long UsuarioId { get; set; }
        public string Usuario{ get; set; }

        
    }
}
