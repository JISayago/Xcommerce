using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Articulo.Marca.DTO;

namespace XCommerce.Servicios.Core.Articulo.Marca
{
    public class MarcaServicio : IMarcaServicio
    {
        public void Eliminar(long marcaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var marcaEliminar = baseDatos.Marcas.FirstOrDefault(x => x.Id == marcaId);

                if (marcaEliminar == null) throw new Exception("Ocurrió un error al obtener la Marca para Eliminarla");

                marcaEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(MarcaDTO marcaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var marcaNueva = new AccesoDatos.Marca
                {
                    Descripcion = marcaDTO.Descripcion
                };

                baseDatos.Marcas.Add(marcaNueva);

                baseDatos.SaveChanges();

                return marcaNueva.Id;

            }
        }

        public void Modificar(MarcaDTO marcaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var marcaModificar = baseDatos.Marcas.FirstOrDefault(x => x.Id == marcaDTO.Id);

                if (marcaModificar == null) throw new Exception("Ocurrió un error al obtener la Marca para Modificarla");

                marcaModificar.Descripcion = marcaDTO.Descripcion;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<MarcaDTO> ObtenerMarca(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Marcas
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new MarcaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public IEnumerable<MarcaDTO> ObtenerMarcaEliminada(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Marcas
                    .AsNoTracking()
                    .Where(x => x.EstaEliminado && x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new MarcaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).ToList();
            }
        }

        public MarcaDTO ObtenerPorId(long marcaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Marcas
                    .AsNoTracking()
                    .Select(x => new MarcaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == marcaId);
            }
        }
    }
}
