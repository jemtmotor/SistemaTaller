using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net.Sockets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaTaller.Modelos
{
    public class TareasPendientesPrueba
    {
        [Key]
        public int TareaPendienteId { get; set; }
        //public int Interno { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaRecordatorio { get; set; }
        
        ////ES CHEQUEO O REPARACION.
        /// 
        public string Tipo { get; set; }

        ////Foranea 1 a muchos
        public int VehiculoId { get; set; }
        public Vehiculo Interno { get; set; }      
        
    }
}
