using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class TareaPendiente
    {
        public int Id { get; set; }
        //public int Interno { get; set; }
        public DateTime FechaTarea { get; set; }
        public DateTime FechaRealizado { get; set; }
        public DateTime FechaRecordatorio { get; set; }
        public Vehiculo Interno { get; set; }
        public Mecanico Mecanico { get; set; }
        public IEnumerable<Diagnostico> Diagnosticos { get; set; }
        ///
        public ICollection<Repuesto> Repuestos { get; set; }
        public decimal Monto { get; set; }
        public bool Service { get; set; }
        public bool Estado { get; set; }
        ////ES CHEQUEO O REPARACION.
        /// 
        public string Tipo { get; set; }
        

    }
}
