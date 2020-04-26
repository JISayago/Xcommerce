using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    
    }
}
