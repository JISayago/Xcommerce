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
        public long CajaID { get; set; }
        public long ComprobanteID { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public long UsuarioID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        private string TipoString => Tipo == TipoMovimiento.Egreso ? "E" : "I";
        public string Descripcion => $"MOV_{TipoString}_F{Id}_CID{ComprobanteID}_F{Fecha.Year}-{Fecha.Month}-{Fecha.Day}-{Fecha.Hour}";
    }
}