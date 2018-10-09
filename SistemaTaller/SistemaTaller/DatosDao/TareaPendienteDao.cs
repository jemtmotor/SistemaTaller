using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public TareaPendiente GetUltimoPendiente()
        {
            TallerContext tc = new TallerContext();
            TareaPendiente tp = new TareaPendiente();
            foreach (TareaPendiente tpu in tc.TareaPendientes)
            {
                tp = tpu;
            }

            return tp;
        }

       

        public void Update(TareaPendiente item)
        {
            TallerContext tc = new TallerContext();
            var entity = tc.TareaPendientes.Find(item.TareaPendienteId);
            if (entity == null)
            {
                return;
            }

             tc.Entry(entity).CurrentValues.SetValues(item);
            tc.SaveChanges();

            
        }

    }
}
