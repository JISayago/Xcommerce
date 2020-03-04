using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace XCommerce.Servicios.Core.Provincia
{
    public class ProvinciaServicio : IProvinciaServicio
    {
        public void Eliminar(long provinciaId)
        {
            using(var baseDatos = new ModeloXCommerceContainer())
            {
              var provinciaEliminar = baseDatos.Provincias.FirstOrDefault(x => x.Id == provinciaId);

                if (provinciaEliminar == null) throw new Exception("Ocurrió un error al obtener la Provincia para Eliminarla");

                provinciaEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(ProvinciaDTO provinciaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var provinciaNueva = new AccesoDatos.Provincia
                {
                    Descripcion = provinciaDTO.Descripcion
                };

                baseDatos.Provincias.Add(provinciaNueva);

                baseDatos.SaveChanges();

                return provinciaNueva.Id;
                  
            }
        }

        public void Modificar(ProvinciaDTO provinciaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var provinciaModificar = baseDatos.Provincias.FirstOrDefault(x => x.Id == provinciaDTO.Id);

                if (provinciaModificar == null) throw new Exception("Ocurrió un error al obtener la Provincia para Modificarla");

                provinciaModificar.Descripcion = provinciaDTO.Descripcion;

                baseDatos.SaveChanges();
            }
        }

        public ProvinciaDTO ObtenerPorId(long provinciaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Provincias
                    .AsNoTracking()
                    .Select(x => new ProvinciaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x =>!x.EstaEliminado && x.Id == provinciaId);
            }
        }

        public IEnumerable<ProvinciaDTO> ObtenerProvincia(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Provincias
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new ProvinciaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public IEnumerable<ProvinciaDTO> ObtenerProvinciaEliminada(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Provincias
                    .AsNoTracking()
                    .Where(x => x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new ProvinciaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }
    }
}
