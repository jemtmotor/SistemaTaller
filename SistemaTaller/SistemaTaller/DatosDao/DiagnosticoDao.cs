using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTaller.Modelos;

namespace SistemaTaller.DatosDao
{
    class DiagnosticoDao
    {
        public void InsertDiagnostico(Diagnostico diagnostico)
        {
            var context = new TallerContext();
            context.Diagnosticos.Add(diagnostico);
            context.SaveChanges();
        }
        public List<Diagnostico> GetDiagnosticosByTareaPendienteID(int TareaPendienteId)
        {
            var context = new TallerContext();
            return context.Diagnosticos.Where(d => d.TareaPendienteId == TareaPendienteId).ToList();

        }

        public void BorrarDiagnosticoByTareaPendienteID(int TareaPendienteId)
        {
            var context = new TallerContext();
            context.Diagnosticos.Remove(context.Diagnosticos.Where(d=>d.TareaPendienteId==TareaPendienteId).ToList().First());
            context.SaveChanges();
        }


    }
}
