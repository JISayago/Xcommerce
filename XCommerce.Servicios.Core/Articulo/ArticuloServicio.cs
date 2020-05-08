using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo.DTO;
using System.Data.Entity;

namespace XCommerce.Servicios.Core.Articulo
{
    public class ArticuloServicio : IArticuloServicio
    {
        public void DescontarStock(long articuloId, decimal cantidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(long articuloId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var articuloAEliminar = context.Articulos
                    .FirstOrDefault(x => x.Id == articuloId);

                if (articuloAEliminar == null || articuloAEliminar.EstaEliminado) throw new Exception("No se encontro el artículo");

                articuloAEliminar.EstaEliminado = true;

                context.SaveChanges();
            }
        }

        public long Insertar(ArticuloDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoArticulo = new AccesoDatos.Articulo()
                {
                    Id = (int)dto.Id,
                    Codigo = dto.Codigo,
                    CodigoBarra = dto.CodigoBarra,
                    Abreviatura = dto.Abreviatura,
                    Descripcion = dto.Descripcion,
                    Detalle = dto.Detalle,
                    ActivarLimiteVenta = dto.ActivarLimiteVenta,
                    LimiteVenta = dto.LimiteVenta,
                    PermiteStockNegativo = dto.PermiteStockNegativo,
                    EstaDiscontinuado = dto.EstaDiscontinuado,
                    StockMaximo = dto.StockMaximo,
                    StockMinimo = dto.StockMinimo,
                    Stock = dto.Stock,
                    DescuentaStock = dto.DescuentaStock,
                    MarcaId = dto.MarcaId,
                    RubroId = dto.RubroId,
                    Foto = dto.Foto
                };
                
                context.Articulos.Add(nuevoArticulo);

                context.SaveChanges();

                return nuevoArticulo.Id;
            }
        }

        public void Modificar(ArticuloDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var articuloAModificar = context.Articulos
                    .Include(x => x.Rubro)
                    .Include(x => x.Marca)
                    .FirstOrDefault(x => x.Id == dto.Id);

                if (articuloAModificar == null) throw new Exception("No se encontro el artículo");

                articuloAModificar.Id = (int)dto.Id;
                articuloAModificar.Descripcion = dto.Descripcion;
                articuloAModificar.Detalle = dto.Detalle;
                articuloAModificar.Codigo = dto.Codigo;
                articuloAModificar.CodigoBarra = dto.CodigoBarra;
                articuloAModificar.Abreviatura = dto.Abreviatura;
                articuloAModificar.ActivarLimiteVenta = dto.ActivarLimiteVenta;
                articuloAModificar.DescuentaStock = dto.DescuentaStock;
                articuloAModificar.EstaDiscontinuado = dto.EstaDiscontinuado;
                articuloAModificar.EstaEliminado = dto.EstaEliminado;
                articuloAModificar.Foto = dto.Foto;
                articuloAModificar.PermiteStockNegativo = dto.PermiteStockNegativo;
                articuloAModificar.LimiteVenta = dto.LimiteVenta;
                articuloAModificar.MarcaId = dto.MarcaId;
                articuloAModificar.RubroId = dto.RubroId;
                articuloAModificar.Stock = dto.Stock;
                articuloAModificar.StockMaximo = dto.StockMaximo;
                articuloAModificar.StockMinimo = dto.StockMinimo;

                context.SaveChanges();
            }
        }

        public IEnumerable<ArticuloDTO> Obtener(string cadenaBuscar, bool obtenerEliminados = false)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Articulos
                    .Include(x => x.Rubro)
                    .Include(x => x.Marca)
                    .AsNoTracking().Where(x =>
                        x.Descripcion.Contains(cadenaBuscar) || x.Abreviatura.Contains(cadenaBuscar) || x.Codigo == cadenaBuscar ||
                        x.CodigoBarra == cadenaBuscar || x.Marca.Descripcion == cadenaBuscar ||
                        x.Rubro.Descripcion == cadenaBuscar && x.EstaEliminado == obtenerEliminados)
                    .Select(x => new ArticuloDTO
                    {
                        Descripcion = x.Descripcion,
                        Abreviatura = x.Abreviatura,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        ActivarLimiteVenta = x.ActivarLimiteVenta,
                        DescuentaStock = x.DescuentaStock,
                        Detalle = x.Detalle,
                        EstaDiscontinuado = x.EstaDiscontinuado,
                        EstaEliminado = x.EstaEliminado,
                        Foto = x.Foto,
                        Id = x.Id,
                        LimiteVenta = x.LimiteVenta,
                        MarcaId = x.MarcaId,
                        PermiteStockNegativo = x.PermiteStockNegativo,
                        RubroId = x.RubroId,
                        Stock = x.Stock,
                        StockMaximo = x.StockMaximo,
                        StockMinimo = x.StockMinimo
                    }).ToList();
            }
        }

        public ArticuloDTO ObtenerPorCodigo(string codigoBuscar, string codigoBarraBuscar)
        {
            throw new NotImplementedException();
        }

        public ArticuloDTO ObtenerPorCodigoModificar(string CodigoBuscar, string CodigoBarraBuscar, long EntidadId)
        {
            throw new NotImplementedException();
        }

        public ArticuloDTO ObtenerPorId(long articuloId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Articulos
                    .AsNoTracking()
                    .Select(x => new ArticuloDTO
                    {
                        Descripcion = x.Descripcion,
                        Abreviatura = x.Abreviatura,
                        Codigo = x.Codigo,
                        CodigoBarra = x.CodigoBarra,
                        ActivarLimiteVenta = x.ActivarLimiteVenta,
                        DescuentaStock = x.DescuentaStock,
                        Detalle = x.Detalle,
                        EstaDiscontinuado = x.EstaDiscontinuado,
                        EstaEliminado = x.EstaEliminado,
                        Foto = x.Foto,
                        Id = x.Id,
                        LimiteVenta = x.LimiteVenta,
                        MarcaId = x.MarcaId,
                        PermiteStockNegativo = x.PermiteStockNegativo,
                        RubroId = x.RubroId,
                        Stock = x.Stock,
                        StockMaximo = x.StockMaximo,
                        StockMinimo = x.StockMinimo
                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == articuloId);
            }
        }
    }
}
