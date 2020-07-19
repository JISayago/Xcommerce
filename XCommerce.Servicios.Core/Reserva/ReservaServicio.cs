using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Empleado;
using XCommerce.Servicios.Core.Reserva.DTO;
using XCommerce.Servicios.Core.Salon.Mesa;

namespace XCommerce.Servicios.Core.Reserva
{
    public class ReservaServicio : IReservaServicio
    {
        public void Eliminar(long reservaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var reservaEliminar = baseDatos.Reservas.FirstOrDefault(x => x.Id == reservaId);

                if (reservaEliminar == null) throw new Exception("Ocurrió un error al obtener la reserva para Eliminarla");

                baseDatos.Reservas.Remove(reservaEliminar);

                baseDatos.SaveChanges();
            }
        }

        public void GenerarReserva(ReservaDTO reservaDTO)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var reservaNueva = new AccesoDatos.Reserva
                {
                    Fecha = reservaDTO.FechaReserva,
                    Senia = reservaDTO.Senia,
                    EstadoReserva = reservaDTO.EstadoReserva,
                    MesaId = reservaDTO.MesaId,                   
                    UsuarioId = reservaDTO.UsuarioId,
                    ClienteId = reservaDTO.ClienteId

                };

                baseDatos.Reservas.Add(reservaNueva);

                baseDatos.SaveChanges();

               
            }
        }

        public void Modificar(ReservaDTO reservadto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var reservamodificar = baseDatos.Reservas
                    .FirstOrDefault(x => x.Id == reservadto.Id);

                if (reservamodificar == null)
                    throw new Exception("No se encontro la reserva");

                reservamodificar.Id = reservadto.Id;
                reservamodificar.MesaId = reservadto.MesaId;
                reservamodificar.ClienteId = reservadto.ClienteId;
                reservamodificar.UsuarioId = reservadto.UsuarioId;
                reservamodificar.Senia = reservadto.Senia;
                reservamodificar.Fecha = reservadto.FechaReserva;
                reservamodificar.EstadoReserva = reservadto.EstadoReserva;

                baseDatos.SaveChanges();
            }
        }

        public ReservaDTO ObtenerReservaPorId(long reservaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Reservas                   
                      .AsNoTracking()
                      .Select(x => new ReservaDTO
                      {
                          Id = x.Id,
                          FechaReserva = x.Fecha,
                          MesaId = x.MesaId,
                          MesaNumero = x.Mesa.Numero,
                          ClienteId = x.ClienteId,
                          ClienteApyNom = x.Cliente.Apellido,
                          Senia = x.Senia,
                          EstadoReserva = x.EstadoReserva,
                          UsuarioId = x.UsuarioId,
                          Usuario = x.Usuario.Nombre
                          
                      }
                      ).FirstOrDefault(x => x.Id == reservaId);
            }
        }

        public IEnumerable<ReservaDTO> ObtenerReservas(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                
                return baseDatos.Reservas
                    .AsNoTracking()
                    .Where(x=> x.Cliente.Nombre.Contains(cadenaBuscar) || x.Cliente.Apellido.Contains(cadenaBuscar))
                    .Select(x => new ReservaDTO
                    {
                        Id = x.Id,
                        FechaReserva = x.Fecha,
                        Senia = x.Senia,
                        MesaId = x.MesaId,
                        MesaNumero = -1,
                        ClienteId = x.ClienteId,
                        ClienteApyNom = " ",
                        UsuarioId = x.UsuarioId,
                        Usuario = " "

                    }).OrderBy(x => x.FechaReserva).ToList();
            }
        }


        public IEnumerable<ReservaDTO> ObtenerReservasPorMesaId(long mesaId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Reservas
                                  .AsNoTracking()
                                  .Where(x => x.MesaId == mesaId)
                                  .Select(x => new ReservaDTO
                                  {
                                      Id = x.Id,
                                      FechaReserva = x.Fecha,
                                      Senia = x.Senia,
                                      MesaId = x.MesaId,
                                      MesaNumero = -1,
                                      ClienteId = x.ClienteId,
                                      ClienteApyNom = " ",
                                      UsuarioId = x.UsuarioId,
                                      Usuario = " "

                                  }).OrderBy(x => x.FechaReserva).ToList();
            }
        }
    }
}
