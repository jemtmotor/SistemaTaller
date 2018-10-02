using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        
        public TareaPendiente TareaPendiente { get; set; }
    }
}
