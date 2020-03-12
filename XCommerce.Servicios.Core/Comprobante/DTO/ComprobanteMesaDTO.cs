using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XCommerce.Servicios.Core.Comprobante.Descuento;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class ComprobanteMesaDTO
    {
        public ComprobanteMesaDTO()
        {
            if (Items == null)
            {
                Items = new List<DetalleComprobanteSalonDTO>();       
            }        
        }

        public long MesaId { get; set; }

        public long ComprobanteId { get; set; }

        public DateTime Fecha { get; set; }

        public long? MozoId { get; set; }

        public int Legajo { get; set; }

        public string ApellidoMozo { get;set; }

        public string NombreMozo { get; set; }

        public string ApyNomMozo => $"{ApellidoMozo} {NombreMozo}";

        public long UsuarioId { get; set; }

        public long ClienteId { get; set; }

        public decimal SubTotal => Items.Sum(x => x.SubtotalLinea);

        public decimal Descuento { get; set; }

        public decimal Total =>SubTotal-CalcularDescuento(Descuento,SubTotal);

        public List<DetalleComprobanteSalonDTO> Items { get; set; }
    }
}
