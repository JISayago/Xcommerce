using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Movimiento
{
    public interface IMovimientoServicio
    {
        void GenerarMovimiento(long idCaja,long idComprobante,TipoMovimiento tipoMovimiento,long idUsuario,decimal monto,string descripcion);
        
       
    }
}
