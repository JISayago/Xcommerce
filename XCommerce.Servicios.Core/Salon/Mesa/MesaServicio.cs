using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Salon.Mesa.DTO;

namespace XCommerce.Servicios.Core.Salon.Mesa
{
    public class MesaServicio : IMesaServicio
    {
        public void Eliminar(long mesaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var mesaEliminar = baseDatos.Mesas.FirstOrDefault(x => x.Id == mesaId);

                if (mesaEliminar == null) throw new Exception("Ocurrió un error al obtener la Mesa para Eliminar");

                mesaEliminar.EstaEliminado = true;

                baseDatos.SaveChanges();
            }
        }

        public bool ExisteNumeroMesa(int numeroMesa)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var mesa = baseDatos.Mesas.FirstOrDefault(x => x.Numero == numeroMesa);
                if (mesa == null)
                {
                    return false;
                }
                   return true;
            }
        }

        public long Insertar(MesaDTO mesaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var mesaNueva = new AccesoDatos.Mesa
                {
                    Numero = mesaDTO.Numero,
                    Descripcion = mesaDTO.Descripcion,
                    EstaEliminado = mesaDTO.EstaEliminado,
                    SalonId = mesaDTO.SalonId,
                    EstadoMesa = mesaDTO.estadoMesa
                };

                baseDatos.Mesas.Add(mesaNueva);

                baseDatos.SaveChanges();

                return mesaNueva.Id;

            }
        }

        public void Modificar(MesaDTO mesaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var mesaModificar = baseDatos.Mesas.FirstOrDefault(x => x.Id == mesaDTO.Id);

                if (mesaModificar == null) throw new Exception("Ocurrió un error al obtener la Mesa para Modificarla");

                mesaModificar.Numero = mesaDTO.Numero;
                mesaModificar.Descripcion = mesaDTO.Descripcion;
                mesaModificar.EstaEliminado = mesaDTO.EstaEliminado;
                mesaModificar.SalonId = mesaDTO.SalonId;
                     mesaModificar.EstadoMesa = mesaDTO.estadoMesa;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<MesaDTO> ObtenerMesa(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Mesas
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado)
                    .Include(x => x.Salon)
                    .Select(x => new MesaDTO
                    {
                        Id = x.Id,
                        Numero = x.Numero,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        SalonId = x.SalonId,
                        estadoMesa = x.EstadoMesa,
                        SalonDescripcion = x.Salon.Descripcion
                    }).ToList();
            }
        }

        public IEnumerable<MesaDTO> ObtenerMesaEliminada(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Mesas
                    .AsNoTracking()                    
                    .Where(x => x.EstaEliminado)
                    .Include(x => x.Salon)
                    .Select(x => new MesaDTO
                    {

                        Id = x.Id,
                        Numero = x.Numero,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        SalonId = x.SalonId,
                        estadoMesa = x.EstadoMesa,
                        SalonDescripcion = x.Salon.Descripcion
                    }).ToList();
            }
        }

        public IEnumerable<MesaDTO> ObtenerMesaPorSalon(long salonId, string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Mesas
                    .AsNoTracking()
                    .Where(x => !x.EstaEliminado && (x.SalonId == salonId && x.Descripcion.Contains(cadenaBuscar)))
                    .Include(x => x.Salon)
                    .Select(x => new MesaDTO
                    {
                        Id = x.Id,
                        Numero = x.Numero,
                        Descripcion = x.Descripcion,
                        EstaEliminado = x.EstaEliminado,
                        SalonId = x.SalonId,
                        estadoMesa = x.EstadoMesa,
                        SalonDescripcion = x.Salon.Descripcion
                    }).ToList();
            }
        }

        public MesaDTO ObtenerPorId(long mesaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Mesas
                    .AsNoTracking()
                    .Include(x => x.Salon)
                    .Select(x => new MesaDTO
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        SalonId = x.SalonId,
                        Numero = x.Numero,
                        SalonDescripcion = x.Salon.Descripcion,
                        EstaEliminado = x.EstaEliminado

                    }).FirstOrDefault(x => !x.EstaEliminado && x.Id == mesaId);
            }
        }
    }

}

