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

        public Vehiculo GetVehiculo(int vehiculoId)
        {
            var context = new TallerContext();
            return context.Vehiculos.Find(vehiculoId);

        }

        public void Update(Vehiculo item)
        {
            TallerContext tc = new TallerContext();
            var entity = tc.Vehiculos.Find(item.VehiculoId);
            if (entity == null)
            {
                return;
            }

            tc.Entry(entity).CurrentValues.SetValues(item);
            tc.SaveChanges();


        }
    }
}
