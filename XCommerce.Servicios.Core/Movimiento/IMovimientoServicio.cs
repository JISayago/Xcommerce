using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Movimiento.DTO;


namespace XCommerce.Servicios.Core.Movimiento
{
    public interface IMovimientoServicio
    {
        void GenerarMovimiento(long idCaja, long idComprobante, TipoMovimiento tipoMovimiento, long idUsuario, decimal monto, string descripcion);

        void GenerarMovimiento(MovimientoDTO dto);
    }
}
