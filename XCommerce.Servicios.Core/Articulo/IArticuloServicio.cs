using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Articulo.DTO;

namespace XCommerce.Servicios.Core.Articulo
{
    public interface IArticuloServicio
    {
        long Insertar(ArticuloDTO dto);

        void Modificar(ArticuloDTO dto);

        void Eliminar(long empleadoId);

        IEnumerable<ArticuloDTO> Obtener(string cadenaBuscar, bool obtenerEliminados = false);

        ArticuloDTO ObtenerPorId(long entidadId);

        void DescontarStock(long articuloId, decimal cantidad);

        ArticuloDTO ObtenerPorCodigo(string codigoBuscar, string codigoBarraBuscar);

        ArticuloDTO ObtenerPorCodigoModificar(string CodigoBuscar, string CodigoBarraBuscar, long EntidadId);
    }
}
