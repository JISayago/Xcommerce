using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Localidad.DTO;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace XCommerce.Servicios.Core.Localidad
{
    public class LocalidadServicio : ILocalidadServicio
    {
        public void Eliminar(long localidadId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var localidadEliminar = baseDatos.Localidades.FirstOrDefault(x => x.Id == localidadId);

                if (localidadEliminar == null) throw new Exception("Ocurrió un error al obtener la Localidad para Eliminarla");

                localidadEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(LocalidadDTO localidadDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var localidadNueva = new AccesoDatos.Localidad
                {
                    Descripcion = localidadDTO.Descripcion,
                    ProvinciaId = localidadDTO.ProvinciaId,
                    EstaEliminado = localidadDTO.EstaEliminado
                };

                baseDatos.Localidades.Add(localidadNueva);

                baseDatos.SaveChanges();

                return localidadNueva.Id;

            }
        }

        public void Modificar(LocalidadDTO localidadDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var localidadModificar = baseDatos.Localidades.FirstOrDefault(x => x.Id == localidadDTO.Id);

                if (localidadModificar == null) throw new Exception("Ocurrió un error al obtener la Localidad para Modificarla");

                localidadModificar.Descripcion = localidadDTO.Descripcion;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<LocalidadDTO> ObtenerLocalidad(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Localidades
                    .AsNoTracking()
                    .Include(x => x.Provincia)
                    .Where(x=>!x.EstaEliminado)
                    .Select(x => new LocalidadDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        EstaEliminado = x.EstaEliminado,
                        ProvinciaDescrip = x.Provincia.Descripcion
                    }).ToList();
            }
        }

        public LocalidadDTO ObtenerPorId(long localidadId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Localidades
                    .AsNoTracking()
                    .Select(x => new LocalidadDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == localidadId);
            }
        }

        public IEnumerable<LocalidadDTO> ObtenerLocalidadEliminada(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Localidades
                    .AsNoTracking()
                    .Include(x => x.Provincia)
                    .Where(x => x.EstaEliminado)
                    .Select(x => new LocalidadDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        EstaEliminado = x.EstaEliminado,
                        ProvinciaDescrip = x.Provincia.Descripcion
                    }).ToList();
            }
        }

        public IEnumerable<LocalidadDTO> ObtenerLocalidadPorProvincia(long provinciaId, string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Localidades
                    .AsNoTracking()
                    .Include(x => x.Provincia)
                    .Where(x => !x.EstaEliminado && (x.ProvinciaId == provinciaId && x.Descripcion.Contains(cadenaBuscar)))
                    .Select(x => new LocalidadDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        ProvinciaId = x.ProvinciaId,
                        EstaEliminado = x.EstaEliminado,
                        ProvinciaDescrip = x.Provincia.Descripcion
                    }).ToList();
            }
        }

       
        


    }
}
