using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.FormaPago.DTO;

namespace XCommerce.Servicios.Core.FormaPago
{
    public interface IFormaPagoServicio
    {
        void Generar(FormaPagoDTO dto);
    }
}
