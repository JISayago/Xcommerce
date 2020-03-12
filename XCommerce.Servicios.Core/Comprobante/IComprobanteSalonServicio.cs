using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Comprobante.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public interface IComprobanteSalonServicio
    {
        void GenerarComprobanteSalon(long mesaId,long usuarioId, int comensales, long? mozoId = null);

        ComprobanteMesaDTO Obtener(long mesaId);
    }
}
