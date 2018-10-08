using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTaller.Modelos;

namespace SistemaTaller.DatosDao
{
    public class TareaPendienteDao
    {
        public void InsertTareaPendiente(TareaPendiente tarea)
        {
            var context = new TallerContext();
            context.TareaPendientes.AddOrUpdate(tarea);
            context.SaveChanges();
            }
        
        

    }
}
