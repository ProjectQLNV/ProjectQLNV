﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLNVNhanVienEntities : DbContext
    {
        public QLNVNhanVienEntities()
            : base("name=QLNVNhanVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BangAdmin> BangAdmins { get; set; }
        public virtual DbSet<BangCanBo> BangCanBoes { get; set; }
        public virtual DbSet<BangYeuCau> BangYeuCaus { get; set; }
        public virtual DbSet<CaTruc> CaTrucs { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
    }
}
