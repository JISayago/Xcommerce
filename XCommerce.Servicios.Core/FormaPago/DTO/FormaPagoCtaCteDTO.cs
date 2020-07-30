using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.FormaPago.DTO
{
    public class FormaPagoCtaCteDTO : FormaPagoDTO
    {
        public long ClienteId { get; set; }
    }
}
