using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Reserva.DTO;

namespace XCommerce.Servicios.Core.Reserva
{
    public interface IReservaServicio
    {
        void GenerarReserva(ReservaDTO reservadto);

        ReservaDTO ObtenerReservaPorId(long reservaId);

        IEnumerable<ReservaDTO> ObtenerReservasPorMesaId (long mesaId);

        IEnumerable<ReservaDTO> ObtenerReservas(string cadenaBuscar);

        void Modificar(ReservaDTO reservadto);

        void Eliminar(long reservaId);
    }
}
