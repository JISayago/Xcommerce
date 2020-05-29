using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;

namespace XCommerce.Servicios.Core.Movimiento.DTO
{
    public class MovimientoDTO
    {

        public long Id { get; set; }
        public long cajaID { get; set; }
        public long ComprobanteID { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public long UsuarioID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
