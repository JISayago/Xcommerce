using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.CondicionIva.DTO;

namespace XCommerce.Servicios.Core.CondicionIva
{
    public interface ICondicionIvaServicio
    {
        IEnumerable<CondicionIvaDTO> ObtenerCondicionIva(string cadenaBuscar);

        //IEnumerable<CondicionIvaDTO> ObtenerCondicionIvaEliminada(string cadenaBuscar);

        CondicionIvaDTO ObtenerPorId(long CondIvaID);

        long Insertar(CondicionIvaDTO ConIvaDTO);

        void Modificar(CondicionIvaDTO ConIvaDTO);

        void Eliminar(long condicionIvaId);
    }
}
