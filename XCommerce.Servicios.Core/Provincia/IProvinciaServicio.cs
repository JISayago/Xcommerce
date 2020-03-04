using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Provincia.DTO;

namespace XCommerce.Servicios.Core.Provincia
{
    public interface IProvinciaServicio
    {
        IEnumerable<ProvinciaDTO> ObtenerProvincia(string cadenaBuscar);

        IEnumerable<ProvinciaDTO> ObtenerProvinciaEliminada(string cadenaBuscar);

        ProvinciaDTO ObtenerPorId(long provinciaId);

        long Insertar(ProvinciaDTO provinciaDTO);

        void Modificar(ProvinciaDTO provinciaDTO);

        void Eliminar(long provinciaId);    
   
    }
}
