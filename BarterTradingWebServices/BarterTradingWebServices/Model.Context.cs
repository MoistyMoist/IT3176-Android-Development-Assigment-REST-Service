﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarterTradingWebServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BarterTradingDBEntities : DbContext
    {
        public BarterTradingDBEntities()
            : base("name=BarterTradingDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<PRODUCT> PRODUCTs { get; set; }
        public DbSet<TRANSACTION> TRANSACTIONs { get; set; }
        public DbSet<USER> USERs { get; set; }
        public DbSet<WISH> WISHes { get; set; }
    }
}
