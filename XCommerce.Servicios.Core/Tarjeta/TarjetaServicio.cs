using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Tarjeta.DTO;

namespace XCommerce.Servicios.Core.Tarjeta
{
    public class TarjetaServicio : ITarjetaServicio
    {
        public void Agregar(TarjetaDTO tarjeta)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var tarjetaNueva = new AccesoDatos.Tarjeta
                {
                    Descripcion = tarjeta.Descripcion
                };
                context.TarjetaSet.Add(tarjetaNueva);
                context.SaveChanges();
               
            }
        }

        public void Eliminar(long? entidadId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var tarjetaEliminar = context.TarjetaSet.FirstOrDefault(x => x.Id == entidadId);
                if (tarjetaEliminar == null) throw new Exception("No se encontro la Tarjeta");
                context.SaveChanges();
            }
        }

        public void Modificar(TarjetaDTO tarjeta)
        {
            using (var context = new ModeloXCommerceContainer())
            {

                var tarjetaModificar = context.TarjetaSet.FirstOrDefault(x => x.Id == tarjeta.Id);
                if (tarjetaModificar == null) throw new Exception("No se encontro la Tarjeta");
                tarjetaModificar.Descripcion = tarjeta.Descripcion;
                tarjetaModificar.Id = tarjeta.Id;
                context.SaveChanges();
            }
        }

        public IEnumerable<TarjetaDTO> Obtener(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.TarjetaSet.AsNoTracking().Where(x => x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new TarjetaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                    }).ToList();
            }
        }

        public TarjetaDTO ObtenerPorId(long? entidadId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.TarjetaSet.AsNoTracking().Select(x => new TarjetaDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                }).FirstOrDefault(x => x.Id == entidadId);
            }
        }
    }
}
