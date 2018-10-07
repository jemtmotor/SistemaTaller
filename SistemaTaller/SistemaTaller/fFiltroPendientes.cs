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
    public partial class fFiltroPendientes : Form
    {
        public Boolean filtro;
        bool chequeo;
        bool service;
        bool reparacion;
        bool aplicar;
           
        public fFiltroPendientes()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fTareasPendientes form = new fTareasPendientes();
            form.Show();
            this.Close();
        }

        private void fFiltroPendientes_Load(object sender, EventArgs e)
        {
            var contexto = new TallerContext();

            //Sucursal
            var sucursales = from tablaVehiculo in contexto.Vehiculos
                             select tablaVehiculo.Sucursal;
            var listaSucursales = sucursales.ToList();
            listaSucursales.Insert(0, "Sin Filtro");
            cbxSucursal.DataSource = listaSucursales;



            //Tipo
            var tipos = from tablaVehiculo in contexto.Vehiculos
                        select tablaVehiculo.Tipo;
            var listaTipos = tipos.ToList();
            listaTipos.Insert(0, "Sin Filtro");
            cbxTipo.DataSource = listaTipos;

            reparacion = false;
            service = false;
            chequeo = false;
            aplicar = false;
            
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            filtro = true;

            var id = txtID.Text;
            id = id.Replace(" ", "");
                        

            if (chkCheck.Checked == true)
            {
                chequeo = true;
            }

            if (chkReparacion.Checked == true)
            {
                reparacion = true;
            }

            if (chkService.Checked == true)
            {
                service = true;
            }

            var dominio = cbxDominio.Text;
            dominio = dominio.Replace(" ", "");

            var interno = cbxInterno.Text;
            interno = interno.Replace(" ", "");

            var sucursal = cbxSucursal.SelectedValue.ToString();
            var tipo = cbxTipo.SelectedValue.ToString();

            if (sucursal == "Sin Filtro")
            {
                sucursal = "";
            }

            if (tipo == "Sin Filtro")
            {
                tipo = "";
            }


            fTareasPendientes form = new fTareasPendientes(id,chequeo,reparacion,service,sucursal,interno,dominio,tipo);
            form.Show();
        }
    }
}
