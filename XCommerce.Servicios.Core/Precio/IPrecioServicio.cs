using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Precio.DTO;

namespace XCommerce.Servicios.Core.Precio
{
    public interface IPrecioServicio
    {
        void Insertar(PrecioDTO precioNuevo);
        IEnumerable<PrecioDTO> Obtener(string cadenaBuscar);
        PrecioDTO ObtenerPorId(long id);
        IEnumerable<PrecioDTO> ObtenerUltimaActualizacion(string cadenaBuscar);
        PrecioDTO ObtenerPorArticuloListaPrecio(long articuloId, long listaPrecioId);

    }
}
