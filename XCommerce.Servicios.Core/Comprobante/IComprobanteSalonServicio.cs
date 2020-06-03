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

        void FacturarComprobanteSalon(long mesaId, ComprobanteMesaDTO comprobanteMesa);

        ComprobanteMesaDTO Obtener(long mesaId);        

        void AgregarItems(long mesaId,decimal cantidad, ProductoMesaDTO dto);

        void QuitarItems(long detalleID);
    }
}
