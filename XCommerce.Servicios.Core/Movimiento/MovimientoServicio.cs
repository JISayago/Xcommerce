using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Movimiento.DTO;

namespace XCommerce.Servicios.Core.Movimiento
{
    public class MovimientoServicio : IMovimientoServicio
    {
        public void GenerarMovimiento(long idCaja, long idComprobante, TipoMovimiento tipoMovimiento, long idUsuario, decimal monto, string descripcion)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var nuevoMovimiento = new AccesoDatos.Movimiento
                {
                    CajaId = idCaja,
                    ComprobanteId = idComprobante,
                    TipoMovimento = tipoMovimiento,
                    UsuarioId = idUsuario,
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Descripcion = descripcion
                };

                baseDatos.Movimientos.Add(nuevoMovimiento);

                baseDatos.SaveChanges();
            }
        }

        public void GenerarMovimiento(MovimientoDTO dto)
        {
            using (var baseDatos = new ModeloXCommerceContainer())
            {
                var nuevoMovimiento = new AccesoDatos.Movimiento
                {
                    CajaId = dto.CajaID,
                    ComprobanteId = dto.ComprobanteID,
                    TipoMovimento = dto.TipoMovimiento,
                    UsuarioId = dto.UsuarioID,
                    Monto = dto.Monto,
                    Fecha = dto.Fecha,
                    Descripcion = dto.Descripcion
                };

                baseDatos.Movimientos.Add(nuevoMovimiento);

                baseDatos.SaveChanges();
            }
        }

        public IEnumerable<MovimientoDTO> Obtener(DateTime desde, DateTime hasta, TipoMovimiento? tipo, long? usuarioId, long? cajaId)
        {
            using (var context = new ModeloXCommerceContainer())
            {
                IQueryable<AccesoDatos.Movimiento> q = context.Movimientos;

                q = q.Where(x => x.Fecha >= desde && x.Fecha <= hasta);
                if (tipo != null)      q = q.Where(x => x.TipoMovimento == tipo);
                if (usuarioId != null) q = q.Where(x => x.UsuarioId == usuarioId);
                if (cajaId != null)    q = q.Where(x => x.CajaId == cajaId);
                
                return q.Select(x => new MovimientoDTO
                {
                    Id = x.Id,
                    CajaID = x.CajaId,
                    ComprobanteID = x.ComprobanteId,
                    TipoMovimiento = x.TipoMovimento,
                    UsuarioID = x.UsuarioId,
                    Monto = x.Monto,
                    Fecha = x.Fecha,
                    Descripcion = x.Descripcion
                }).ToList();

            }
        }
    }
}