using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Producto.DTO;

namespace XCommerce.Servicios.Core.Producto
{
    public interface IProductoServicio
    {
        ProductoMesaDTO ObtenerPorCodigoKiosco(string codigo);
        ProductoMesaDTO ObtenerPorCodigo(long mesaID, string codigo);
    }
}
