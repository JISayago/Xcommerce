using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Articulo.Marca.DTO;

namespace XCommerce.Servicios.Core.Articulo.Marca
{
    public interface IMarcaServicio
    {
        IEnumerable<MarcaDTO> ObtenerMarca(string cadenaBuscar);

        IEnumerable<MarcaDTO> ObtenerMarcaEliminada(string cadenaBuscar);

        MarcaDTO ObtenerPorId(long marca);

        long Insertar(MarcaDTO marcaDTO);

        void Modificar(MarcaDTO marcaDTO);

        void Eliminar(long marcaId);
    }
}
