using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Mecanico
    {
        [Key]
        public int MecanicoId { get; set; }
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int Celular { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaIngreso { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaNacimiento { get; set; }
    
        public ICollection<TareaPendiente> TareaPendientes { get; set; }
    }
}
