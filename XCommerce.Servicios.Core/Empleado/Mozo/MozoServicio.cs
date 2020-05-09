using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Empleado.Mozo.DTO;
using XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario.DTO;

namespace XCommerce.Servicios.Core.Empleado.Mozo
{
    public class MozoServicio : IMozoServicio
    {
        public void asignarMozoAMesa(long mesaId, MozoDTO mozo)
        {

            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var comprobante = baseDatos.Comprobantes
                    .OfType<ComprobanteSalon>()
                    .FirstOrDefault(x => x.MesaId == mesaId && x.EstadoComprobanteSalon == EstadoComprobanteSalon.EnProceso);

                if (comprobante == null) throw new Exception("ocurrio un Error al obtener el comprobante");
                comprobante.MozoId = mozo.Id;
                baseDatos.SaveChanges();

            }
}

        public MozoDTO ObtenerMozoPorLegajo(int legajo)
        {        
            using (var baseDatos = new ModeloXCommerceContainer())
             {
                    return baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                          .AsNoTracking()
                          .Where(x => !x.EstaEliminado)
                          .Select(x => new MozoDTO
                          {
                              Id = x.Id,
                              Legajo = x.Legajo,
                              Apellido = x.Apellido,
                              Nombre = x.Nombre                                                      }
                          ).FirstOrDefault(x => x.Legajo == legajo);


            }
            
        }
    }
}
