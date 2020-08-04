using System.Collections.Generic;
using System.Linq;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Caja.DetalleCaja.DTO;

namespace XCommerce.Servicios.Core.Caja.DetalleCaja
{
    public class DetalleCajaServicio : IDetalleCajaServicio
    {
        public void GenerarDetalleCaja(long idCaja, decimal monto, TipoPago tipoPago)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var nuevoDetalleCaja = new AccesoDatos.DetalleCaja
                {
                    CajaId = idCaja,
                    TipoPago = tipoPago,                   
                    Monto = monto
                };
                baseDatos.DetalleCajas.Add(nuevoDetalleCaja);

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<DetalleCajaDTO> Obtener(long? cajaId, TipoPago? tipo)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                IQueryable<AccesoDatos.DetalleCaja> q = context.DetalleCajas.Include("Cajas");

                if (cajaId != null) q = q.Where(x => x.CajaId == cajaId);
                if (tipo != null) q = q.Where(x => x.TipoPago == tipo);

                return q.Select(x => new DetalleCajaDTO
                {
                    Id = x.Id,
                    cajaId = x.CajaId,
                    monto = x.Monto,
                    tipoPago = x.TipoPago,
                    caja = x.Caja
                }).ToList();
            }
        }
    }
    
}
