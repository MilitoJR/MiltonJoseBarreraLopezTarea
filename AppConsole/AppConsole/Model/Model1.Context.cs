﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sitema_ventasEntities : DbContext
    {
        public sitema_ventasEntities()
            : base("name=sitema_ventasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<roles_usuario> roles_usuario { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tb_cliente> tb_cliente { get; set; }
        public virtual DbSet<tb_documento> tb_documento { get; set; }
        public virtual DbSet<tb_venta> tb_venta { get; set; }
        public virtual DbSet<detalleVenta> detalleVenta { get; set; }
    }
}
