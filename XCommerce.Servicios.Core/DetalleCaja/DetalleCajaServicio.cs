using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
