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
    }
}

