using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Cliente.DTO;
using static Presentacion.Helpers.ImagenDb;

namespace XCommerce.Servicios.Core.Cliente
{
    public class ClienteServicio : IClienteServicio
    {
        public void Eliminar(long clienteId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var clienteEliminar = baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .FirstOrDefault(x => x.Id == clienteId);

                if (clienteEliminar == null || clienteEliminar.EstaEliminado) throw new Exception("No se encontro el Cliente");

                clienteEliminar.EstaEliminado = true;


                baseDatos.SaveChanges();
            }
        }

        public long Insertar(ClienteDTO clienteDto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                if (!ExisteCliente(clienteDto.Email, clienteDto.Dni))
                {

                    var nuevoCliente = new AccesoDatos.Cliente
                    {
                        MontoMaximoCtaCte = clienteDto.MontoMaximoCtaCte,
                        Apellido = clienteDto.Apellido,
                        Nombre = clienteDto.Nombre,
                        Dni = clienteDto.Dni,
                        Telefono = clienteDto.Telefono,
                        Celular = clienteDto.Celular,
                        Email = clienteDto.Email,
                        Cuil = clienteDto.Cuil,
                        FechaNacimiento = clienteDto.FechaNacimiento,
                        Foto = clienteDto.Foto,
                        Direccion = new Direccion
                        {
                            Calle = clienteDto.Calle,
                            Numero = clienteDto.Numero,
                            Piso = clienteDto.Piso,
                            Dpto = clienteDto.Dpto,
                            Casa = clienteDto.Casa,
                            Lote = clienteDto.Lote,
                            Barrio = clienteDto.Barrio,
                            Mza = clienteDto.Mza,
                            LocalidadId = clienteDto.LocalidadId
                        }
                    };


                    baseDatos.Personas.Add(nuevoCliente);

                    baseDatos.SaveChanges();

                    return nuevoCliente.Id;
                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI y/o Email.");
                    return -1;
                }
            }
        }

        public bool DescontarDeCuenta(long clienteId, decimal monto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var clienteModificar = baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .Include(x => x.Direccion)
                    .FirstOrDefault(x => x.Id == clienteId);

                if (clienteModificar == null)
                    throw new Exception("No se encontro el Cliente");

               clienteModificar.MontoMaximoCtaCte -= monto;
                if (clienteModificar.MontoMaximoCtaCte < 0)
                    return false;

                baseDatos.SaveChanges();
                return true;
            }
        }
        public void Modificar(ClienteDTO clienteDto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var clienteModificar = baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .Include(x => x.Direccion)
                    .FirstOrDefault(x => x.Id == clienteDto.Id);

                if (clienteModificar == null)
                    throw new Exception("No se encontro el Cliente");

                clienteModificar.MontoMaximoCtaCte = clienteDto.MontoMaximoCtaCte;
                clienteModificar.Apellido = clienteDto.Apellido;
                clienteModificar.Nombre = clienteDto.Nombre;
                clienteModificar.Dni = clienteDto.Dni;
                clienteModificar.Telefono = clienteDto.Telefono;
                clienteModificar.Celular = clienteDto.Celular;
                clienteModificar.Email = clienteDto.Email;
                clienteModificar.Cuil = clienteDto.Cuil;
                clienteModificar.FechaNacimiento = clienteDto.FechaNacimiento;
                clienteModificar.Foto = clienteDto.Foto;

                clienteModificar.Direccion.Calle = clienteDto.Calle;
                clienteModificar.Direccion.Numero = clienteDto.Numero;
                clienteModificar.Direccion.Piso = clienteDto.Piso;
                clienteModificar.Direccion.Dpto = clienteDto.Dpto;
                clienteModificar.Direccion.Casa = clienteDto.Casa;
                clienteModificar.Direccion.Lote = clienteDto.Lote;
                clienteModificar.Direccion.Barrio = clienteDto.Barrio;
                clienteModificar.Direccion.Mza = clienteDto.Mza;
                clienteModificar.Direccion.LocalidadId = clienteDto.LocalidadId;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<ClienteDTO> ObtenerCliente(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .AsNoTracking()
                    .Include(x => x.Direccion)
                    .Include(x => x.Direccion.Localidad)
                    .Where(x => !x.EstaEliminado && (x.Nombre.Contains(cadenaBuscar)
                                || x.Apellido.Contains(cadenaBuscar)
                                || x.Dni == (cadenaBuscar)
                                || x.Email == (cadenaBuscar)))

                    .Select(x => new ClienteDTO
                    {
                        Id = x.Id,
                        MontoMaximoCtaCte = x.MontoMaximoCtaCte,
                        Apellido = x.Apellido,
                        Nombre = x.Nombre,
                        Dni = x.Dni,
                        Telefono = x.Telefono,
                        Celular = x.Celular,
                        Email = x.Email,
                        Cuil = x.Cuil,
                        FechaNacimiento = x.FechaNacimiento,
                        Foto = x.Foto,
                        EstaEliminado = x.EstaEliminado,
                        Calle = x.Direccion.Calle,
                        Numero = x.Direccion.Numero,
                        Piso = x.Direccion.Piso,
                        Dpto = x.Direccion.Dpto,
                        Casa = x.Direccion.Casa,
                        Lote = x.Direccion.Lote,
                        Barrio = x.Direccion.Barrio,
                        Mza = x.Direccion.Mza,
                        LocalidadId = x.Direccion.LocalidadId,
                        ProvinciaId = x.Direccion.Localidad.ProvinciaId
                    }).ToList();
            }
        }

        public IEnumerable<ClienteDTO> ObtenerClienteEliminado(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .AsNoTracking()
                    .Include(x => x.Direccion)
                    .Include(x => x.Direccion.Localidad)
                    .Where(x => x.EstaEliminado && (x.Nombre.Contains(cadenaBuscar)
                                || x.Apellido.Contains(cadenaBuscar)
                                || x.Dni == (cadenaBuscar)
                                || x.Email == (cadenaBuscar)))

                    .Select(x => new ClienteDTO
                    {
                        Id = x.Id,
                        MontoMaximoCtaCte = x.MontoMaximoCtaCte,
                        Apellido = x.Apellido,
                        Nombre = x.Nombre,
                        Dni = x.Dni,
                        Telefono = x.Telefono,
                        Celular = x.Celular,
                        Email = x.Email,
                        Cuil = x.Cuil,
                        FechaNacimiento = x.FechaNacimiento,
                        Foto = x.Foto,
                        EstaEliminado = x.EstaEliminado,
                        Calle = x.Direccion.Calle,
                        Numero = x.Direccion.Numero,
                        Piso = x.Direccion.Piso,
                        Dpto = x.Direccion.Dpto,
                        Casa = x.Direccion.Casa,
                        Lote = x.Direccion.Lote,
                        Barrio = x.Direccion.Barrio,
                        Mza = x.Direccion.Mza,
                        LocalidadId = x.Direccion.LocalidadId,
                        ProvinciaId = x.Direccion.Localidad.ProvinciaId
                    }).ToList();
            }
        }

        public ClienteDTO ObtenerClientePorId(long clienteId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                      .AsNoTracking()
                      .Where(x => !x.EstaEliminado)
                      .Include(x => x.Direccion)
                      .Include(x => x.Direccion.Localidad)
                      .Select(x => new ClienteDTO
                      {
                          Id = x.Id,
                          MontoMaximoCtaCte = x.MontoMaximoCtaCte,
                          Apellido = x.Apellido,
                          Nombre = x.Nombre,
                          Dni = x.Dni,
                          Telefono = x.Telefono,
                          Celular = x.Celular,
                          Email = x.Email,
                          Cuil = x.Cuil,
                          FechaNacimiento = x.FechaNacimiento,
                          Foto = x.Foto,
                          EstaEliminado = x.EstaEliminado,
                          Calle = x.Direccion.Calle,
                          Numero = x.Direccion.Numero,
                          Piso = x.Direccion.Piso,
                          Dpto = x.Direccion.Dpto,
                          Casa = x.Direccion.Casa,
                          Lote = x.Direccion.Lote,
                          Barrio = x.Direccion.Barrio,
                          Mza = x.Direccion.Mza,
                          LocalidadId = x.Direccion.LocalidadId,
                          ProvinciaId = x.Direccion.Localidad.ProvinciaId
                      }
                      ).FirstOrDefault(x => x.Id == clienteId);
            }
        }

        public bool ExisteCliente(string email,string dni)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var cliente = baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                      .AsNoTracking()
                      .Where(x => !x.EstaEliminado)
                      .Include(x => x.Direccion)
                      .Include(x => x.Direccion.Localidad)
                      .Select(x => new ClienteDTO
                      {
                          Id = x.Id,
                          MontoMaximoCtaCte = x.MontoMaximoCtaCte,
                          Apellido = x.Apellido,
                          Nombre = x.Nombre,
                          Dni = x.Dni,
                          Telefono = x.Telefono,
                          Celular = x.Celular,
                          Email = x.Email,
                          Cuil = x.Cuil,
                          FechaNacimiento = x.FechaNacimiento,
                          Foto = x.Foto,
                          EstaEliminado = x.EstaEliminado,
                          Calle = x.Direccion.Calle,
                          Numero = x.Direccion.Numero,
                          Piso = x.Direccion.Piso,
                          Dpto = x.Direccion.Dpto,
                          Casa = x.Direccion.Casa,
                          Lote = x.Direccion.Lote,
                          Barrio = x.Direccion.Barrio,
                          Mza = x.Direccion.Mza,
                          LocalidadId = x.Direccion.LocalidadId,
                          ProvinciaId = x.Direccion.Localidad.ProvinciaId
                      }
                      ).FirstOrDefault(x => x.Email == email || x.Dni == dni);

                if(cliente != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public ClienteDTO ObtenerClientePorDni(string dni)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                      .AsNoTracking()
                      .Where(x => !x.EstaEliminado)
                      .Include(x => x.Direccion)
                      .Include(x => x.Direccion.Localidad)
                      .Select(x => new ClienteDTO
                      {
                          Id = x.Id,
                          MontoMaximoCtaCte = x.MontoMaximoCtaCte,
                          Apellido = x.Apellido,
                          Nombre = x.Nombre,
                          Dni = x.Dni,
                          Telefono = x.Telefono,
                          Celular = x.Celular,
                          Email = x.Email,
                          Cuil = x.Cuil,
                          FechaNacimiento = x.FechaNacimiento,
                          Foto = x.Foto,
                          EstaEliminado = x.EstaEliminado,
                          Calle = x.Direccion.Calle,
                          Numero = x.Direccion.Numero,
                          Piso = x.Direccion.Piso,
                          Dpto = x.Direccion.Dpto,
                          Casa = x.Direccion.Casa,
                          Lote = x.Direccion.Lote,
                          Barrio = x.Direccion.Barrio,
                          Mza = x.Direccion.Mza,
                          LocalidadId = x.Direccion.LocalidadId,
                          ProvinciaId = x.Direccion.Localidad.ProvinciaId
                      }
                      ).FirstOrDefault(x => x.Dni == dni);
            }
        }

        public void AgregarSaldoCtaCte(long clienteId, decimal monto)
        {
           using(var baseDatos = new ModeloXCommerceContainer())
           {
                var clienteCtaCte = baseDatos.Personas.OfType<AccesoDatos.Cliente>()
                    .Include(x => x.Direccion)
                    .FirstOrDefault(x => x.Id == clienteId);

                if (clienteCtaCte == null)
                    throw new Exception("No se encontro el Cliente");

                clienteCtaCte.MontoMaximoCtaCte += monto;               

                baseDatos.SaveChanges();
                
            }
        }

        public void InsertarConsumidorFinal()
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {

                var ConsumidorFinal = ObtenerClientePorDni("99999999");

                if (ConsumidorFinal == null)
                {

                    var nuevoCliente = new AccesoDatos.Cliente
                    {
                        MontoMaximoCtaCte = 0m,
                        Apellido = "Consumidor",
                        Nombre = "Final",
                        Dni = "99999999",
                        Telefono = "999999",
                        Celular = "999999",
                        Email = "ConsumidorFinalisimo@gmail.com",
                        Cuil = "99999999999",
                        Foto = Convertir_Imagen_Bytes(Presentacion.Constantes.Imagenes.ImagenUsuario),
                        FechaNacimiento = DateTime.Now,
                        Direccion = new Direccion
                        {
                            Calle = "c",
                            Numero = 999,
                            Piso = "c",
                            Dpto = "c",
                            Casa = "c",
                            Lote = "c",
                            Barrio = "Del Consumidor",
                            Mza = "c",
                            LocalidadId = 1
                        }
                    };

                    baseDatos.Personas.Add(nuevoCliente);

                    baseDatos.SaveChanges();
                    MessageBox.Show("se le agrego Consumidor Final correctamente");

                }

            }
        }
    }
}
