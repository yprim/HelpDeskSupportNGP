﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDeskSupport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HelpDeskNGPEntities : DbContext
    {
        public HelpDeskNGPEntities()
            : base("name=HelpDeskNGPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Commets_Client> Commets_Client { get; set; }
        public virtual DbSet<Issue_Client> Issue_Client { get; set; }
        public virtual DbSet<Issue_Support> Issue_Support { get; set; }
        public virtual DbSet<Notes_Support> Notes_Support { get; set; }
        public virtual DbSet<Supervisor_Support> Supervisor_Support { get; set; }
        public virtual DbSet<Supporter_Support> Supporter_Support { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User_Client> User_Client { get; set; }
    }
}
