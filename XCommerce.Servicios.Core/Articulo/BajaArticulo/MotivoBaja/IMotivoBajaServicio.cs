using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja.DTO;

namespace XCommerce.Servicios.Core.Articulo.BajaArticulo.MotivoBaja
{
    public interface IMotivoBajaServicio
    {
        IEnumerable<MotivoBajaDTO> ObtenerMotivoBaja(string cadenaBuscar);

        MotivoBajaDTO ObtenerPorId(long motivoBajaId);

        long Insertar(MotivoBajaDTO dto);

        void Modificar(MotivoBajaDTO dto);

        //void Eliminar(long motivoBajaId);
    }
}
