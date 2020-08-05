using System.Collections.Generic;
using XCommerce.Servicios.Core.Tarjeta.DTO;

namespace XCommerce.Servicios.Core.Tarjeta
{
    public interface ITarjetaServicio
    {
        IEnumerable<TarjetaDTO> Obtener(string cadenaBuscar);
        TarjetaDTO ObtenerPorId(long? entidadId);
        void Agregar(TarjetaDTO tarjeta);
        void Modificar(TarjetaDTO tarjeta);
        void Eliminar(long? entidadId);
    }
}
