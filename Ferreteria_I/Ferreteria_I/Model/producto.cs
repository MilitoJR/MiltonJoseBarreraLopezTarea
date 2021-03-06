//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferreteria_I.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.venta = new HashSet<venta>();
        }
    
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int id_marca { get; set; }
        public int cantidad { get; set; }
        public int id_presentacion { get; set; }
        public string descripcion { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public int id_categoria { get; set; }
        public int id_proveedor { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual marca marca { get; set; }
        public virtual presentacion presentacion { get; set; }
        public virtual proveedor proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}
