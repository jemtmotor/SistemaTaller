using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class TallerContext : DbContext
    {
        public TallerContext() : base( "SistemaTallerBDNUEVA")
        {

        }

        public DbSet<Repuesto> Repuestos { get; set; }
      
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<TareaPendiente> TareaPendientes { get; set; }

        public DbSet<TareasPendientesPrueba> TareaPendietePrueba { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TareaPendiente>().Property(ft => ft.FechaTarea).IsOptional();
            modelBuilder.Entity<TareaPendiente>().Property(ft => ft.FechaRealizado).IsOptional();
            modelBuilder.Entity<TareaPendiente>().Property(ft => ft.FechaRecordatorio).IsOptional();
            

            base.OnModelCreating(modelBuilder);
        }


    }
}
