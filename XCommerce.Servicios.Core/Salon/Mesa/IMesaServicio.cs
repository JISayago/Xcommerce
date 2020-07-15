using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Salon.Mesa.DTO;

namespace XCommerce.Servicios.Core.Salon.Mesa
{
    public interface IMesaServicio
    {

        IEnumerable<MesaDTO> ObtenerMesa(string cadenaBuscar);

        IEnumerable<MesaDTO> ObtenerMesaEliminada(string cadenaBuscar);

        IEnumerable<MesaDTO> ObtenerMesaPorSalon(long salonId, string cadenaBuscar);

        bool ExisteNumeroMesa(int numeroMesa);

      

        MesaDTO ObtenerPorId(long mesaId);

        long Insertar(MesaDTO mesaDTO);
        string ObtenerSalon(long _mesaId);

        void Modificar(MesaDTO mesaDTO);

        void Eliminar(long mesaId);

    }
}
