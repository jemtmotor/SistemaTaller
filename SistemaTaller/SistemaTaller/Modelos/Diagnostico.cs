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
        public string Sector { get; set; }
        public bool Estado { get; set; } /// Es para indicar si el diagnotico esta resuelto, sirve cuando se registra una reparación.
        public string Parte { get; set; }

        public int TareaPendienteId { get; set; }
        public TareaPendiente TareaPendiente { get; set; }
    }
}
