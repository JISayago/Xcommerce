using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO;

namespace XCommerce.Servicios.Core.Tarjeta.PlanTarjeta
{
    public class PlanTarjetaServicio : IPlanTarjetaServicio
    {
        public IEnumerable<PlanTarjetaDTO> ObtenerPorIdTarjeta(long tarjetaId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.PlanesTarjetas
                    .Select(x => new PlanTarjetaDTO
                    {
                        Id = x.Id,
                        Alicuota = x.Alicuota,
                        TarjetaId = x.TarjetaId,
                        TarjetaNombre = x.Tarjeta.Descripcion,
                        Descripcion = x.Descripcion
                    }).Where(x => x.TarjetaId == tarjetaId).ToList();
            }
        }
        public void Agregar(PlanTarjetaDTO plan)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var planNuevo = new AccesoDatos.PlanTarjeta
                {
                    Alicuota = plan.Alicuota,
                    TarjetaId = plan.TarjetaId,
                    Descripcion = plan.Descripcion,
                };
                context.PlanesTarjetas.Add(planNuevo);
                context.SaveChanges();
            }
        }

        public void Modificar(PlanTarjetaDTO plan)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var planTarjetaMod = context.PlanesTarjetas.FirstOrDefault(x => x.Id == plan.Id);
                if (planTarjetaMod == null) throw new Exception("No se encontro el Plan de Tarjeta");
                planTarjetaMod.Id = plan.Id;
                planTarjetaMod.Alicuota = plan.Alicuota;
                planTarjetaMod.TarjetaId = plan.TarjetaId;
                planTarjetaMod.Descripcion = plan.Descripcion;
                context.SaveChanges();
            }
        }

        public IEnumerable<PlanTarjetaDTO> Obtener(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.PlanesTarjetas.AsNoTracking()//.Include(x => x.Tarjeta)
                    .Where(x => x.Descripcion.Contains(cadenaBuscar) || x.Tarjeta.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new PlanTarjetaDTO
                    {
                        Id = x.Id,
                        Alicuota = x.Alicuota,
                        TarjetaId = x.TarjetaId,
                        TarjetaNombre = x.Tarjeta.Descripcion,
                        Descripcion = x.Descripcion
                    }).ToList();
            }
        }

        public PlanTarjetaDTO ObtenerPorId(long id)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.PlanesTarjetas
                    .Select(x => new PlanTarjetaDTO
                    {
                        Id = x.Id,
                        Alicuota = x.Alicuota,
                        TarjetaId = x.TarjetaId,
                        TarjetaNombre = x.Tarjeta.Descripcion,
                        Descripcion = x.Descripcion
                    }).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
