using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.DetalleCaja.DTO;

namespace XCommerce.Servicios.Core.DetalleCaja
{
    public interface IDetalleCajaServicio
    {
        void Generar(DetalleCajaDTO dto);
    }
}
