using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Precio.DTO;

namespace XCommerce.Servicios.Core.Precio
{
    public interface IPrecioServicio
    {
        void Insertar(PrecioDTO precioNuevo);
    }
}
