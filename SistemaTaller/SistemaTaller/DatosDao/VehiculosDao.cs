using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTaller.Modelos;

namespace SistemaTaller.DatosDao
{
    public class VehiculosDao
    {
        public ICollection<Vehiculo> GetMecanicos()
        {
            var context = new TallerContext();
            return context.Vehiculos.ToList();
        }
        public void InsertVehiculo(Vehiculo tarea)
        {
            var context = new TallerContext();
            context.Vehiculos.Add(tarea);
            context.SaveChanges();
        }
    }
}
