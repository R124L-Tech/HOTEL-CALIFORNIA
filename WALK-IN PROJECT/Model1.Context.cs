﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WALK_IN_PROJECT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelEntities1 : DbContext
    {
        public hotelEntities1()
            : base("name=hotelEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<CashFlow> CashFlow { get; set; }
        public virtual DbSet<Kamar> Kamar { get; set; }
        public virtual DbSet<Karyawan> Karyawan { get; set; }
        public virtual DbSet<Reservasi> Reservasi { get; set; }
        public virtual DbSet<Tamu> Tamu { get; set; }
    }
}
