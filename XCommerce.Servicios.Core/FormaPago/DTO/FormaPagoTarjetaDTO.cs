using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.FormaPago.DTO
{
    public class FormaPagoTarjetaDTO : FormaPagoDTO
    {
        public long PlanTarjetaId { get; set; }
        public string Cupon { get; set; }
        public string Numero { get; set; }
        public string NumeroTarjeta { get; set; }
    }
}
