namespace XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario
{
    using global::XCommerce.AccesoDatos;
    using global::XCommerce.Servicios.Seguridad.XCommerce.Servicios.Seguridad.Usuario.DTO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Presentacion.Helpers.CadenaCaracteres;

    public class UsuarioServicio : IUsuarioServicio
    {
        public void CambiarEstado(string NombreUsuario, bool Estado)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                var usuario = basedatos.Usuarios.FirstOrDefault(x => x.Nombre == NombreUsuario);

                if (usuario == null) throw new Exception("No se encontró al usuario: " + usuario);

                usuario.EstaBloqueado = Estado;

                basedatos.SaveChanges();
            }
        }

        public void Crear(long personaId, string apellido, string nombre)
        {
            var nombreUsuario = CrearNombreUsuaurio(apellido, nombre);

            using (var basedatos = new ModeloXCommerceContainer())
            {
                basedatos.Usuarios.Add(new Usuario
                {
                    PersonaId = personaId,
                    EstaBloqueado = false,
                    Nombre = nombreUsuario.ToLower(),
                    Password = Encriptar("Pa$$word")
                });
                basedatos.SaveChanges();
            }
        }

      

        private string CrearNombreUsuaurio(string apellido, string nombre)
        {
            int contadorLetras = 1;
            int digito = 1;
            var usuarioNuevo = $"{nombre.Trim().Substring(0, contadorLetras)}{apellido.Trim()}";

            using (var baseDatos = new ModeloXCommerceContainer())
            {
                while (baseDatos.Usuarios.Any(x => x.Nombre == usuarioNuevo))
                {
                    if (contadorLetras <= nombre.Trim().Length)
                    {
                        contadorLetras++;
                        usuarioNuevo = $"{nombre.Trim().Substring(0, contadorLetras)}{apellido.Trim()}";
                    }
                    else
                    {
                        usuarioNuevo = $"{nombre.Trim().Substring(0, contadorLetras)}{apellido.Trim()}{digito}";
                        digito++;
                    }
                }
            }
            return usuarioNuevo;
        }

        public IEnumerable<DTO.UsuarioDTO> Obtener(string cadenaBuscar)
        {
            using (var basedatos = new ModeloXCommerceContainer())
            {
                return basedatos.Personas
                    .AsNoTracking()
                    .Where(x=>!x.EstaEliminado && (x.Apellido.Contains(cadenaBuscar) || x.Nombre.Contains(cadenaBuscar)))
                    .Select(x => new UsuarioDTO
                    {
                        PersonaID = x.Id,
                        ApellidoPersona = x.Apellido,
                        NombrePersona = x.Nombre,
                        Nombre = x.Usuarios.Any() ? x.Usuarios.FirstOrDefault().Nombre : "No Asignado..",
                        Id =x.Usuarios.Any() ? x.Usuarios.FirstOrDefault().Id : 0,
                        EstaBloqueado = x.Usuarios.Any() ? x.Usuarios.FirstOrDefault().EstaBloqueado : false,
                    }).ToList();
            }
        }
    }
}
