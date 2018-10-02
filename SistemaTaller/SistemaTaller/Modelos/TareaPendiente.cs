using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class TareaPendiente
    {
        public int Id { get; set; }
        //public int Interno { get; set; }
        public DateTime FechaTarea { get; set; }
        public Vehiculo Interno { get; set; }
        public Mecanico Mecanico { get; set; }
        public IEnumerable<Diagnostico> Diagnosticos { get; set; }
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
       
    }
}
