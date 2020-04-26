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
                var caja = new AccesoDatos.Caja
                {
                    UsuarioAperturaId = dto.UsuarioAperturaId,
                    MontoApertura = dto.MontoApertura,
                    FechaApertura = DateTime.Now,
                    FechaCierre = DateTime.Now,
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

    }
}
