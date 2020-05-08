using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.ListaPrecio.DTO;

namespace XCommerce.Servicios.Core.ListaPrecio
{
    public class ListaPrecioServicio : IListaPrecioServicio
    {
        public void Eliminar(long listaPrecioId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var listaPrecioEliminar = context.ListaPrecios.FirstOrDefault(x => x.Id == listaPrecioId);

                if (listaPrecioEliminar == null) throw new Exception("Ocurrió un error al obtener la lista de precios para eliminarla");

                listaPrecioEliminar.EstaEliminado = true;

                context.SaveChanges();
            }
        }

        public long Insertar(ListaPrecioDTO listaPrecioDTO)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var listaPrecioNueva = new AccesoDatos.ListaPrecio
                {
                    Descripcion = listaPrecioDTO.Descripcion,
                    Rentabilidad = listaPrecioDTO.Rentabilidad,
                    EstaEliminado = listaPrecioDTO.EstaEliminado,
                };

                context.ListaPrecios.Add(listaPrecioNueva);

                context.SaveChanges();

                return listaPrecioNueva.Id;

            }
        }

        public void Modificar(ListaPrecioDTO listaPrecioDTO)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var listaPrecioModificar = context.ListaPrecios.FirstOrDefault(x => x.Id == listaPrecioDTO.Id);

                if (listaPrecioModificar == null) throw new Exception("Ocurrió un error al obtener la lista de precios para modificarla");

                listaPrecioModificar.Descripcion = listaPrecioDTO.Descripcion;
                listaPrecioModificar.Rentabilidad = listaPrecioDTO.Rentabilidad;

                context.SaveChanges();
            }
        }

        public ListaPrecioDTO ObtenerPorId(long listaPrecioId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.ListaPrecios
                    .AsNoTracking()
                    .Select(x => new ListaPrecioDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        Rentabilidad = x.Rentabilidad,

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == listaPrecioId);
            }
        }

        public IEnumerable<ListaPrecioDTO> Obtener(string cadenaBuscar, bool obtenerEliminadas = false)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.ListaPrecios
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar) && x.EstaEliminado == obtenerEliminadas)
                    .Select(x => new ListaPrecioDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        Rentabilidad = x.Rentabilidad,

                    }).ToList();
            }
        }
    }
}
