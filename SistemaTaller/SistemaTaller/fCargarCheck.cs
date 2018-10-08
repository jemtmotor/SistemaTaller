using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTaller.DatosDao;
using SistemaTaller.Modelos;
using SistemaTaller.Modelos.Interfaz;

namespace SistemaTaller
{
    public partial class fCargarCheck : Form
    {
        public ICollection<FilaDiagnosticoChequeo> FilaDiagnosticos { get; set; }
        public ICollection<Vehiculo> vehiculos { get; set; }
        private ICollection<Mecanico> Mecanicos { get; set; }

        public fCargarCheck()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void fCargarCheck_Load(object sender, EventArgs e)
        {
            FilaDiagnosticos = new List<FilaDiagnosticoChequeo>();
            //Sector Motor
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MAceiteEstado,MAceiteParte,MAceiteObser,tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MAlternadorEstado,MAlternadorParte,MAlternadorObser,tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MArranqueEstado, MArranqueParte, MArranqueObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MCorreasEstado, MCorreasParte, MCorreasObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MRadiadorEstado, MRadiadorParte, MRadiadorObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MHidraulicoEstado, MHidraulicoParte, MHidraulicoObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MManguerasEstado, MMangueraParte, MMangueraObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MPerdFluidosEstado, MPerdFluidosParte, MPerdFluidosObser, tabMotor.Text));
            //Sector Tren Delantero
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDAmortEstado,TDAmortParte,TDAmortObser,tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDCinFrenosEstado, TDCinFrenosParte, TDCinFrenosObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDElasticosEstado, TDElasticosParte, TDElasticosObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDEstNeumaEstado, TDEstNeumaParte, TDEstNeumaObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDExtDirEstado, TDExtDirParte, TDExtDirObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDMazYRuleEstado, TDMazYRuleParte, TDMazYRuleObser, tabTrenDelantero.Text));
            //Sector Transmision
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TCajaVeloEstado,TCajaVeloParte,TCajaVeloObser,tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TCardanYCrucEstado, TCardanYCrucParte, TCardanYCrucObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TEmbragueEstado, TEmbragueParte, TEmbragueObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TdiferencialEstado, TdiferencialParte, TdiferencialObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TpalieresEstado, TpalieresParte, TpalieresObser, tabTransmision.Text));
            //Sector Tren Trasero
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TTAmortiEstado, TTAmortiParte, TTAmortiObser, tabTrenTrasero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TTMazaRuleEstado, TTMazaRuleParte, TTMazaRuleObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TTCinFrenosEstado, TTCinFrenosParte, TTCinFrenosObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TTElasticosEstado, TTElasticosParte, TTElasticosObser, tabTransmision.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TTEstNeumaticoEstado, TTEstNeumaticoParte, TTEstNeumaticoObser, tabTransmision.Text));
            //Sector Engrase y Luces
            FilaDiagnosticos.Add(MapFilaDiagnosticos(ELEngraseGralEstado, ELEngraseGralParte, ELEngraseGralObser, "Engrase General"));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(ELctrolLucesEstado, ELctrolLucesParte, ELctrolLucesObser, "Control de Luces"));
            //Cargar Mecanicos en el ComboBox de Mecanicos
            Mecanicos = new List<Mecanico>();
            Mecanicos = new MecanicosDao().GetMecanicos();
            /*foreach (var mecanico in Mecanicos)
            {
                Mecanico foo = new Mecanico(){
                    Nombre = mecanico.Apellido +" "+mecanico.Nombre,
                    Id =mecanico.Id};
                cbMecanicos.Items.Add(foo);
            }

            cbMecanicos.DisplayMember = "nombre";
            cbMecanicos.ValueMember = "Id";*/
            //Obtengo Vehiculos.
            cbMecanicos.DataSource = Mecanicos;
            cbMecanicos.DisplayMember = "Nombre";

            vehiculos = new List<Vehiculo>();
            vehiculos = new VehiculosDao().GetMecanicos();
            int x = 12;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void MAceiteEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MAceiteEstado,MAceiteObser);
        }

        public void HabilitacionObservacion(ComboBox cmBox, TextBox txBox)
        {
            if (cmBox.Text == "MALO")
            {
                txBox.Enabled = true;
            }
            else
            {
                txBox.Enabled = false;
            }

        }

        private void MHidraulicoEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MHidraulicoEstado, MHidraulicoObser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Diagnosticos = new List<Diagnostico>();
            foreach (var fd in FilaDiagnosticos)
            {
                if (fd.observacion.Enabled)
                {
                    var diagnostico = new Diagnostico
                    {
                        Sector = fd.Sector,
                        Parte = fd.Parte.Text,
                        Estado = false,
                        Observacion = fd.observacion.Text
                    };
                    Diagnosticos.Add(diagnostico);
                }
            }

           object MecanicoSeleccionado = cbMecanicos.SelectedItem;
           Mecanico mec = MecanicoSeleccionado as Mecanico;
           /*Mecanico mecanicoIngreso = new Mecanico();
           foreach (var mecanico in Mecanicos)
           {
                if (mecanico.Id == mec.Id)
                {
                    mecanicoIngreso = mecanico;
           }
            }
            */


            Int32.TryParse(tbInterno.Text, out var interno);
            Vehiculo vec = new Vehiculo();
            foreach (var vehiculo in vehiculos)
            {
                if (interno == vehiculo.Id)
                {
                    vec = vehiculo;
                }
            }
            Int32.TryParse(tbMonto.Text, out var monto);
            TareaPendiente tareaPendiente = new TareaPendiente
            {
                //Diagnosticos = Diagnosticos,
                Estado = !Diagnosticos.Any(),
                FechaTarea = dTPfechaTarea.Value,
                FechaRecordatorio = dTPfechaTarea.Value.AddMonths(1),
                //Mecanico = mec,
                //Interno = vec,
                Monto =(Decimal) monto,
                Service = cbService.Checked
            };
            var TareaDao = new TareaPendienteDao();
                TareaDao.InsertTareaPendiente(tareaPendiente);


            int x = 1 ;

        }

        public FilaDiagnosticoChequeo MapFilaDiagnosticos(ComboBox estado, Label Parte, TextBox observacion1, string Sector1)
        {
            return new FilaDiagnosticoChequeo
            {
                Sector = Sector1,Estado = estado,Parte = Parte,observacion = observacion1
            };
        }
        public ICollection<Diagnostico> Diagnosticos { get; set; }

        private void MCorreasEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
             HabilitacionObservacion(MCorreasEstado, MCorreasObser);
        }

        private void MManguerasEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MManguerasEstado, MMangueraObser);
        }

        private void MAlternadorEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MAlternadorEstado, MAlternadorObser);
        }

        private void MArranqueEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MArranqueEstado, MArranqueObser);
        }

        private void MRadiadorEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MRadiadorEstado, MRadiadorObser);
        }

        private void MPerdFluidosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MPerdFluidosEstado, MPerdFluidosObser);
        }

        private void tbInterno_Leave(object sender, EventArgs e)
        {
            Int32.TryParse(tbInterno.Text, out var interno);
            bool valido = false;
            foreach (var vehiculo in vehiculos)
            {
                if (interno == vehiculo.Interno)
                {
                    valido = true;
                    break;
                }
            }

            if (!valido)
            {
                MessageBox.Show("El Vehiculo Ingresado no se encuentra en el Sistema", "Interno No Existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void cbMecanicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
