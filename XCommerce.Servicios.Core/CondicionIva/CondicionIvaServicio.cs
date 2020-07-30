using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.CondicionIva.DTO;

namespace XCommerce.Servicios.Core.CondicionIva
{
    public class CondicionIvaServicio : ICondicionIvaServicio
    {
        public void Eliminar(long condicionIvaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var CondicionIvaEliminar = baseDatos.CondicionIvas.FirstOrDefault(x => x.Id == condicionIvaId);

                if (CondicionIvaEliminar == null) throw new Exception("Ocurrió un error al obtener la Condicion Iva para Eliminarla");

                baseDatos.SaveChanges();
            }
        }

        public long Insertar(CondicionIvaDTO ConIvaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var CondicionIvaNueva = new AccesoDatos.CondicionIva
                {
                    Descripcion = ConIvaDTO.Descripcion
                };

                baseDatos.CondicionIvas.Add(CondicionIvaNueva);

                baseDatos.SaveChanges();

                return CondicionIvaNueva.Id;

            }
        }

        public void Modificar(CondicionIvaDTO ConIvaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var CondicionIvaModificar = baseDatos.Marcas.FirstOrDefault(x => x.Id == ConIvaDTO.Id);

                if (CondicionIvaModificar == null) throw new Exception("Ocurrió un error al obtener la Condicion Iva para Modificarla");

                CondicionIvaModificar.Descripcion = ConIvaDTO.Descripcion;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<CondicionIvaDTO> ObtenerCondicionIva(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.CondicionIvas
                    .AsNoTracking()
                    .Where(x => x.Descripcion.Contains(cadenaBuscar))
                    .Select(x => new CondicionIvaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion
                        

                    }).ToList();
            }
        }

        public CondicionIvaDTO ObtenerPorId(long CondIvaID)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.CondicionIvas
                    .AsNoTracking()
                    .Select(x => new CondicionIvaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion

                    }).FirstOrDefault(x =>  x.Id == CondIvaID);
            }
        }
    }
}
