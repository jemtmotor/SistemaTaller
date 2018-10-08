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
    public partial class fListadoServicio : Form
    {
        public Boolean filtro;
        int id;
        string sucursal;
        string interno;
        string dominio;
        string tipo;
        DateTime fechaInicio;
        DateTime fechaFin;

        public fListadoServicio()
        {
            InitializeComponent();
        }

        public fListadoServicio(int ide, string suc, string inter, string dom, string tip, bool fil, DateTime fechaI, DateTime fechaF)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fFiltro1 form = new fFiltro1();
            form.Show();
            this.Close();
        }

        private void fListadoServicio_Load(object sender, EventArgs e)
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
                                Tipo = tablaTareaPendiente.Tipo,
                                Service = tablaTareaPendiente.Service,
                                InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                                DominioVehiculo = tablaTareaPendiente.Interno.Patente,
                                Fecha = tablaTareaPendiente.FechaRealizado,
                                Sucursal = tablaTareaPendiente.Interno.Sucursal,
                                Monto = tablaTareaPendiente.Monto,
                                ApellidoMecanico = tablaTareaPendiente.Mecanico.Apellido,
                                NombreMecanico = tablaTareaPendiente.Mecanico.Nombre,


                            };

                this.gridSerReal.DataSource = datos.ToList();
            }
            else
            {
                var txtID = id.ToString();
                if (id == 0)
                {
                    txtID = "";
                }


                var datos = from tablaTareaPendiente in contexto.TareaPendientes
                            where (tablaTareaPendiente.Id.ToString().Contains(txtID)) &&
                            (tablaTareaPendiente.Tipo.Contains(tipo)) &&
                            (tablaTareaPendiente.Interno.Sucursal.Contains(sucursal)) &&
                            (tablaTareaPendiente.Interno.Patente.Contains(dominio)) &&
                            (tablaTareaPendiente.Interno.Interno.Contains(interno)) &&
                            (tablaTareaPendiente.FechaTarea >= fechaInicio && tablaTareaPendiente.FechaTarea <= fechaFin)
                            select new
                            {
                                ID = tablaTareaPendiente.Id,
                                Tipo = tablaTareaPendiente.Tipo,
                                Service = tablaTareaPendiente.Service,
                                InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                                DominioVehiculo = tablaTareaPendiente.Interno.Patente,
                                Fecha = tablaTareaPendiente.FechaRealizado,
                                Sucursal = tablaTareaPendiente.Interno.Sucursal,
                                Monto = tablaTareaPendiente.Monto,
                                ApellidoMecanico = tablaTareaPendiente.Mecanico.Apellido,
                                NombreMecanico = tablaTareaPendiente.Mecanico.Nombre,
                            };

                this.gridSerReal.DataSource = datos.ToList();
            }

                this.gridSerReal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var contexto = new TallerContext();

            var datos = from tablaTareaPendiente in contexto.TareaPendientes
                            // from tablaMecanico in contexto.Mecanicos
                            // where tablaTareaPendiente.Mecanico.Id == tablaMecanico.Id
                        select new
                        {
                            ID = tablaTareaPendiente.Id,
                            Tipo = tablaTareaPendiente.Tipo,
                            Service = tablaTareaPendiente.Service,
                            InternoVehiculo = tablaTareaPendiente.Interno.Interno,
                            DominioVehiculo = tablaTareaPendiente.Interno.Patente,
                            Fecha = tablaTareaPendiente.FechaRealizado,
                            Sucursal = tablaTareaPendiente.Interno.Sucursal,
                            Monto = tablaTareaPendiente.Monto,
                            ApellidoMecanico = tablaTareaPendiente.Mecanico.Apellido,
                            NombreMecanico = tablaTareaPendiente.Mecanico.Nombre,


                        };

            this.gridSerReal.DataSource = datos.ToList();
            this.gridSerReal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
