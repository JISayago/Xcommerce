using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Movimiento
{
    public class MovimientoServicio : IMovimientoServicio
    {
        public void GenerarMovimiento(long idCaja, long idComprobante, TipoMovimiento tipoMovimiento, long idUsuario,decimal monto, string descripcion)
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
    }
}
