using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Caja.DTO;

namespace XCommerce.Servicios.Core.Caja
{
    public class CajaServicio : ICajaServicio
    {
        public long Abrir(CajaDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                DateTime date = DateTime.Now;
                var caja = new AccesoDatos.Caja
                {
                    UsuarioAperturaId = dto.UsuarioAperturaId,
                    MontoApertura = dto.MontoApertura,
                    FechaApertura = date,
                    FechaCierre = date,
                    UsuarioCierreId = dto.UsuarioAperturaId,
                    MontoCierre = dto.MontoApertura,
                    MontoSistema = 0,
                    Diferencia = 0,
                };
                context.Cajas.Add(caja);
                context.SaveChanges();

                return caja.Id;
            }
        }

        public void Cerrar(CajaDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var cajaCerrar = context.Cajas.FirstOrDefault(x => x.Id == dto.Id);

                cajaCerrar.FechaCierre = DateTime.Now;
                cajaCerrar.UsuarioCierreId = dto.UsuarioCierreId;
                cajaCerrar.MontoCierre = dto.MontoCierre;
                cajaCerrar.Diferencia = dto.Diferencia;
                cajaCerrar.MontoSistema = dto.MontoSistema;

                context.SaveChanges();
            }
        }

        public CajaDTO Obtener(long cajaId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Cajas
                    .AsNoTracking()
                    .Select(x => new CajaDTO
                    {
                        Id = x.Id,
                        FechaApertura = x.FechaApertura,
                        FechaCierre = x.FechaCierre,
                        MontoApertura = x.MontoApertura,
                        MontoCierre = x.MontoCierre,
                        UsuarioAperturaId = x.UsuarioAperturaId
                    }).FirstOrDefault(x => x.Id == cajaId);

            }
        }

        public bool HayCajaAbierta()
        {

            using (var context = new ModeloXCommerceContainer())
            {
                return context.Cajas.Any(x => x.FechaApertura == x.FechaCierre);
            }
        }

        public long ObtenerCajaAbierta()
        {

            using (var context = new ModeloXCommerceContainer())
            {
                return context.Cajas.Where(x => x.FechaApertura == x.FechaCierre).FirstOrDefault().Id;
            }
        }

    }
}