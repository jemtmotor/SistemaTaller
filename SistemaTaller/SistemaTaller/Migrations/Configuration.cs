using SistemaTaller.Modelos;

namespace SistemaTaller.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaTaller.Modelos.TallerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SistemaTaller.Modelos.TallerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //Datos Iniciales para la base de Datos.-
            //Agregar Vehiculos.
            context.Vehiculos.AddOrUpdate(new Vehiculo() { Estado = "BUENO", Sucursal = "Jujuy", Patente = "TQE287", Modelo = "F100", Año = 1992, Tipo = "Camioneta", Interno = "112", FechaProxService = DateTime.Now.AddMonths(-3) });
            context.Vehiculos.AddOrUpdate(new Vehiculo() { Estado = "BUENO", Sucursal = "Salta", Patente = "TPD651", Modelo = "710", Año = 2008, Tipo = "Camion", Interno = "205", FechaProxService = DateTime.Now.AddMonths(-3) });
            context.Vehiculos.AddOrUpdate(new Vehiculo() { Estado = "BUENO", Sucursal = "San Pedro", Patente = "REQ987", Modelo = "1114", Año = 2010, Tipo = "Camion", Interno = "305", FechaProxService = DateTime.Now.AddMonths(-3) });
            context.Vehiculos.AddOrUpdate(new Vehiculo() { Estado = "BUENO", Sucursal = "San Pedro", Patente = "TEQ897", Modelo = "1314", Año = 2015, Tipo = "Camion", Interno = "306", FechaProxService = DateTime.Now.AddMonths(-3) });
            context.Vehiculos.AddOrUpdate(new Vehiculo() { Estado = "BUENO", Sucursal = "Jujuy", Patente = "NPS789", Modelo = "1818", Año = 2018, Tipo = "Camion", Interno = "101", FechaProxService = DateTime.Now.AddMonths(-3) });
            //Agregar Tarea Pendiente

            //Agregar Mecanicos
            context.Mecanicos.AddOrUpdate(new Mecanico() { Legajo = "147", Apellido = "Molloja", Nombre = "Josué", Dni = 3555555, Celular = 3518989, FechaIngreso = new DateTime(2015, 8, 10), FechaNacimiento = new DateTime(1992, 2, 4) });
            context.Mecanicos.AddOrUpdate(new Mecanico() { Legajo = "189", Apellido = "Ramos", Nombre = "Abel", Dni = 3549899, Celular = 651999, FechaIngreso = new DateTime(2014, 8, 10), FechaNacimiento = new DateTime(1990, 4, 4) });
            context.Mecanicos.AddOrUpdate(new Mecanico() { Legajo = "198", Apellido = "Ibarra", Nombre = "Marcos", Dni = 3489984, Celular = 198199, FechaIngreso = new DateTime(2013, 8, 10), FechaNacimiento = new DateTime(1995, 8, 4) });
            context.Mecanicos.AddOrUpdate(new Mecanico() { Legajo = "166", Apellido = "Huanca", Nombre = "Daniel", Dni = 1651658, Celular = 156166, FechaIngreso = new DateTime(2012, 8, 4), FechaNacimiento = new DateTime(1992, 8, 8) });
            context.Mecanicos.AddOrUpdate(new Mecanico() { Legajo = "987", Apellido = "Ali", Nombre = "Mariano", Dni = 1656515, Celular = 516516, FechaIngreso = new DateTime(2009, 9, 3), FechaNacimiento = new DateTime(1991, 1, 1) });
            //Agregar Diagnostico.

        }
    }
}
