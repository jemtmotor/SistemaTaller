using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class TareaPendiente
    {
        [Key]
        public int TareaPendienteId { get; set; }
        //public int Interno { get; set; }
        [Column(TypeName="Date")]
        public DateTime FechaTarea { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaRealizado { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaRecordatorio { get; set; }

        public IEnumerable<Diagnostico> Diagnosticos { get; set; }
        ///
        public ICollection<Repuesto> Repuestos { get; set; }
        public decimal Monto { get; set; }
        public bool Service { get; set; }
        public bool Estado { get; set; }
        ////ES CHEQUEO O REPARACION.
        /// 
        public string Tipo { get; set; }

        ////Foranea 1 a muchos
        public int VehiculoId { get; set; }
        public Vehiculo Interno { get; set; }
        public int MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }

    }
}
