using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO;

namespace XCommerce.Servicios.Core.Tarjeta.PlanTarjeta
{
    public interface IPlanTarjetaServicio
    {
        IEnumerable<PlanTarjetaDTO> Obtener(string cadenaBuscar);
        IEnumerable<PlanTarjetaDTO> ObtenerPorIdTarjeta(long tarjetaId);
        PlanTarjetaDTO ObtenerPorId(long id);
        void Agregar(PlanTarjetaDTO plan);
        void Modificar(PlanTarjetaDTO plan);
    }
}
