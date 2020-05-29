using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Caja.DetalleCaja
{
    public interface IDetalleCajaServicio
    {
        void GenerarDetalleCaja(long idCaja,decimal monto,TipoPago tipoPago);
    }
}
