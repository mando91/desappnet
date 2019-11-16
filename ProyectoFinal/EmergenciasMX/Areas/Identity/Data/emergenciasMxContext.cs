using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmergenciasMX.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmergenciasMX.Models;

namespace EmergenciasMX.Areas.Identity.Data
{
    public class emergenciasMxContext : IdentityDbContext<User>
    {
        public emergenciasMxContext(DbContextOptions<emergenciasMxContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Emergencia> Emergencia { get; set; }
        public DbSet<TipoEmergencia> TipoEmergencia { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<InstitucionPublica> InstitucionPublica { get; set; }
        public DbSet<EmergenciaInstitucion> EmergenciaInstitucion { get; set; } 
        public DbSet<ReportesAnonimos> ReportesAnonimos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          //  builder.Entity<IdentityUser>().ToTable("AspNetUsers");
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
