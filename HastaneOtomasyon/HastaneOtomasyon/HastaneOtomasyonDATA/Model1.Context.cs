﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneOtomasyonDATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastaneEntities : DbContext
    {
        public HastaneEntities()
            : base("name=HastaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birim> Birims { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Hasta> Hastas { get; set; }
        public virtual DbSet<Hemsire> Hemsires { get; set; }
        public virtual DbSet<Randevu> Randevus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
