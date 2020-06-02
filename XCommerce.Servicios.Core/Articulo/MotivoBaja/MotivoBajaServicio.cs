using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja.DTO;

namespace XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja
{
    public class MotivoBajaServicio : IMotivoBajaServicio
    {
        public long Insertar(MotivoBajaDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var motivoBajaNuevo = new AccesoDatos.MotivoBaja
                {
                    Descripcion = dto.Descripcion
                };

                context.MotivosBajas.Add(motivoBajaNuevo);

                context.SaveChanges();

                return motivoBajaNuevo.Id;
            }
        }

        /*public void Modificar(MotivoBajaDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var motivoBajaModificar = context.MotivosBajas.FirstOrDefault(x => x.Id == dto.Id);

                if (motivoBajaModificar == null) throw new Exception("Ocurrio un error al obtener el Motivo Baja para Modificarlo");

                motivoBajaModificar.Descripcion = dto.Descripcion;

                context.SaveChanges();
            }
        }*/

        public IEnumerable<MotivoBajaDTO> ObtenerMotivoBaja(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.MotivosBajas
                    .AsNoTracking()
                    .Where(x => x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new MotivoBajaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion

                    }).ToList();
            }
        }

        public MotivoBajaDTO ObtenerPorId(long motivoBajaId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.MotivosBajas
                    .AsNoTracking()
                    .Select(x => new MotivoBajaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion

                    }).FirstOrDefault(x => x.Id == motivoBajaId);
            }
        }
    }
}
