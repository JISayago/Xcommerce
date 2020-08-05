using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Empleado.DTO;

namespace XCommerce.Servicios.Core.Empleado
{
    public class EmpleadoServicio : IEmpleadoServicio
    {
        public void Eliminar(long empleadoId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var empleadoEliminar = baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                    .FirstOrDefault(x => x.Id == empleadoId);

                if (empleadoEliminar == null || empleadoEliminar.EstaEliminado )  throw new Exception("No se encontro el Empleado");

                empleadoEliminar.EstaEliminado = true;


                baseDatos.SaveChanges();
            }
        }

        public long Insertar(EmpleadoDTO empleadoDto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                if (!ExisteEmpleado(empleadoDto.Email, empleadoDto.Dni))
                {
                    var nuevoEmpleado = new AccesoDatos.Empleado
                    {
                        Legajo = empleadoDto.Legajo,
                        Apellido = empleadoDto.Apellido,
                        Nombre = empleadoDto.Nombre,
                        Dni = empleadoDto.Dni,
                        Telefono = empleadoDto.Telefono,
                        Celular = empleadoDto.Celular,
                        Email = empleadoDto.Email,
                        Cuil = empleadoDto.Cuil,
                        FechaNacimiento = empleadoDto.FechaNacimiento,
                        Foto = empleadoDto.Foto,
                        FechaIngreso = empleadoDto.FechaIngreso,
                        Direccion = new Direccion
                        {
                            Calle = empleadoDto.Calle,
                            Numero = empleadoDto.Numero,
                            Piso = empleadoDto.Piso,
                            Dpto = empleadoDto.Dpto,
                            Casa = empleadoDto.Casa,
                            Lote = empleadoDto.Lote,
                            Barrio = empleadoDto.Barrio,
                            Mza = empleadoDto.Mza,
                            LocalidadId = empleadoDto.LocalidadId
                        }
                    };


                    baseDatos.Personas.Add(nuevoEmpleado);

                    baseDatos.SaveChanges();

                    return nuevoEmpleado.Id;

                }
                else
                {
                    MessageBox.Show("Ya existe un empleado con ese DNI y/o Email.");
                    return -1;
                }
            }
        }

        public bool ExisteEmpleado(string email, string dni)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var empleado = baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                      .AsNoTracking()
                      .Where(x => !x.EstaEliminado)
                      .Include(x => x.Direccion)
                      .Include(x => x.Direccion.Localidad)
                      .Select(x => new EmpleadoDTO
                      {
                          Id = x.Id,
                          Apellido = x.Apellido,
                          Nombre = x.Nombre,
                          Dni = x.Dni,
                          Legajo = x.Legajo,
                          FechaIngreso = x.FechaIngreso,
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

                if (empleado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Modificar(EmpleadoDTO empleadoDto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var empleadoModificar = baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                    .Include(x => x.Direccion)
                    .FirstOrDefault(x => x.Id == empleadoDto.Id);

                if (empleadoModificar == null)
                    throw new Exception("No se encontro el Empleado");

                empleadoModificar.Legajo = empleadoDto.Legajo;
                empleadoModificar.Apellido = empleadoDto.Apellido;
                empleadoModificar.Nombre = empleadoDto.Nombre;
                empleadoModificar.Dni = empleadoDto.Dni;
                empleadoModificar.Telefono = empleadoDto.Telefono;
                empleadoModificar.Celular = empleadoDto.Celular;
                empleadoModificar.Email = empleadoDto.Email;
                empleadoModificar.Cuil = empleadoDto.Cuil;
                empleadoModificar.FechaNacimiento = empleadoDto.FechaNacimiento;
                empleadoModificar.Foto = empleadoDto.Foto;

                empleadoModificar.Direccion.Calle = empleadoDto.Calle;
                empleadoModificar.Direccion.Numero = empleadoDto.Numero;
                empleadoModificar.Direccion.Piso = empleadoDto.Piso;
                empleadoModificar.Direccion.Dpto = empleadoDto.Dpto;
                empleadoModificar.Direccion.Casa = empleadoDto.Casa;
                empleadoModificar.Direccion.Lote = empleadoDto.Lote;
                empleadoModificar.Direccion.Barrio = empleadoDto.Barrio;
                empleadoModificar.Direccion.Mza = empleadoDto.Mza;
                empleadoModificar.Direccion.LocalidadId = empleadoDto.LocalidadId;

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<EmpleadoDTO> ObtenerEmpleado(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                    .AsNoTracking()
                    .Include(x => x.Direccion)
                    .Include(x => x.Direccion.Localidad)
                    .Where(x => !x.EstaEliminado && (x.Nombre.Contains(cadenaBuscar)
                                || x.Apellido.Contains(cadenaBuscar)
                                || x.Dni == (cadenaBuscar)
                                || x.Email == (cadenaBuscar)))
                                
                    .Select(x => new EmpleadoDTO
                    {
                        Id = x.Id,
                        Legajo = x.Legajo,
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

        public IEnumerable<EmpleadoDTO> ObtenerEmpleadoEliminado(string cadenaBuscar)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                return baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                    .AsNoTracking()
                    .Include(x => x.Direccion)
                    .Include(x => x.Direccion.Localidad)
                    .Where(x => x.EstaEliminado && (x.Nombre.Contains(cadenaBuscar)
                                || x.Apellido.Contains(cadenaBuscar)
                                || x.Dni == (cadenaBuscar)
                                || x.Email == (cadenaBuscar)))

                    .Select(x => new EmpleadoDTO
                    {
                        Id = x.Id,
                        Legajo = x.Legajo,
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

        public EmpleadoDTO ObtenerEmpleadoPorId(long empleadoId)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
             {
                return baseDatos.Personas.OfType<AccesoDatos.Empleado>()
                      .AsNoTracking()
                      .Where(x => !x.EstaEliminado)
                      .Include(x => x.Direccion)
                      .Include(x => x.Direccion.Localidad)
                      .Select(x => new EmpleadoDTO
                      {
                          Id = x.Id,
                          Legajo = x.Legajo,
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
                      ).FirstOrDefault(x => x.Id == empleadoId);


            }
        }

        public int ObtenerSiguienteLegajo()
        {
            using(var baseDatos = new ModeloXCommerceContainer())
            {
                if (baseDatos.Personas.OfType<AccesoDatos.Empleado>().Any())
                {
                    return baseDatos.Personas.OfType<AccesoDatos.Empleado>().Max(x => x.Legajo) + 1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
