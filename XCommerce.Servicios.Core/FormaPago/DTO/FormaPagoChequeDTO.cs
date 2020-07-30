using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.FormaPago.DTO
{
    public class FormaPagoChequeDTO : FormaPagoDTO
    {
        public long BancoId { get; set; }
        public string Numero { get; set; }
        public string EnteEmisor { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Dias { get; set; }
    }
}
