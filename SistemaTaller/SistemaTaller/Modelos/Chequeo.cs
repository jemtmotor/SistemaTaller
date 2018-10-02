using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Chequeo : TareaPendiente
    {
        public bool Service { get; set; }
        public DateTime FechaChequeo { get; set; }
    }
}
