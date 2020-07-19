using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.Servicios.Core.Caja.DTO;

namespace XCommerce.Servicios.Core.Caja
{
    public interface ICajaServicio
    {
        long Abrir(CajaDTO dto);
        void Cerrar(CajaDTO dto);
        CajaDTO Obtener(long id);
        bool HayCajaAbierta();
        long ObtenerCajaAbierta();
        decimal ObtenerMontoSistema(long cajaId);
    }
}
