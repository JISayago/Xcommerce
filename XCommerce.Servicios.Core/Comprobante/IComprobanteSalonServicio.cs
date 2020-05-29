using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Producto.DTO;

namespace XCommerce.Servicios.Core.Comprobante
{
    public interface IComprobanteSalonServicio
    {
        long GenerarComprobanteSalon(long mesaId, long usuarioId, int comensales, long? mozoId = null);

        void FacturarComprobanteSalon(long mesaId);

        ComprobanteMesaDTO Obtener(long mesaId);

        ComprobanteMesaDTO ObtenerPorId(long mesaId,long comproId);

        void CambiarEstadoComprobante(long mesaId ,long comprobanteId);
        void AgregarItems(long mesaId,decimal cantidad, ProductoMesaDTO dto);  
    }
}
