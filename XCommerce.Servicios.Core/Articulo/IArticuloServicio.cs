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

        ArticuloDTO ObtenerPorId(long articuloId);

        void DescontarStock(long articuloId, decimal cantidad);

        ArticuloDTO ObtenerPorCodigo(string codigoBuscar);

        ArticuloDTO ObtenerPorCodigoModificar(string CodigoBuscar, string CodigoBarraBuscar, long EntidadId);

        ArticuloDTO ObtenerArticuloPorBaja(long bajaArticuloId);
    }
}
