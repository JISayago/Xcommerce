using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Comprobante.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public interface IComprobanteServicio
    {
        long Generar(ComprobanteDTO dto);
        long GenerarComprobanteDelivery(ComprobanteDTO dto);
        T_ComprobanteDTO ObtenerPorId(long comprobanteId);
    }
}
