using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTaller.Modelos.Interfaz
{
    public class FilaDiagnosticoChequeo
    {
        public Label Parte { get; set; }
        public ComboBox Estado { get; set; }
        public TextBox observacion { get; set; }
        public string Sector { get; set; }
    }
    
}
