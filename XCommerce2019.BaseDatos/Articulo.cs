//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XCommerce.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulo()
        {
            this.DescuentaStock = true;
            this.EstaEliminado = false;
            this.BajaArticulos = new HashSet<BajaArticulo>();
            this.Precios = new HashSet<Precio>();
            this.DetalleComprobantes = new HashSet<DetalleComprobante>();
        }
    
        public long Id { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
        public byte[] Foto { get; set; }
        public bool ActivarLimiteVenta { get; set; }
        public decimal LimiteVenta { get; set; }
        public bool PermiteStockNegativo { get; set; }
        public bool EstaDiscontinuado { get; set; }
        public decimal StockMaximo { get; set; }
        public decimal StockMinimo { get; set; }
        public bool DescuentaStock { get; set; }
        public bool EstaEliminado { get; set; }
        public long MarcaId { get; set; }
        public long RubroId { get; set; }
        public decimal Stock { get; set; }
    
        public virtual Marca Marca { get; set; }
        public virtual Rubro Rubro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BajaArticulo> BajaArticulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Precio> Precios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
    }
}
