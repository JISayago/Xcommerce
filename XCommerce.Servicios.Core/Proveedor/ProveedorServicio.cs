using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Proveedor.DTO;

namespace XCommerce.Servicios.Core.Proveedor
{
    public class ProveedorServicio : IProveedorServicio
    {
        public void Eliminar(long ProveedorId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var ProveedorEliminar = context.Proveedores.FirstOrDefault(x => x.Id == ProveedorId);

                if (ProveedorEliminar == null) throw new Exception("Ocurrió un error al obtener el Proveedor para eliminarlo");               

                context.SaveChanges();
            }
        }

        public long Insertar(ProveedorDTO Proveedordto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var ProovedorNueva = new AccesoDatos.Proveedor
                {
                   
                    RazonSocial = Proveedordto.RazonSocial,
                    Telefono = Proveedordto.Telefono,
                    Email = Proveedordto.Email,
                    CondicionIvaId = Proveedordto.CondicionIvaId,
                    Contacto = Proveedordto.Contacto
                };

                context.Proveedores.Add(ProovedorNueva);

                context.SaveChanges();

                return ProovedorNueva.Id;

            }
        }

        public void Modificar(ProveedorDTO Proveedordto)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var ProveedorModificar = context.Proveedores.FirstOrDefault(x => x.Id == Proveedordto.Id);

                if (ProveedorModificar == null) throw new Exception("Ocurrió un error al obtener el Proovedor para modificarlo");

                ProveedorModificar.RazonSocial = Proveedordto.RazonSocial;
                ProveedorModificar.Contacto = Proveedordto.Contacto;
                ProveedorModificar.Email = Proveedordto.Email;
                ProveedorModificar.CondicionIvaId = Proveedordto.CondicionIvaId;
                ProveedorModificar.Telefono = Proveedordto.Telefono;

                context.SaveChanges();
            }
        }

        public IEnumerable<ProveedorDTO> Obtener(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Proveedores
                    .AsNoTracking()
                    .Where(x => x.RazonSocial.Contains(cadenaBuscar))
                    .Select(x => new ProveedorDTO
                    {
                        Id = x.Id,
                        RazonSocial = x.RazonSocial,
                        Telefono = x.Telefono,
                        Email = x.Email,
                        CondicionIvaId = x.CondicionIvaId,
                        Contacto = x.Contacto

                    }).ToList();
            }
        }

        public ProveedorDTO ObtenerPorId(long ProveedorId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Proveedores
                    .AsNoTracking()
                    .Select(x => new ProveedorDTO
                    {
                        Id = x.Id,
                        RazonSocial = x.RazonSocial,
                        Telefono = x.Telefono,
                        Email = x.Email,
                        CondicionIvaId = x.CondicionIvaId,
                        Contacto = x.Contacto

                    }).FirstOrDefault(x =>  x.Id == ProveedorId);
            }
        }

        public ProveedorDTO ObtenerRazonSocial(string razonSocial)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Proveedores
                    .AsNoTracking()
                    .Select(x => new ProveedorDTO
                    {
                        Id = x.Id,
                        RazonSocial = x.RazonSocial,
                        Telefono = x.Telefono,
                        Email = x.Email,
                        CondicionIvaId = x.CondicionIvaId,
                        Contacto = x.Contacto

                    }).FirstOrDefault(x => x.RazonSocial == razonSocial);
            }
        }
    }
}
