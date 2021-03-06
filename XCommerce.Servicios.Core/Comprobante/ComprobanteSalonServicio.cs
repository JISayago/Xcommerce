﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Articulo.DTO;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Producto.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public class ComprobanteSalonServicio : IComprobanteSalonServicio
    {
        public void AgregarItems(long mesaId, decimal cantidad, ProductoMesaDTO dto)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                var comprobante = basedatos.Comprobantes
                    .OfType<ComprobanteSalon>()
                    .FirstOrDefault(x => x.MesaId == mesaId && x.EstadoComprobanteSalon == EstadoComprobanteSalon.EnProceso);


                if (comprobante == null) throw new Exception("ocurrio un Error al obtener el comprobante");
                var item = comprobante.DetalleComprobantes
                         .FirstOrDefault(x => x.Codigo == dto.Codigo);

                if (item == null)
                {
                    comprobante.DetalleComprobantes.Add(new DetalleComprobante
                    {
                        ComprobanteId = comprobante.Id,
                        ArticuloId = dto.Id,
                        Cantidad = cantidad,
                        Codigo = dto.Codigo,
                        Descripcion = dto.Descripcion,
                        PrecioUnitario = dto.Precio,
                        SubTotal = dto.Precio * cantidad
                    });
                    
                }
                else
                {
                    item.Cantidad += cantidad;
                    item.SubTotal = item.Cantidad * item.PrecioUnitario;
                    if (dto.DescuentaStock)
                    {
                        var articulo = basedatos.Articulos.FirstOrDefault(x => x.Id == dto.Id);
                        if (articulo == null) throw new Exception("Ocurrió un error");
                        articulo.Stock -= cantidad;
                    }
                }           


                basedatos.SaveChanges();

            }
        }


        public void FacturarComprobanteSalon(long mesaId,ComprobanteMesaDTO comprobanteMesa)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var articuloServicio = new ArticuloServicio();

                var comprobante = baseDatos.Comprobantes
                    .OfType<ComprobanteSalon>()
                    .FirstOrDefault(x => x.MesaId == mesaId && x.EstadoComprobanteSalon == EstadoComprobanteSalon.EnProceso);

                var mesa = baseDatos.Mesas.FirstOrDefault(x => x.Id == mesaId);

                mesa.EstadoMesa = EstadoMesa.Cerrada;
                if (mesa == null) throw new Exception("Ocurrió un error al conseguir la Mesa");

                comprobante.SubTotal = comprobanteMesa.SubTotal;
                comprobante.Total = comprobanteMesa.Total;
                comprobante.Descuento = comprobanteMesa.Descuento;
                comprobante.EstadoComprobanteSalon = EstadoComprobanteSalon.Facturada;


                var items = comprobanteMesa.Items;
                foreach(var item in items)
                {
                    var productoId = articuloServicio.ObtenerPorCodigo(item.CodigoProducto).Id;
                    articuloServicio.DescontarStock(productoId,item.CantidadProducto);                    
                }

                baseDatos.SaveChanges();

            }
        }

        public long GenerarComprobanteSalon(long mesaId, long usuarioId, int comensales, long? mozoId = null)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {


                var clienteConsumidorFinal = baseDatos.Personas
                    .OfType<AccesoDatos.Cliente>()
                    .FirstOrDefault(x => x.Dni == "99999999");


                if (clienteConsumidorFinal == null) throw new Exception("Ocurrió un error al conseguir al Consumidor final");

                var mesa = baseDatos.Mesas.FirstOrDefault(x => x.Id == mesaId);

                if (mesa == null) throw new Exception("Ocurrió un error al conseguir la Mesa");

                mesa.EstadoMesa = EstadoMesa.Abierta;

                var nuevoComprobante = new ComprobanteSalon
                {
                    MesaId = mesaId,
                    ClienteId = clienteConsumidorFinal.Id,
                    EstadoComprobanteSalon = EstadoComprobanteSalon.EnProceso,
                    Comensal = Convert.ToString(comensales),
                    Descuento = 0m,
                    Fecha = DateTime.Now,
                    MozoId = mozoId,
                    Numero = 0,
                    SubTotal = 0m,
                    Total = 0m,
                    TipoComprobante = TipoComprobante.X,
                    UsuarioId = usuarioId,
                    DetalleComprobantes = new List<DetalleComprobante>(),
                };

                nuevoComprobante.Numero = 100_000_000 + (int)nuevoComprobante.Id;

                baseDatos.Comprobantes.Add(nuevoComprobante);
                baseDatos.SaveChanges();
                return nuevoComprobante.Id;


            }
        }

        public void Eliminar(long comprobanteID)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var comprobanteEliminar = baseDatos.Comprobantes
                    .OfType<ComprobanteSalon>()
                    .FirstOrDefault(x => x.Id == comprobanteID);

                baseDatos.Comprobantes.Remove(comprobanteEliminar);
                baseDatos.SaveChanges();
            }
                
        }



        public ComprobanteMesaDTO Obtener(long mesaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Comprobantes
                      .OfType<ComprobanteSalon>()
                      .Include(x => x.Mozo)
                      .AsNoTracking()
                      .Select(x => new ComprobanteMesaDTO
                      {
                          ClienteId = x.ClienteId,
                          ComprobanteId = x.Id,
                          Descuento = x.Descuento,
                          Fecha = x.Fecha,
                          MesaId = x.MesaId,
                          MozoId = x.MozoId,
                          Legajo = x.MozoId.HasValue ? x.Mozo.Legajo : 0,
                          ApellidoMozo = x.MozoId.HasValue ? x.Mozo.Apellido : "No ",
                          NombreMozo = x.MozoId.HasValue ? x.Mozo.Nombre : "Asignado...",
                          UsuarioId = x.UsuarioId,
                          Items = x.DetalleComprobantes.Select(c => new DetalleComprobanteSalonDTO
                          {
                              CantidadProducto = c.Cantidad,
                              PrecioUnitario = c.PrecioUnitario,
                              ComprobanteId = c.ComprobanteId,
                              CodigoProducto = c.Codigo,
                              DescripcionProducto = c.Descripcion,
                              DetalleId = c.Id,
                              ProductoId = c.ArticuloId

                          }).ToList()
                      }).OrderByDescending(x => x.Fecha)
                      .FirstOrDefault(x => x.MesaId == mesaId);


            }

        }



        public void QuitarItems(long detalleID)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {

                var DetalleComprobante = baseDatos.DetalleComprobantes
                            .FirstOrDefault(x => x.Id == detalleID);                    
                             

                baseDatos.DetalleComprobantes.Remove(DetalleComprobante);
                baseDatos.SaveChanges();


            }

        }
    }
}


