﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grocery_Shop_Management_DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POS_Management_DBEntities : DbContext
    {
        public POS_Management_DBEntities()
            : base("name=POS_Management_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T00000> T00000 { get; set; }
        public virtual DbSet<T00001> T00001 { get; set; }
        public virtual DbSet<T12001> T12001 { get; set; }
        public virtual DbSet<T12002> T12002 { get; set; }
        public virtual DbSet<T12003> T12003 { get; set; }
        public virtual DbSet<T12004> T12004 { get; set; }
        public virtual DbSet<T12005> T12005 { get; set; }
        public virtual DbSet<T14001> T14001 { get; set; }
        public virtual DbSet<T14002> T14002 { get; set; }
        public virtual DbSet<T14003> T14003 { get; set; }
        public virtual DbSet<T14004> T14004 { get; set; }
        public virtual DbSet<T00002> T00002 { get; set; }
    }
}
