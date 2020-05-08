using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommerce.Servicios.Core.Producto.DTO
{
   public  class ProductoMesaDTO
    {
        public long Id { get; set; }
        public bool EstaEliminado { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool DescuentaStock { get; set; }
    }
}
