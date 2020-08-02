using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class ComprobanteCompraDTO
    {
        public ComprobanteCompraDTO()
        {
            if (Items == null)
            {
                Items = new List<DetalleComprobanteDTO>();
            }
        }

        public long ProveedorId { get; set; }
        
        public long ComprobanteId { get; set; }

        public DateTime Fecha { get; set; }

        public long UsuarioId { get; set; }

        public long ClienteId { get; set; }

        public decimal SubTotal => Items.Sum(x => x.SubtotalLinea);

        public decimal Descuento { get; set; }

        public decimal Total { get; set; }

        public List<DetalleComprobanteDTO> Items { get; set; }
    }
}
