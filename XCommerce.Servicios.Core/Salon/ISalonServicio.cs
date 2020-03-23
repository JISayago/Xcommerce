using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Salon.DTO;

namespace XCommerce.Servicios.Core.Salon
{
    public interface ISalonServicio
    {
        IEnumerable<SalonDTO> ObtenerSalon(string cadenaBuscar);

        IEnumerable<SalonDTO> ObtenerSalonEliminado(string cadenaBuscar);

        SalonDTO ObtenerPorId(long salonId);

        long Insertar(SalonDTO salonDTO);

        void Modificar(SalonDTO salonDTO);

        void Eliminar(long salonId);
    }
}
