using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Empleado.Mozo.DTO;

namespace XCommerce.Servicios.Core.Empleado.Mozo
{
    public interface IMozoServicio
    {
        MozoDTO ObtenerMozoPorLegajo(int legajo);

        void asignarMozoAMesa(long mesaId, MozoDTO mozo);
    }
}
