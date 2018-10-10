using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTaller.Modelos;

namespace SistemaTaller.DatosDao
{
    public class MecanicosDao
    {
        public ICollection<Mecanico> GetMecanicos()
        {
            var context = new TallerContext();
            return context.Mecanicos.ToList();
        }
        public Mecanico GetMecanico(int MecanicoId)
        {
            var context = new TallerContext();
            return context.Mecanicos.Find(MecanicoId);

        }
        public void InsertMecanico(Mecanico mecanico)
        {
            var context = new TallerContext();
            context.Mecanicos.Add(mecanico);
            context.SaveChanges();
        }
    }
}
