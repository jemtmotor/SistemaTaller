using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Reparacion
    {
        public int Id { get; set; }
        public ICollection<Repuesto> Repuestos { get; set; }
        public DateTime FechaReparacion { get; set; }
    }
}
