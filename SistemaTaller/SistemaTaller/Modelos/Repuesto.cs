using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
   public class Repuesto
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
       public ICollection<TareaPendiente> TareaPendientes { get; set; }
        
    }
}
