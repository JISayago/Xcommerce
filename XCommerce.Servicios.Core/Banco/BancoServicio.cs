namespace XCommerce.Servicio.Core.Banco
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AccesoDatos;
    using XCommerce.Servicio.Core.Banco.DTO;

    public class BancoServicio : IBancoServicio
    {
        public void Agregar(BancoDTO banco)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var bancoNuevo = new Banco
                {
                    Descripcion = banco.Descripcion,
                };
                context.Bancos.Add(bancoNuevo);
                context.SaveChanges();
            }
        }

        public void Modificar(BancoDTO banco)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                var bancoModificar= context.Bancos.FirstOrDefault(x => x.Id == banco.Id);
                if (bancoModificar == null) throw new Exception("Error");
                bancoModificar.Id = banco.Id;
                bancoModificar.Descripcion = banco.Descripcion;
                context.SaveChanges();
            }
        }

        public IEnumerable<BancoDTO> Obtener(string cadenaBuscar)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Bancos.AsNoTracking().Where(x => x.Descripcion.Contains(cadenaBuscar)).Select(x =>
                    new BancoDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                    }).ToList();
            }
        }

        public BancoDTO ObtenerPorId(long entidadId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                return context.Bancos.AsNoTracking().Select(x => new BancoDTO()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                }).FirstOrDefault(x => x.Id == entidadId);
            }
        }
    }

}
