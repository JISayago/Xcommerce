using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace XCommerce.Servicios.Core.Localidad.DTO
{
    public interface ILocalidadServicio
    {
        IEnumerable<LocalidadDTO> ObtenerLocalidad(string cadenaBuscar);

        LocalidadDTO ObtenerPorId(long localidadId);
        
        IEnumerable<LocalidadDTO> ObtenerLocalidadEliminada(string cadenaBuscar);

        IEnumerable<LocalidadDTO> ObtenerLocalidadPorProvincia(long provinciaId, string cadenaBuscar);

        

        long Insertar(LocalidadDTO localidadDTO);

        void Modificar(LocalidadDTO localidadDTO);

        void Eliminar(long localidadId);
    }
}
