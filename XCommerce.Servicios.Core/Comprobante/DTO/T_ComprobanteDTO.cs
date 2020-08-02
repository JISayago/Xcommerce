using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class T_ComprobanteDTO
    {
        public T_ComprobanteDTO()
        {
            if (Items == null)
            {
                Items = new List<DetalleComprobanteDTO>();
            }
        }

        public long Id { get; set; }

        public DateTime Fecha { get; set; }

        public long UsuarioId { get; set; }

        public long ClienteId { get; set; }

        public decimal SubTotal => Items.Sum(x => x.SubtotalLinea);

        public decimal Descuento { get; set; }

        public decimal Total => SubTotal - (SubTotal * (Descuento / 100m));
       
        public List<DetalleComprobanteDTO> Items { get; set; }

        public int Numero { get; set; }

        public TipoComprobante Tipo { get; set; }
    }
}

