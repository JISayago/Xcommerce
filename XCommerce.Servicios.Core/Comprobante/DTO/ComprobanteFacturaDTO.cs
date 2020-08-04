using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class ComprobanteFacturaDTO
    {
        public ComprobanteFacturaDTO()
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

        public int Numero => 100_000_000 + (int)Id;

        public TipoComprobante Tipo { get; set; }

        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string FormaPagoStr { get; set; }
    }
}

