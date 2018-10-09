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
        int id;             
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

        public fTareasPendientes(int ide, string suc, string inter, string dom, string tip,bool fil,DateTime fechaI, DateTime fechaF)
        {
            InitializeComponent();

            id = ide;                    
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
                var datos = from tablaTareaPendiente in contexto.TareaPendientes
                                // from tablaMecanico in contexto.Mecanicos
                                // where tablaTareaPendiente.Mecanico.Id == tablaMecanico.Id
                            select new
                            {
                                ID = tablaTareaPendiente.Id,
                                Fecha = tablaTareaPendiente.FechaTarea,                               
                                Service = tablaTareaPendiente.Service,
                                Tipo = tablaTareaPendiente.Tipo,
                                Sucursal = tablaTareaPendiente.Interno.Sucursal,
                                InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                                Dominio = tablaTareaPendiente.Interno.Patente


                            };

                this.dataGridView1.DataSource = datos.ToList();

            }
            else
            {
                var txtID = id.ToString();
                if (id == 0)
                {
                    txtID = "";
                }
                

                var datos = from tablaTarePendiente in contexto.TareaPendientes
                                where (tablaTarePendiente.Id.ToString().Contains(txtID)) &&
                                (tablaTarePendiente.Tipo.Contains(tipo))&&                            
                                (tablaTarePendiente.Interno.Sucursal.Contains(sucursal))&&
                                (tablaTarePendiente.Interno.Patente.ToUpper().Contains(dominio))&&
                                (tablaTarePendiente.Interno.Interno.Contains(interno))&&
                                (tablaTarePendiente.FechaTarea >= fechaInicio && tablaTarePendiente.FechaTarea <= fechaFin)
                                select new
                                {
                                    ID = tablaTarePendiente.Id,
                                    Fecha = tablaTarePendiente.FechaTarea,                                    
                                    Service = tablaTarePendiente.Service,
                                    Tipo = tablaTarePendiente.Tipo,
                                    Sucursal = tablaTarePendiente.Interno.Sucursal,
                                    InternoVehiculo = tablaTarePendiente.Interno.Interno,
                                    Dominio = tablaTarePendiente.Interno.Patente
                                };
                this.dataGridView1.DataSource = datos.ToList();               

                



            }
                

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filtro = false;

            var contexto = new TallerContext();
            var datos = from tablaTareaPendiente in contexto.TareaPendientes
                        select new
                        {
                            ID = tablaTareaPendiente.Id,
                            Fecha = tablaTareaPendiente.FechaTarea,
                            Monto = tablaTareaPendiente.Monto,
                            Service = tablaTareaPendiente.Service,
                            Tipo = tablaTareaPendiente.Tipo,
                            Sucursal = tablaTareaPendiente.Interno.Sucursal,
                            InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                            Dominio = tablaTareaPendiente.Interno.Patente

                        };

            this.dataGridView1.DataSource = datos.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
