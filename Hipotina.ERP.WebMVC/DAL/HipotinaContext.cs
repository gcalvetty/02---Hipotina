using Hipotina.ERP.WebMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Hipotina.ERP.WebMVC.DAL
{
    public class HipotinaContext : DbContext
    {
        public HipotinaContext() : base("HipotinaContext")
        { }
            public DbSet<Personal> Personales { get; set; }
            public DbSet<PersonalDatos> PersonalDatoses { get; set; }
     
           protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                }
    }    
}