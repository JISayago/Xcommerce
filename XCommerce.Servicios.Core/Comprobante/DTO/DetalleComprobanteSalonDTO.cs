using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class DetalleComprobanteSalonDTO
    {
        public long DetalleId { get; set; }

        public long ComprobanteId { get; set; }

        public long ProductoId { get; set; }

        public string CodigoProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal CantidadProducto { get; set; }    

        public decimal SubtotalLinea => PrecioUnitario * CantidadProducto;

       
    }
}
