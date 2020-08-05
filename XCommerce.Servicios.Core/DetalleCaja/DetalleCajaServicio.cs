using System.Collections.Generic;
using System.Linq;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.DetalleCaja.DTO;

namespace XCommerce.Servicios.Core.DetalleCaja
{
    public class DetalleCajaServicio : IDetalleCajaServicio
    {
        public void Generar(DetalleCajaDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevoDetalleCaja = new AccesoDatos.DetalleCaja
                {
                    CajaId = dto.CajaId,
                    Monto = dto.Monto,
                    TipoPago = dto.TipoPago              
                };

                context.DetalleCajas.Add(nuevoDetalleCaja);

                context.SaveChanges();

            }
        }

        public IEnumerable<DetalleCajaDTO> Obtener(long? cajaId, TipoPago? tipo)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                IQueryable<AccesoDatos.DetalleCaja> q = context.DetalleCajas;

                if (cajaId != null) q = q.Where(x => x.CajaId == cajaId);
                if (tipo != null) q = q.Where(x => x.TipoPago == tipo);

                return q.Select(x => new DetalleCajaDTO
                    {
                        Id = x.Id,
                        CajaId = x.CajaId,
                        Monto  = x.Monto,
                        TipoPago = x.TipoPago,
                        Caja = x.Caja
                    }).ToList();
            }
        }
    }
}
