using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.DTO;

namespace XCommerce.Servicios.Core.Articulo.BajaArticulo
{
    public class BajaArticuloServicio : IBajaArticuloServicio
    {

        public long Insertar(BajaArticuloDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var nuevaBajaArticulo = new AccesoDatos.BajaArticulo()
                {
                    Id = dto.Id,
                    Cantidad = dto.Cantidad,
                    Fecha = dto.Fecha,
                    Observacion = dto.Observacion,
                    MotivoBajaId = dto.MotivoBajaId,
                    ArticuloId = dto.ArticuloId
                };

                context.BajaArticulos.Add(nuevaBajaArticulo);

                context.SaveChanges();

                return nuevaBajaArticulo.Id;
             
            }
        }

        public void Modificar(BajaArticuloDTO dto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var bajaArticuloModificar = context.BajaArticulos
                    .FirstOrDefault(x => x.Id == dto.Id);

                if (bajaArticuloModificar == null) throw new Exception("Ocurrió un error al obtener la Baja del Articulo para Modificarla");

                bajaArticuloModificar.Cantidad = dto.Cantidad;
                bajaArticuloModificar.Observacion = dto.Observacion;
                bajaArticuloModificar.MotivoBajaId = dto.MotivoBajaId;

                context.SaveChanges();
            }
        }

        public BajaArticuloDTO ObtenerBajaMotivoPorId(long BajaArticuloId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.BajaArticulos
                    .AsNoTracking()
                    .Select(x => new BajaArticuloDTO
                    {
                        Id = x.Id,
                        Cantidad = x.Cantidad,
                        Fecha = x.Fecha,
                        Observacion = x.Observacion,
                        MotivoBajaId = x.MotivoBajaId,
                        ArticuloId = x.ArticuloId

                    }).FirstOrDefault(x => x.Id == BajaArticuloId);
            }
        }

        public IEnumerable<BajaArticuloDTO> Obtener(string cadenaBuscar, bool obtenerEliminados = false)
        {
            throw new NotImplementedException();
        }
    }
}
