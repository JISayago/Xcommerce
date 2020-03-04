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
    
    public partial class Caja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja()
        {
            this.DetalleCajas = new HashSet<DetalleCaja>();
            this.Movimientos = new HashSet<Movimiento>();
        }
    
        public long Id { get; set; }
        public decimal MontoApertura { get; set; }
        public decimal MontoCierre { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public System.DateTime FechaCierre { get; set; }
        public decimal MontoSistema { get; set; }
        public decimal Diferencia { get; set; }
        public long UsuarioAperturaId { get; set; }
        public long UsuarioCierreId { get; set; }
    
        public virtual Usuario UsuarioApertura { get; set; }
        public virtual Usuario UsuarioCierre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCaja> DetalleCajas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}
