using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Comprobante.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public class ComprobanteServicio : IComprobanteServicio
    {
        public long Generar(ComprobanteDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoComprobante = new AccesoDatos.ComprobanteFactura
                {
                    ClienteId = dto.ClienteId,
                    Descuento = dto.Descuento,
                    Fecha = dto.Fecha,
                    Numero = 0,
                    SubTotal = dto.SubTotal,
                    Total = dto.Total,
                    TipoComprobante = TipoComprobante.A,
                    UsuarioId = dto.UsuarioId,
                    DetalleComprobantes = new List<DetalleComprobante>()
                };

                context.Comprobantes.Add(nuevoComprobante);

                var list = new List<DetalleComprobante>();
                foreach (var it in dto.Items)
                {
                    var detalle = new DetalleComprobante
                    {
                        ComprobanteId = nuevoComprobante.Id,
                        SubTotal = it.SubtotalLinea,
                        Codigo = it.CodigoProducto,
                        Cantidad = it.CantidadProducto,
                        PrecioUnitario = it.PrecioUnitario,
                        Descripcion = it.DescripcionProducto,
                        ArticuloId = it.ProductoId
                    };
                    list.Add(detalle);
                    context.DetalleComprobantes.Add(detalle);
                }
                nuevoComprobante.DetalleComprobantes = list;
                context.SaveChanges();

                return nuevoComprobante.Id;
            }
        }

        public long GenerarComprobanteCompra(ComprobanteCompraDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoComprobante = new ComprobanteCompra
                {
                    ClienteId = dto.ClienteId,
                    Descuento = dto.Descuento,
                    ProveedorId = dto.ProveedorId,
                    Fecha = dto.Fecha,
                    Numero = 0,
                    SubTotal = dto.SubTotal,
                    Total = dto.Total,
                    TipoComprobante = TipoComprobante.A,
                    UsuarioId = dto.UsuarioId,
                    DetalleComprobantes = new List<DetalleComprobante>()
                };

                context.Comprobantes.Add(nuevoComprobante);

                var list = new List<DetalleComprobante>();
                foreach (var it in dto.Items)
                {
                    var detalle = new DetalleComprobante
                    {
                        ComprobanteId = nuevoComprobante.Id,
                        SubTotal = it.SubtotalLinea,
                        Codigo = it.CodigoProducto,
                        Cantidad = it.CantidadProducto,                        
                        PrecioUnitario = it.PrecioUnitario,
                        Descripcion = it.DescripcionProducto,
                        ArticuloId = it.ProductoId
                    };
                    list.Add(detalle);
                    context.DetalleComprobantes.Add(detalle);
                }
                nuevoComprobante.DetalleComprobantes = list;
                context.SaveChanges();

                return nuevoComprobante.Id;
            }
        }

        public long GenerarComprobanteDelivery(ComprobanteDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoComprobante = new ComprobanteDelivery
                {
                    ClienteId = dto.ClienteId,
                    Descuento = dto.Descuento,
                    Fecha = dto.Fecha,
                    Numero = 0,
                    SubTotal = dto.SubTotal,
                    Total = dto.Total,
                    TipoComprobante = TipoComprobante.A,
                    UsuarioId = dto.UsuarioId,
                    DetalleComprobantes = new List<DetalleComprobante>()
                };

                context.Comprobantes.Add(nuevoComprobante);

                var list = new List<DetalleComprobante>();
                foreach (var it in dto.Items)
                {
                    var detalle = new DetalleComprobante
                    {
                        ComprobanteId = nuevoComprobante.Id,
                        SubTotal = it.SubtotalLinea,
                        Codigo = it.CodigoProducto,
                        Cantidad = it.CantidadProducto,
                        PrecioUnitario = it.PrecioUnitario,
                        Descripcion = it.DescripcionProducto,
                        ArticuloId = it.ProductoId
                    };
                    list.Add(detalle);
                    context.DetalleComprobantes.Add(detalle);
                }
                nuevoComprobante.DetalleComprobantes = list;
                context.SaveChanges();

                return nuevoComprobante.Id;
            }
        }
        public T_ComprobanteDTO ObtenerPorId(long comprobanteId)
        {

            using (var context = new ModeloXCommerceContainer())
            {
                var comp = context.Comprobantes
               .AsNoTracking()
               .Select(x => new T_ComprobanteDTO
               {
                   Id = x.Id,
                   ClienteId = x.ClienteId,
                   Descuento = x.Descuento,
                   Fecha = x.Fecha,
                   UsuarioId = x.UsuarioId,
                   Numero = x.Numero,
                   Tipo = x.TipoComprobante,
               }).FirstOrDefault(y => y.Id == comprobanteId);

                var items = context.Comprobantes
                .AsNoTracking().FirstOrDefault(x => x.Id == comprobanteId).DetalleComprobantes;

                Func<List<DetalleComprobante>, List<DetalleComprobanteDTO>>
                    convertirADaDTO = (List<AccesoDatos.DetalleComprobante> detalles) => {
                        List<DetalleComprobanteDTO> lista_detalles = new List<DetalleComprobanteDTO>();
                        foreach (var it in detalles)
                        {
                            var detalle = new DetalleComprobanteDTO
                            {
                                ComprobanteId = it.ComprobanteId,
                                CodigoProducto = it.Codigo,
                                CantidadProducto = it.Cantidad,
                                PrecioUnitario = it.PrecioUnitario,
                                DescripcionProducto = it.Descripcion,
                                ProductoId = it.Id
                            };
                            lista_detalles.Add(detalle);
                        }
                        return lista_detalles;
                    };

                    comp.Items = convertirADaDTO(items.ToList());

                    return comp;

            }
        }

    }
}


