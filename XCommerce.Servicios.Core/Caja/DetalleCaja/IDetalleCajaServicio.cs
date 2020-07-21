using System.Collections.Generic;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Caja.DetalleCaja.DTO;

namespace XCommerce.Servicios.Core.Caja.DetalleCaja
{
    public interface IDetalleCajaServicio
    {
        void GenerarDetalleCaja(long idCaja,decimal monto,TipoPago tipoPago);
        IEnumerable<DetalleCajaDTO> Obtener(long? cajaId, TipoPago? tipo);
    }
}
