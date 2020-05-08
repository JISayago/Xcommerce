using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Empleado.DTO;

namespace XCommerce.Servicios.Core.Empleado
{
   public interface IEmpleadoServicio
   {
        IEnumerable<EmpleadoDTO> ObtenerEmpleado(string cadenaBuscar);

        IEnumerable<EmpleadoDTO> ObtenerEmpleadoEliminado(string cadenaBuscar);

        EmpleadoDTO ObtenerEmpleadoPorId(long empleadoId);

        int ObtenerSiguienteLegajo();

        long Insertar(EmpleadoDTO empleadoDto);

        void Modificar(EmpleadoDTO empleadoDto);

        void Eliminar(long empleadoId);

        

    }
}
