﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelefonReheri.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TelefonRehberiEntities : DbContext
    {
        public TelefonRehberiEntities()
            : base("name=TelefonRehberiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calisan> Calisan { get; set; }
        public virtual DbSet<Departman> Departman { get; set; }
        public virtual DbSet<KullaniciBilgisi> KullaniciBilgisi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}