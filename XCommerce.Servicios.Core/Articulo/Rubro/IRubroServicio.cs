using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Articulo.Rubro.DTO;

namespace XCommerce.Servicios.Core.Articulo.Rubro
{
    public interface IRubroServicio
    {
        IEnumerable<RubroDTO> ObtenerRubro(string cadenaBuscar);

        IEnumerable<RubroDTO> ObtenerRubroEliminada(string cadenaBuscar);

        RubroDTO ObtenerPorId(long rubro);

        long Insertar(RubroDTO rubroDTO);

        void Modificar(RubroDTO rubroDTO);

        void Eliminar(long marcaId);
    }
}
