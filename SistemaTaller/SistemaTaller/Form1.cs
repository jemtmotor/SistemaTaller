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

namespace SistemaTaller
{
    public partial class Form1 : Form
    {

        int idTareaPendientePrueba;
        string interno;

        int idTareaPendientePrueba2;
        string interno2;

        int idTareaPendientePrueba3;
        string interno3;

        public static bool verificar;


        public Form1()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void respuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tareasPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTareasPendientes form = new fTareasPendientes();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chequeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCargarCheck form = new fCargarCheck();
            form.Show();
        }

        private void reparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCargarReparacion form = new fCargarReparacion();
            form.Show();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListadoServicio form = new fListadoServicio();
            form.Show();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fCargarEmpleado form = new fCargarEmpleado();
            form.Show();
        }

        private void modificarEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fModificarEliminarEmpleado form = new fModificarEliminarEmpleado();
            form.Show();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fListadoMecanico form = new fListadoMecanico();
            form.Show();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void modificarEliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void cargarUnTipoExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCargarRespuesto form = new fCargarRespuesto();
            form.Show();
        }

        private void agregarNuevoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCargarNuevoTipoRespuesto form = new fCargarNuevoTipoRespuesto();
            form.Show();
        }

        private void modificarEliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fModificarEliminarRespuesto form = new fModificarEliminarRespuesto();
            form.Show();
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fListadoRespuesto form = new fListadoRespuesto();
            form.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        //    button17.Left = this.Width - 140;
        //    button17.Top = this.Height - 100;

        //    groupBox1.Width = this.Width - 1050;
        //    groupBox1.Height = this.Height - 600;

        //    groupBox2.Left = this.Width - 950;
        //    groupBox2.Width = this.Width - 1050;
        //    groupBox2.Height = this.Height - 200;

        //    groupBox3.Top = this.Height - 520;
        //    groupBox3.Width = this.Width - 1050;
        //    groupBox3.Height = this.Height - 700;
        //    richTextBox1.Width = this.Width - 1100;
        //    richTextBox1.Height = this.Height - 780;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            var contexto = new TallerContext();

            DateTime FechaDeHoy = DateTime.Today;

            //Tareas del Dia
            var datosDia = from tablaTareaPendiente in contexto.TareaPendietePrueba
                        where (tablaTareaPendiente.FechaRecordatorio == FechaDeHoy) ||
                        (tablaTareaPendiente.Interno.FechaProxService == FechaDeHoy)
                        select new
                        {
                            ID = tablaTareaPendiente.TareaPendienteId,
                            Tipo = tablaTareaPendiente.Tipo,                            
                            Fecha = tablaTareaPendiente.FechaRecordatorio,
                            ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                            Interno = tablaTareaPendiente.Interno.Interno,
                            Dominio = tablaTareaPendiente.Interno.Patente,
                            Sucursal = tablaTareaPendiente.Interno.Sucursal
                        };

            this.gridDia.DataSource = datosDia.ToList();       

            this.gridDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridDia.Columns[0].Width = 30;


            //Tareas Atrasadas
            var datosAtrasados = from tablaTareaPendiente in contexto.TareaPendietePrueba
                                 where (tablaTareaPendiente.FechaRecordatorio < FechaDeHoy) ||
                                 (tablaTareaPendiente.Interno.FechaProxService < FechaDeHoy)
                                 select new
                                 {
                                     ID = tablaTareaPendiente.TareaPendienteId,
                                     Tipo = tablaTareaPendiente.Tipo,
                                     Fecha = tablaTareaPendiente.FechaRecordatorio,
                                     ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                     Interno = tablaTareaPendiente.Interno.Interno,
                                     Dominio = tablaTareaPendiente.Interno.Patente,
                                     Sucursal = tablaTareaPendiente.Interno.Sucursal
                                 };

            this.gridAtras.DataSource = datosAtrasados.ToList();

            this.gridAtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridAtras.Columns[0].Width = 30;

            //Proximas tareas
            var fechaCom1 = FechaDeHoy.AddDays(1);
            var fechaCom2 = FechaDeHoy.AddDays(14);

            var datosProximos = from tablaTareaPendiente in contexto.TareaPendietePrueba
                                 where ((tablaTareaPendiente.FechaRecordatorio >= fechaCom1) && (tablaTareaPendiente.FechaRecordatorio <= fechaCom2)) ||
                                 ((tablaTareaPendiente.Interno.FechaProxService >= fechaCom1) && (tablaTareaPendiente.Interno.FechaProxService <= fechaCom2))
                                select new
                                 {
                                     ID = tablaTareaPendiente.TareaPendienteId,
                                     Tipo = tablaTareaPendiente.Tipo,                                     
                                     Fecha = tablaTareaPendiente.FechaRecordatorio,
                                     ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                     Interno = tablaTareaPendiente.Interno.Interno,
                                     Dominio = tablaTareaPendiente.Interno.Patente,
                                     Sucursal = tablaTareaPendiente.Interno.Sucursal
                                 };

            this.gridProx.DataSource = datosProximos.ToList();

            this.gridProx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.gridProx.Columns[0].Width = 30;

            //DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    fCargarCheck form = new fCargarCheck();
            //    form.Show();
            //}
            //else
            //{
            //    checkBox2.Checked = false;
            //}
        }

        private void gridDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;

            idTareaPendientePrueba = Convert.ToInt32(gridDia.Rows[e.RowIndex].Cells[0].Value);
            interno = gridDia.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void gridAtras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;

            idTareaPendientePrueba2 = Convert.ToInt32(gridAtras.Rows[e.RowIndex].Cells[0].Value);
            interno2 = gridAtras.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void gridProx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;

            idTareaPendientePrueba3 = Convert.ToInt32(gridProx.Rows[e.RowIndex].Cells[0].Value);
            interno3 = gridProx.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {               
               fCargarCheck form = new fCargarCheck(idTareaPendientePrueba,interno);
               form.Show();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fCargarCheck form = new fCargarCheck(idTareaPendientePrueba2,interno2);
                form.Show();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fCargarCheck form = new fCargarCheck(idTareaPendientePrueba3,interno3);
                form.Show();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Diagnostico diagnostico = new Diagnostico()
            {
                Estado = true,
                Observacion = "hoaasd",
                Parte = "motor",
                Sector = "tren delantero",
                TareaPendienteId = 1,
                };
            DiagnosticoDao diag = new DiagnosticoDao();
            diag.InsertDiagnostico(diagnostico);
            int x = 1;

        }



        //PARA REFRESCAR
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (verificar)
            {
                var contexto = new TallerContext();

                DateTime FechaDeHoy = DateTime.Today;

                //Tareas del Dia
                var datosDia = from tablaTareaPendiente in contexto.TareaPendietePrueba
                               where (tablaTareaPendiente.FechaRecordatorio == FechaDeHoy) ||
                               (tablaTareaPendiente.Interno.FechaProxService == FechaDeHoy)
                               select new
                               {
                                   ID = tablaTareaPendiente.TareaPendienteId,
                                   Tipo = tablaTareaPendiente.Tipo,
                                   Fecha = tablaTareaPendiente.FechaRecordatorio,
                                   ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                   Interno = tablaTareaPendiente.Interno.Interno,
                                   Dominio = tablaTareaPendiente.Interno.Patente,
                                   Sucursal = tablaTareaPendiente.Interno.Sucursal
                               };

                this.gridDia.DataSource = datosDia.ToList();

                this.gridDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.gridDia.Columns[0].Width = 30;


                //Tareas Atrasadas
                var datosAtrasados = from tablaTareaPendiente in contexto.TareaPendietePrueba
                                     where (tablaTareaPendiente.FechaRecordatorio < FechaDeHoy) ||
                                     (tablaTareaPendiente.Interno.FechaProxService < FechaDeHoy)
                                     select new
                                     {
                                         ID = tablaTareaPendiente.TareaPendienteId,
                                         Tipo = tablaTareaPendiente.Tipo,
                                         Fecha = tablaTareaPendiente.FechaRecordatorio,
                                         ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                         Interno = tablaTareaPendiente.Interno.Interno,
                                         Dominio = tablaTareaPendiente.Interno.Patente,
                                         Sucursal = tablaTareaPendiente.Interno.Sucursal
                                     };

                this.gridAtras.DataSource = datosAtrasados.ToList();

                this.gridAtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.gridAtras.Columns[0].Width = 30;



                //Proximas tareas
                var fechaCom1 = FechaDeHoy.AddDays(1);
                var fechaCom2 = FechaDeHoy.AddDays(14);

                var datosProximos = from tablaTareaPendiente in contexto.TareaPendietePrueba
                                    where ((tablaTareaPendiente.FechaRecordatorio >= fechaCom1) && (tablaTareaPendiente.FechaRecordatorio <= fechaCom2)) ||
                                    ((tablaTareaPendiente.Interno.FechaProxService >= fechaCom1) && (tablaTareaPendiente.Interno.FechaProxService <= fechaCom2))
                                    select new
                                    {
                                        ID = tablaTareaPendiente.TareaPendienteId,
                                        Tipo = tablaTareaPendiente.Tipo,
                                        Fecha = tablaTareaPendiente.FechaRecordatorio,
                                        ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                        Interno = tablaTareaPendiente.Interno.Interno,
                                        Dominio = tablaTareaPendiente.Interno.Patente,
                                        Sucursal = tablaTareaPendiente.Interno.Sucursal
                                    };

                this.gridProx.DataSource = datosProximos.ToList();

                this.gridProx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                this.gridProx.Columns[0].Width = 30;


                verificar = false;
            }
        }
    }
}
