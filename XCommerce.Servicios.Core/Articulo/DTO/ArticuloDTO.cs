using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Articulo.DTO
{
    public class ArticuloDTO 
    {
        public long Id { get; set; }
        public bool EstaEliminado { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
        public byte[] Foto { get; set; }
        public bool ActivarLimiteVenta { get; set; }
        public decimal LimiteVenta { get; set; }
        public bool PermiteStockNegativo { get; set; }
        public bool EstaDiscontinuado { get; set; }
        public decimal StockMaximo { get; set; }
        public decimal StockMinimo { get; set; }
        public bool DescuentaStock { get; set; }
        public long MarcaId { get; set; }
        public long RubroId { get; set; }
        public decimal Stock { get; set; }

        //Precio
        public long PrecioId { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal PrecioPublicoRentabilidad { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool ActivarHoraVenta { get; set; }
        public DateTime HoraVenta { get; set; }
        public bool EstaEliminadoPrecio { get; set; }
        public string EstaEliminadoPrecioStr => EstaEliminado ? "SI" : "NO";
       
        //Lista Precio
        public long ListaPrecioId { get; set; }
        public string DescripcionListaPrecio { get; set; }
        public decimal Rentabilidad { get; set; }
    }
}
