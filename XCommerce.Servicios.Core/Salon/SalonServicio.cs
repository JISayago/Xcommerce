using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Salon.DTO;

namespace XCommerce.Servicios.Core.Salon
{
    public class SalonServicio : ISalonServicio
    {
        public void Eliminar(long salonId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var salonEliminar = baseDatos.Salones.FirstOrDefault(x => x.Id == salonId);

                if (salonEliminar == null) throw new Exception("Ocurrió un error al obtener el Salón para Eliminarlo");

                salonEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(SalonDTO salonDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var salonNuevo = new AccesoDatos.Salon
                {
                    Descripcion = salonDTO.Descripcion
                };

                baseDatos.Salones.Add(salonNuevo);

                baseDatos.SaveChanges();

                return salonNuevo.Id;

            }
        }

        public void Modificar(SalonDTO salonDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var salonModificar = baseDatos.Salones.FirstOrDefault(x => x.Id == salonDTO.Id);

                if (salonModificar == null) throw new Exception("Ocurrió un error al obtener esl Salón para Modificarlo");

                salonModificar.Descripcion = salonDTO.Descripcion;

                baseDatos.SaveChanges();
            };
        }

        public SalonDTO ObtenerPorId(long salonId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Salones
                    .AsNoTracking()
                    .Select(x => new SalonDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == salonId);
            }
        }

        public IEnumerable<SalonDTO> ObtenerSalon(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Salones
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new SalonDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public IEnumerable<SalonDTO> ObtenerSalonEliminado(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Salones
                    .AsNoTracking()
                    .Where(x => x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new SalonDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }
    }
}
