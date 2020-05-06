using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Precio.DTO;

namespace XCommerce.Servicios.Core.Precio
{
    public class PrecioServicio : IPrecioServicio
    {
        public void Insertar(PrecioDTO precioNuevo)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoPrecio = new AccesoDatos.Precio
                {
                    PrecioCosto = precioNuevo.PrecioCosto,
                    ActivarHoraVenta = precioNuevo.ActivarHoraVenta,
                    ArticuloId = precioNuevo.ArticuloId,
                    ListaPrecioId = precioNuevo.ListaPrecioId,
                    FechaActualizacion = precioNuevo.FechaActualizacion,
                    HoraVenta = precioNuevo.HoraVenta,
                    PrecioPublico = precioNuevo.PrecioPublico
                };
                context.Precios.Add(nuevoPrecio);

                context.SaveChanges();
            }
        }
        
        public IEnumerable<PrecioDTO> Obtener(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Precios
                    .Include(x => x.Articulo)
                    .AsNoTracking()
                    .Where(x => x.Articulo.Descripcion.Contains(cadenaBuscar) 
                          || x.ListaPrecio.Descripcion.Contains(cadenaBuscar)
                          || x.Articulo.Codigo.Contains(cadenaBuscar)
                          || x.Articulo.CodigoBarra.Contains(cadenaBuscar))
                    .Select(x => new PrecioDTO
                    {
                        Id = x.Id,
                        ActivarHoraVenta = x.ActivarHoraVenta,
                        ArticuloId = x.ArticuloId,
                        DescripcionArticulo = x.Articulo.Descripcion,
                        HoraVenta = x.HoraVenta,
                        ListaPrecioId = x.ListaPrecioId,
                        PrecioCosto = x.PrecioCosto,
                        PrecioPublico = x.PrecioPublico,
                        FechaActualizacion = x.FechaActualizacion,
                        NombreListaPrecio = x.ListaPrecio.Descripcion
                    }).ToList();
            }
        }

        public IEnumerable<PrecioDTO> ObtenerUltimaActualizacion(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var groupPrecios = context.Precios
                    .Include(x => x.Articulo)
                    .AsNoTracking()
                    .Where(x => x.Articulo.Descripcion.Contains(cadenaBuscar)
                          || x.ListaPrecio.Descripcion.Contains(cadenaBuscar)
                          || x.Articulo.Codigo.Contains(cadenaBuscar)
                          || x.Articulo.CodigoBarra.Contains(cadenaBuscar)).GroupBy(x => x.ArticuloId);

                List<PrecioDTO> precios = new List<PrecioDTO>();

                foreach (var precio in groupPrecios)
                {
                    var listapreciogrupo = precio.GroupBy(t => t.ListaPrecioId);

                    foreach (var precio_ in listapreciogrupo)
                    {
                        var x = precio_.OrderByDescending(y => y.FechaActualizacion).FirstOrDefault();
                        precios.Add(new PrecioDTO
                        {
                            Id = x.Id,
                            ActivarHoraVenta = x.ActivarHoraVenta,
                            ArticuloId = x.ArticuloId,
                            DescripcionArticulo = x.Articulo.Descripcion,
                            HoraVenta = x.HoraVenta,
                            ListaPrecioId = x.ListaPrecioId,
                            PrecioCosto = x.PrecioCosto,
                            PrecioPublico = x.PrecioPublico,
                            FechaActualizacion = x.FechaActualizacion,
                            NombreListaPrecio = x.ListaPrecio.Descripcion
                        });

                    }
                }


                return precios.OrderBy(x => x.DescripcionArticulo).ThenBy(x => x.PrecioCosto).ToList();
            }
        }

        public PrecioDTO ObtenerPorId(long id)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Precios
                    .Include(x => x.Articulo)
                    .AsNoTracking()
                    .Select(x => new PrecioDTO
                    {
                        Id = x.Id,
                        ActivarHoraVenta = x.ActivarHoraVenta,
                        ArticuloId = x.ArticuloId,
                        HoraVenta = x.HoraVenta,
                        ListaPrecioId = x.ListaPrecioId,
                        PrecioCosto = x.PrecioCosto,
                        PrecioPublico = x.PrecioPublico,
                        FechaActualizacion = x.FechaActualizacion,
                        DescripcionArticulo = x.Articulo.Descripcion,
                        NombreListaPrecio = x.ListaPrecio.Descripcion
                    }).FirstOrDefault(x => x.Id == id);
            }
        }

        public PrecioDTO ObtenerPorArticuloListaPrecio(long articuloId, long listaPrecioId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Precios
                    .Include(x => x.Articulo)
                    .AsNoTracking()
                    .Select(x => new PrecioDTO
                    {
                        Id = x.Id,
                        ActivarHoraVenta = x.ActivarHoraVenta,
                        ArticuloId = x.ArticuloId,
                        HoraVenta = x.HoraVenta,
                        ListaPrecioId = x.ListaPrecioId,
                        PrecioCosto = x.PrecioCosto,
                        PrecioPublico = x.PrecioPublico,
                        FechaActualizacion = x.FechaActualizacion,
                        DescripcionArticulo = x.Articulo.Descripcion,
                        NombreListaPrecio = x.ListaPrecio.Descripcion
                    }).OrderByDescending(x => x.FechaActualizacion).FirstOrDefault(x => x.ArticuloId == articuloId && x.ListaPrecioId == listaPrecioId);
            }
        }
    }


}
