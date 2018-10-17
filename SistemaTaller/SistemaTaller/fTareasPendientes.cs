using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTaller.Modelos;

namespace SistemaTaller
{
    public partial class fTareasPendientes : Form
    {
        public Boolean filtro;
                 
        string sucursal;
        string interno;
        string dominio;
        string tipo;
        DateTime fechaInicio;
        DateTime fechaFin;


        public fTareasPendientes()
        {
            InitializeComponent();
        }

        public fTareasPendientes(string suc, string inter, string dom, string tip,bool fil,DateTime fechaI, DateTime fechaF)
        {
            InitializeComponent();

                              
            sucursal = suc;
            interno = inter;
            dominio = dom;
            tipo = tip;
            filtro = fil;
            fechaInicio = fechaI;
            fechaFin = fechaF;
        }

        public fTareasPendientes(Boolean fil)
        {
            filtro = fil;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fFiltroPendientes form = new fFiltroPendientes();
            form.Show();
            this.Close();
        }

        private void fTareasPendientes_Resize(object sender, EventArgs e)
        {
            //dataGridView1.Width = this.Width - 80;

            //label2.Left = this.Width - 1160;

            //groupBox1.Left = this.Width - 1260;

            //btnCancelar.Left = this.Width - 140;
            //btnCancelar.Top = this.Height - 100;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          

        }

        private void fTareasPendientes_Load(object sender, EventArgs e)
        {
           
            var contexto = new TallerContext();           

            if (filtro == false)
            {
                var datos = from tablaTareaPendiente in contexto.TareaPendietePrueba
                                // from tablaMecanico in contexto.Mecanicos
                                // where tablaTareaPendiente.Mecanico.Id == tablaMecanico.Id
                            select new
                            {
                                Tipo = tablaTareaPendiente.Tipo,                                
                                Fecha = tablaTareaPendiente.FechaRecordatorio,
                                ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                                InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                                Dominio = tablaTareaPendiente.Interno.Patente,
                                Sucursal = tablaTareaPendiente.Interno.Sucursal                               
                                

                            };

                this.dataGridView1.DataSource = datos.ToList();

            }
            else
            {                
                

                var datos = from tablaTarePendiente in contexto.TareaPendietePrueba
                                where (tablaTarePendiente.Tipo.Contains(tipo))&&                            
                                (tablaTarePendiente.Interno.Sucursal.Replace(" ","").Contains(sucursal))&&
                                (tablaTarePendiente.Interno.Patente.ToUpper().Contains(dominio))&&
                                (tablaTarePendiente.Interno.Interno.Contains(interno))&&
                                (tablaTarePendiente.FechaRecordatorio >= fechaInicio && tablaTarePendiente.FechaRecordatorio <= fechaFin)
                                select new
                                {
                                    Tipo = tablaTarePendiente.Tipo,                                    
                                    Fecha = tablaTarePendiente.FechaRecordatorio,
                                    ProximoService = tablaTarePendiente.Interno.FechaProxService,
                                    InternoVehiculo = tablaTarePendiente.Interno.Interno,
                                    Dominio = tablaTarePendiente.Interno.Patente,
                                    Sucursal = tablaTarePendiente.Interno.Sucursal
                                };
                this.dataGridView1.DataSource = datos.ToList();               

                



            }
                

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filtro = false;

            var contexto = new TallerContext();
            var datos = from tablaTareaPendiente in contexto.TareaPendietePrueba
                        select new
                        {
                            Tipo = tablaTareaPendiente.Tipo,                           
                            Fecha = tablaTareaPendiente.FechaRecordatorio,
                            ProximoService = tablaTareaPendiente.Interno.FechaProxService,
                            InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                            Dominio = tablaTareaPendiente.Interno.Patente,
                            Sucursal = tablaTareaPendiente.Interno.Sucursal

                        };

            this.dataGridView1.DataSource = datos.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
