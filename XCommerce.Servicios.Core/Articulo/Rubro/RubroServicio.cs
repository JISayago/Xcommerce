using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo.Rubro.DTO;

namespace XCommerce.Servicios.Core.Articulo.Rubro
{
    public class RubroServicio : IRubroServicio
    {
        public void Eliminar(long rubroId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var rubroEliminar = baseDatos.Rubros.FirstOrDefault(x => x.Id == rubroId);

                if (rubroEliminar == null) throw new Exception("Ocurrió un error al obtener el Rubro para Eliminarla");

                rubroEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(RubroDTO rubroDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var rubroNuevo = new AccesoDatos.Rubro
                {
                    Descripcion = rubroDTO.Descripcion
                };

                baseDatos.Rubros.Add(rubroNuevo);

                baseDatos.SaveChanges();

                return rubroNuevo.Id;

            }
        }

        public void Modificar(RubroDTO rubroDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var rubroModificar = baseDatos.Rubros.FirstOrDefault(x => x.Id == rubroDTO.Id);

                if (rubroDTO == null) throw new Exception("Ocurrió un error al obtener el Rubro para Modificarla");

                rubroModificar.Descripcion = rubroDTO.Descripcion;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<RubroDTO> ObtenerRubro(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Rubros
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new RubroDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public IEnumerable<RubroDTO> ObtenerRubroEliminada(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Rubros
                    .AsNoTracking()
                    .Where(x => x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new RubroDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public RubroDTO ObtenerPorId(long rubroId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Rubros
                    .AsNoTracking()
                    .Select(x => new RubroDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == rubroId);
            }
        }
    }
}
