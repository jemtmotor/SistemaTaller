using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Estado { get; set; }
        public string Sucursal { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public int Interno { get; set; }
        public ICollection<TareaPendiente> TareaPendientes { get; set; }
    }
}
