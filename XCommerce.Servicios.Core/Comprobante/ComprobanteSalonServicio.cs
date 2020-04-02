using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Comprobante.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public class ComprobanteSalonServicio : IComprobanteSalonServicio
    {
        public void GenerarComprobanteSalon(long mesaId, long usuarioId, int comensales, long? mozoId = null)
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
                    Comensal = Convert.ToString(comensales),
                    Descuento = 0m,
                    Fecha = DateTime.Now,
                    MozoId = mozoId,
                    Numero = 0,
                    SubTotal = 0m,
                    Total = 0m,
                    TipoComprobante = TipoComprobante.X,
                    UsuarioId = usuarioId,
                    DetalleComprobantes = new List<DetalleComprobante>()


                };

                baseDatos.Comprobantes.Add(nuevoComprobante);
                baseDatos.SaveChanges();
            }
        }

        public ComprobanteMesaDTO Obtener(long mesaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Comprobantes.OfType<ComprobanteSalon>()
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
                          NombreMozo =x.MozoId.HasValue ? x.Mozo.Nombre : "Asignado...",
                          UsuarioId = x.UsuarioId,
                          Items = x.DetalleComprobantes.Select(c => new DetalleComprobanteSalonDTO
                          {
                              CantidadProducto = c.Cantidad,
                              PrecioUnitario = c.PrecioUnitario,
                              ComprobanteId = c.ComprobanteId,
                              CodigoProduto = c.Codigo,
                              DescripcionProducto = c.Descripcion,
                              DetalleId = c.Id,
                              ProductoId = c.ArticuloId

                          }).ToList()
                      }).FirstOrDefault(x => x.MesaId == mesaId);


            }
            
        }
    }
}
