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
        public bool fechaValida = true;

        int idTareaPendientePrueba;
        string vehiculoInternoPrueba;
        bool vieneDeNotificacion;

        public fCargarCheck()
        {
            InitializeComponent();

            vieneDeNotificacion = false;
        }

        public fCargarCheck(int idTarea, string inter)
        {
            InitializeComponent();

            vieneDeNotificacion = true;
            idTareaPendientePrueba = idTarea;
            vehiculoInternoPrueba = inter;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void fCargarCheck_Load(object sender, EventArgs e)
        {   
            
            if(vieneDeNotificacion == true)
            {
                tbInterno.Text = vehiculoInternoPrueba;
            }


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
            HabilitacionObservacion(ELEngraseGralEstado, ELEngraseGralObser);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(ELctrolLucesEstado, ELctrolLucesObser);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dTPfechaTarea.Value > DateTime.Now)
            {
                fechaValida = false;

            }
            else
            {
                fechaValida = true;
            }
            
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
                txBox.Text = "";
                txBox.Enabled = false;
            }

        }

        private void MHidraulicoEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MHidraulicoEstado, MHidraulicoObser);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int32.TryParse(tbInterno.Text, out var interno);
            bool valido = false;
            foreach (var vehiculo in vehiculos)
            {
                if (tbInterno.Text == vehiculo.Interno)
                {
                    valido = true;
                    break;
                }
            }

            if (!valido || fechaValida==false)
            {
                if (!valido)
                {
                    MessageBox.Show("El Vehiculo Ingresado no se encuentra en el Sistema", "Interno No Existe",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    tbInterno.Focus();
                }

                if (!fechaValida)
                {
                    MessageBox.Show("La fecha no puede superer la actual", "Fecha No Valida",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    dTPfechaTarea.Focus();
                }
            }
            else
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


            //Int32.TryParse(tbInterno.Text, out var interno);
            Vehiculo vec = new Vehiculo();
            foreach (var vehiculo in vehiculos)
            {
                if (tbInterno.Text == vehiculo.Interno)
                {
                    vec = vehiculo;
                }
            }
            //Int32.TryParse(tbMonto.Text, out var monto);
            decimal monto = Convert.ToDecimal(tbMonto.Text);
            TareaPendiente tareaPendiente = new TareaPendiente
            {
                Diagnosticos = Diagnosticos,
                Estado = !Diagnosticos.Any(),
                FechaTarea = DateTime.Now,
                FechaRealizado = dTPfechaTarea.Value,
                FechaRecordatorio = dTPfechaTarea.Value.AddMonths(1),
                MecanicoId = mec.MecanicoId,
                VehiculoId = vec.VehiculoId,
                Monto =(Decimal) monto,
                Service = cbService.Checked,
                Tipo = "Chequeo"
            };
                if (cbService.Checked)
                {
                    vec.FechaProxService = dTPfechaTarea.Value.AddMonths(3);
                    //Actualizar la fecha de proximo service en el vehiculo.
                    VehiculosDao vDao = new VehiculosDao();
                    vDao.Update(vec);
                }

            var TareaDao = new TareaPendienteDao();
                TareaDao.InsertTareaPendiente(tareaPendiente);
            TareaPendiente ultima = TareaDao.GetUltimoPendiente();
            DiagnosticoDao diagDao = new DiagnosticoDao();
            foreach (var diag in Diagnosticos)
            {
                diag.TareaPendienteId = ultima.TareaPendienteId;
                diagDao.InsertDiagnostico(diag);
            }




                //NUEVA TABLA
                TareasPendientesPrueba tareaPendientePrueba = new TareasPendientesPrueba
                {
                   
                    FechaRecordatorio = dTPfechaTarea.Value.AddMonths(1),                    
                    VehiculoId = vec.VehiculoId,                   
                    Tipo = "Chequeo"
                };
               //LLENAME LA TABLA NUEVA CON LOS DATOS DE ARRIBA

                
                
                
                
                //BORRO EL REGISTRO VIEJO DE LA TABLA NUEVA
                if (vieneDeNotificacion == true)
                {
                    var contexto = new TallerContext();
                    var consultaBorrar = from tablaTareaPendientePrueba in contexto.TareaPendietePrueba
                                         where (tablaTareaPendientePrueba.TareaPendienteId == idTareaPendientePrueba)
                                         select tablaTareaPendientePrueba;

                    foreach (var dato in consultaBorrar)
                    {
                        contexto.TareaPendietePrueba.Remove(dato);
                    }

                    contexto.SaveChanges();
                }



                MessageBox.Show("Se registro el mantenimiento", "Registro de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Para Refrescar
                Form1.verificar = true;

            this.Close();
            }
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
          
        }

        private void cbMecanicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Segunda Pestaña
        private void TDExtDirEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDExtDirEstado, TDExtDirObser);
        }

        private void TDMazYRuleEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDMazYRuleEstado, TDMazYRuleObser);
        }

        private void TDElasticosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDElasticosEstado, TDElasticosObser);
        }

        private void TDCinFrenosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDCinFrenosEstado, TDCinFrenosObser);
        }

        private void TDAmortEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDAmortEstado, TDAmortObser);
        }

        private void TDEstNeumaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDEstNeumaEstado, TDEstNeumaObser);
        }
        //Tercera Pestaña
        private void TCajaVeloEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TCajaVeloEstado, TCajaVeloObser);
        }

        private void TCardanYCrucEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TCardanYCrucEstado, TCardanYCrucObser);
        }

        private void TEmbragueEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TEmbragueEstado, TEmbragueObser);
        }

        private void TdiferencialEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TdiferencialEstado, TdiferencialObser);
        }

        private void TpalieresEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TpalieresEstado, TpalieresObser);
        }
        //Cuarta Pestaña
        private void TTMazaRuleEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTMazaRuleEstado, TTMazaRuleObser);
        }

        private void TTCinFrenosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTCinFrenosEstado, TTCinFrenosObser);
        }

        private void TTElasticosEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTElasticosEstado, TTElasticosObser);
        }

        private void TTAmortiEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTAmortiEstado, TTAmortiObser);
        }

        private void TTEstNeumaticoEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTEstNeumaticoEstado, TTEstNeumaticoObser);
        }
        //Quinta Pestaña
        private void ELEngraseGralEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(ELEngraseGralEstado, ELEngraseGralObser);
        }

        private void ELctrolLucesEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(ELctrolLucesEstado, ELctrolLucesObser);
        }

        private void TDMazYRuleEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDMazYRuleEstado, TDMazYRuleObser);
        }

        private void TDElasticosEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDElasticosEstado, TDElasticosObser);
        }

        private void TDCinFrenosEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDCinFrenosEstado, TDCinFrenosObser);
        }

        private void TDAmortEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDAmortEstado, TDAmortObser);
        }

        private void TDEstNeumaEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TDEstNeumaEstado, TDEstNeumaObser);
        }

        private void TCajaVeloEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TCajaVeloEstado, TCajaVeloObser);
        }

        private void TCardanYCrucEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TCardanYCrucEstado, TCardanYCrucObser);
        }

        private void TEmbragueEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TEmbragueEstado, TEmbragueObser);
        }

        private void TdiferencialEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TdiferencialEstado, TdiferencialObser);
        }

        private void TpalieresEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TpalieresEstado, TpalieresObser);
        }

        private void TTMazaRuleEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTMazaRuleEstado, TTMazaRuleObser);
        }

        private void TTCinFrenosEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTCinFrenosEstado, TTCinFrenosObser);
        }

        private void TTElasticosEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTElasticosEstado, TDElasticosObser);
        }

        private void TTAmortiEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTAmortiEstado, TTAmortiObser);
        }

        private void TTEstNeumaticoEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitacionObservacion(TTEstNeumaticoEstado, TTEstNeumaticoObser);
        }
    }
}
