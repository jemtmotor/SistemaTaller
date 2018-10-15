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
    public partial class fModificarChequeo : Form
    {
        public int TareaPendienteID;
        public ICollection<FilaDiagnosticoChequeo> FilaDiagnosticos { get; set; }
        public ICollection<Vehiculo> vehiculos { get; set; }
        private ICollection<Mecanico> Mecanicos { get; set; }
        public List<Diagnostico> Diagnosticos { get; set; }
        public List<Diagnostico> diagAmod { get; set; }

        public bool fechaValida = true;
        public fModificarChequeo()
        {
            InitializeComponent();
            
        }
        public fModificarChequeo(int valor)
        {
            InitializeComponent();
            this.TareaPendienteID = valor;
        }

        private void fModificarChequeo_Load(object sender, EventArgs e)
        {
            FilaDiagnosticos = new List<FilaDiagnosticoChequeo>();
            //Sector Motor
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MAceiteEstado, MAceiteParte, MAceiteObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MAlternadorEstado, MAlternadorParte, MAlternadorObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MArranqueEstado, MArranqueParte, MArranqueObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MCorreasEstado, MCorreasParte, MCorreasObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MRadiadorEstado, MRadiadorParte, MRadiadorObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MHidraulicoEstado, MHidraulicoParte, MHidraulicoObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MManguerasEstado, MMangueraParte, MMangueraObser, tabMotor.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(MPerdFluidosEstado, MPerdFluidosParte, MPerdFluidosObser, tabMotor.Text));
            //Sector Tren Delantero
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDAmortEstado, TDAmortParte, TDAmortObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDCinFrenosEstado, TDCinFrenosParte, TDCinFrenosObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDElasticosEstado, TDElasticosParte, TDElasticosObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDEstNeumaEstado, TDEstNeumaParte, TDEstNeumaObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDExtDirEstado, TDExtDirParte, TDExtDirObser, tabTrenDelantero.Text));
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TDMazYRuleEstado, TDMazYRuleParte, TDMazYRuleObser, tabTrenDelantero.Text));
            //Sector Transmision
            FilaDiagnosticos.Add(MapFilaDiagnosticos(TCajaVeloEstado, TCajaVeloParte, TCajaVeloObser, tabTransmision.Text));
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
            //Mecanicos Opcion
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
            //Obtener Vehiculos.
            vehiculos = new List<Vehiculo>();
            vehiculos = new VehiculosDao().GetMecanicos();
            //Obtengo los Diagnosticos de la Tarea Pendiente y los cargo en la ventana de Modificar Diagnosticos.
            DiagnosticoDao diagnosticoDao = new DiagnosticoDao();
            diagAmod = diagnosticoDao.GetDiagnosticosByTareaPendienteID(TareaPendienteID);
            CargarDiagnosticos(diagAmod);
            //Obtengo el Chequeo con el ID seleccionado.
            TareaPendienteDao tpDao = new TareaPendienteDao();
            TareaPendiente tpAMod = tpDao.GetPendiente(TareaPendienteID);
            //A partir de la tarea obtengo el mecanico a mostrar.
            Mecanico mecAmod = new Mecanico();
            foreach (var mecanico in Mecanicos)
            {
                if (mecanico.MecanicoId == tpAMod.MecanicoId)
                {
                    mecAmod = mecanico;
                }
            }
            //A partir de la tarea obtengo el interno a mostrar.
            Vehiculo vecAMod = new Vehiculo();
            VehiculosDao vehiculoDao = new VehiculosDao();
            vecAMod=vehiculoDao.GetVehiculo(tpAMod.VehiculoId);
            //Cargo los datos del tarea Pendiente en los campos a Modificar
            dTPfechaTarea.Value = tpAMod.FechaRealizado;
            cbService.Checked = tpAMod.Service;
            tbMonto.Text = $"{tpAMod.Monto}";
            cbMecanicos.SelectedItem = mecAmod;
            tbInterno.Text = vecAMod.Interno;
            int x = 1;
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

            if (!valido || fechaValida == false)
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
                //Seteo la tarea pendiente con los nuevos datos del formulario
                TareaPendiente tareaPendiente = new TareaPendiente
                {
                    TareaPendienteId = TareaPendienteID,
                    Diagnosticos = Diagnosticos,
                    Estado = !Diagnosticos.Any(),
                    FechaTarea = DateTime.Now,
                    FechaRealizado = dTPfechaTarea.Value,
                    FechaRecordatorio = dTPfechaTarea.Value.AddMonths(1),
                    MecanicoId = mec.MecanicoId,
                    VehiculoId = vec.VehiculoId,
                    Monto = (Decimal)monto,
                    Service = cbService.Checked,
                    Tipo = "Chequeo"
                };
                //pregunto si Service igual a verdadero
                if (cbService.Checked)
                {
                    vec.FechaProxService = dTPfechaTarea.Value.AddMonths(3);
                    //Actualizar la fecha de proximo service en el vehiculo.
                    VehiculosDao vDao = new VehiculosDao();
                    vDao.Update(vec);
                }
                //Actualizo la tarea Pendiente en la base de datos.
                var TareaDao = new TareaPendienteDao();
                TareaDao.Update(tareaPendiente);

                //Actualizo los diagnoticos realacionados a ese TareaPendiente.
                //Primero borro todos los diagnoticos viejos.
                DiagnosticoDao diagnosticoDao = new DiagnosticoDao();
                foreach (Diagnostico diagnosticoBorrar in diagAmod)
                {
                    diagnosticoDao.BorrarDiagnosticoByTareaPendienteID(TareaPendienteID);
                }
            
            
                //ahora cargo los nuevos diagnosticos.
            
            
                foreach (var diag in Diagnosticos)
                {
                    diag.TareaPendienteId = TareaPendienteID;
                    diagnosticoDao.InsertDiagnostico(diag);
                }
                MessageBox.Show("Se modifico el mantenimiento", "Modificacion de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                fListadoServicio form = new fListadoServicio();
                form.Show();
                this.Close();
                
            }

        }

        private void MAceiteEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitacionObservacion(MAceiteEstado, MAceiteObser);
        }
        public FilaDiagnosticoChequeo MapFilaDiagnosticos(ComboBox estado, Label Parte, TextBox observacion1, string Sector1)
        {
            return new FilaDiagnosticoChequeo
            {
                Sector = Sector1,
                Estado = estado,
                Parte = Parte,
                observacion = observacion1
            };
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

        //Cargar Diagnosticos.
        public void CargarDiagnosticos(List<Diagnostico> DiagnosticosLista)
        {
            foreach (Diagnostico diag in DiagnosticosLista)
            {
                foreach (var filadiag in FilaDiagnosticos)
                {
                    if (filadiag.Sector == diag.Sector && filadiag.Parte.Text == diag.Parte)
                    {
                        filadiag.Estado.Text = !diag.Estado ? "MALO" : "BUENO";
                        filadiag.observacion.Text = diag.Observacion;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fListadoServicio form = new fListadoServicio();
            form.Show();
            this.Close();
        }

        private void tabTransmision_Click(object sender, EventArgs e)
        {

        }

        private void dTPfechaTarea_ValueChanged(object sender, EventArgs e)
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
    }
}
