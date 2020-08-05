using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.FormaPago.DTO
{
    public class FormaPagoDTO
    {
        public long Id { get; set; }
        public long ComprobanteId { get; set; }
        public TipoFormaPago TipoFormaPago { get; set; }
        public decimal Monto { get; set; }
    }
}
