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
    }
}
