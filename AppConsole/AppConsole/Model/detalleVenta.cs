//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppConsole.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalleVenta
    {
        public int iDDetalleVenta { get; set; }
        public Nullable<int> idVenta { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual tb_venta tb_venta { get; set; }
        public virtual producto producto { get; set; }
        public virtual producto producto1 { get; set; }
        public virtual tb_venta tb_venta1 { get; set; }
        public virtual tb_venta tb_venta2 { get; set; }
        public virtual tb_venta tb_venta3 { get; set; }
    }
}
