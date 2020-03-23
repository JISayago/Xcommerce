using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.ListaPrecio.DTO;

namespace XCommerce.Servicios.Core.ListaPrecio
{
    public interface IListaPrecioServicio
    {
        IEnumerable<ListaPrecioDTO> Obtener(string cadenaBuscar, bool obtenerEliminadas = false);

        ListaPrecioDTO ObtenerPorId(long ListaPrecioId);

        long Insertar(ListaPrecioDTO ListaPrecioDTO);

        void Modificar(ListaPrecioDTO ListaPrecioDTO);

        void Eliminar(long ListaPrecioId);
    }
}
