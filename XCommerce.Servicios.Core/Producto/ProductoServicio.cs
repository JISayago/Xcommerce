using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using XCommerce.AccesoDatos;

using XCommerce.Servicios.Core.Producto.DTO;

namespace XCommerce.Servicios.Core.Producto
{
    public class ProductoServicio : IProductoServicio
    {
        public ProductoMesaDTO ObtenerPorCodigo(long mesaID, string codigo)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                return basedatos.Articulos
                    .Include(x => x.Precios)
                    .Include("Precios.ListaPrecio")
                    .Include("Precios.ListaPrecio.Salones")
                    .Include("Precios.ListaPrecio.Salones.Mesas")
                    .AsNoTracking()
                    .Select(x => new ProductoMesaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        DescuentaStock = x.DescuentaStock,
                        Precio = x.Precios
                                 .FirstOrDefault(l => l.ListaPrecio.Salon.Any(s => s.Mesas.Any(m => m.Id == mesaID))
                                         && l.ArticuloId == x.Id
                                         && l.FechaActualizacion == x.Precios
                                 .Where(l2 => l2.ListaPrecio.Salon.Any(s2 => s2.Mesas.Any(m2 => m2.Id == mesaID))
                                         && l2.ArticuloId == x.Id).Max(max => max.FechaActualizacion)).PrecioPublico
                    }).FirstOrDefault(x => x.Codigo == codigo || x.CodigoBarra == codigo) ;
            }
        }

        public ProductoMesaDTO ObtenerPorCodigoSalon(string salonDesc, string codigo)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var producto = context.Articulos
                    .Include(x => x.Precios)
                    .Include("Precios.ListaPrecio")
                    .AsNoTracking()
                    .Select(x => new ProductoMesaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        DescuentaStock = x.DescuentaStock,
                        Precio = x.Precios.Any(lp => lp.ListaPrecio.Descripcion  == salonDesc) ?
                        x.Precios.Where(l => l.ListaPrecio.Descripcion == salonDesc)
                        .OrderByDescending(f => f.FechaActualizacion).FirstOrDefault().PrecioPublico
                        : -1,
                    }).FirstOrDefault(x => x.Codigo == codigo || x.CodigoBarra == codigo);

                if (producto != null)
                {
                    if (producto.Precio == -1) return null;
                }
                return producto;
            }

        }

        public ProductoMesaDTO ObtenerPorCodigoKiosco(string codigo)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var producto = context.Articulos
                    .Include(x => x.Precios)
                    .Include("Precios.ListaPrecio")
                    .AsNoTracking()
                    .Select(x => new ProductoMesaDTO()
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        Precio = x.Precios.Any(lp => lp.ListaPrecio.Descripcion.Contains("Kiosco")) ?
                        x.Precios.Where(l => l.ListaPrecio.Descripcion.Contains("Kiosco"))
                        .OrderByDescending(f => f.FechaActualizacion).FirstOrDefault().PrecioPublico
                        : -1,
                        DescuentaStock = x.DescuentaStock,

                    }).FirstOrDefault(x => x.Codigo == codigo || x.CodigoBarra == codigo);

                if (producto != null)
                {
                    if (producto.Precio == -1) return null;

                }

                return producto;
            }
        }

    }
}