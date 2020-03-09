using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.ListaPrecio.DTO
{
    public class ListaPrecioDTO
    {
        public long Id { get; set; }
        public bool EstaEliminado { get; set; }
        public string Descripcion { get; set; }
        public decimal Rentabilidad { get; set; }
    }
}
