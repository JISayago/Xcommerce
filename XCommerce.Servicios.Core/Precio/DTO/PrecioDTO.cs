using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Precio.DTO
{
    public class PrecioDTO
    {
        public long Id { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string DescripcionArticulo { get; set; }
        public string NombreLista { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioPublico { get; set; }
        public long ListaPrecioId { get; set; }
        public long ArticuloId { get; set; }
        public bool ActivarHoraVenta { get; set; }
        public DateTime HoraVenta { get; set; }
    }
}
