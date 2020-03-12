using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Comprobante
{
    public static class Descuento
    {
        public static decimal CalcularDescuento(decimal porcentaje, decimal valor)
        {
            return (valor * (porcentaje / 100m));
        }

    }
}
