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
        public TallerContext() : base()
        {

        }

        public DbSet<Repuesto> Repuestos { get; set; }
      
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<TareaPendiente> TareaPendientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
