using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.DTO;

namespace XCommerce.Servicios.Core.Articulo.BajaArticulo
{
    public interface IBajaArticuloServicio
    {
        long Insertar(BajaArticuloDTO dto);

        void Modificar(BajaArticuloDTO dto);

        //void Eliminar(long bajaArticuloId);

        IEnumerable<BajaArticuloDTO> Obtener(string cadenaBuscar , bool obtenerEliminados = false);

        BajaArticuloDTO ObtenerBajaMotivoPorId(long BajaArticuloId);

        //void DescontarStock(long articuloId, decimal cantidad);

        //BajaArticuloDTO ObtenerPorCodigo(string codigoBuscar, string codigoBarraBuscar);

    }
}
