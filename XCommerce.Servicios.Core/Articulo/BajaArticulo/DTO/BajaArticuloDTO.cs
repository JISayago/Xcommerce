using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Articulo.BajaArticulo.DTO
{
    public class BajaArticuloDTO
    {
        public long Id { get; set;}

        public DateTime Fecha { get; set;}

        public string ArticuloDescrip { get; set; }

        public decimal Cantidad { get; set;}

        public string Observacion { get; set;}

        public long MotivoBajaId { get; set; }

        public long ArticuloId { get; set; }

        public string MotivoDescrip { get; set; }

        public decimal? StockModificado { get; set; }
        
    }
}
