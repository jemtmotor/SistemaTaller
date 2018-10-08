﻿using System;
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
    public partial class fFiltro1 : Form
    {
        public Boolean filtro;
        int id;
        string tipo;
        DateTime fechaInicio;
        DateTime fechaFin;

        public fFiltro1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fListadoServicio form = new fListadoServicio();
            form.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fFiltro1_Load(object sender, EventArgs e)
        {
            var contexto = new TallerContext();

            //Sucursal
            var sucursales = from tablaVehiculo in contexto.Vehiculos
                             select tablaVehiculo.Sucursal;
            var listaSucursales = sucursales.ToList();
            listaSucursales.Insert(0, "Sin Filtro");
            cbxSucursal.DataSource = listaSucursales;

            chkCheck.Checked = true;
            chkReparacion.Checked = true;

            dateFechaInicio.Value = new DateTime(1980, 01, 01);
            dateFechaFin.Value = new DateTime(3018, 01, 01);

            dateFechaFin.Enabled = false;
            dateFechaInicio.Enabled = false;
        }

        private void btnAc1_Click(object sender, EventArgs e)
        {
            if (dateFechaFin.Enabled == false && dateFechaInicio.Enabled == false)
            {
                dateFechaInicio.Value = DateTime.Today;
                dateFechaFin.Value = DateTime.Today;

                dateFechaFin.Enabled = true;
                dateFechaInicio.Enabled = true;
            }
            else
            {
                dateFechaInicio.Value = new DateTime(1980, 01, 01);
                dateFechaFin.Value = new DateTime(3018, 01, 01);

                dateFechaFin.Enabled = false;
                dateFechaInicio.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtro = true;

            var idtxt = txtID.Text;
            idtxt = idtxt.Replace(" ", "");
            if (idtxt == "")
            {
                id = 0;
            }
            else
            {
                try
                {
                    id = Convert.ToInt32(txtID.Text);
                }
                catch (System.FormatException error)
                {
                    MessageBox.Show("El ID debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }



            if ((chkCheck.Checked == true && chkReparacion.Checked == true) || (chkCheck.Checked == false && chkReparacion.Checked == false))
            {
                tipo = "";
            }
            else
            {
                if (chkCheck.Checked == true && chkReparacion.Checked == false)
                {
                    tipo = "Chequeo";
                }
                if (chkCheck.Checked == false && chkReparacion.Checked == true)
                {
                    tipo = "Reparacion";
                }
            }




            var dominio = cbxDominio.Text;
            dominio = dominio.Replace(" ", "");

            var interno = cbxInterno.Text;
            interno = interno.Replace(" ", "");

            if (interno != "")
            {
                try
                {
                    int controlFormatoInterno = Convert.ToInt32(cbxInterno.Text);
                }
                catch (System.FormatException error)
                {
                    MessageBox.Show("El Numero de Interno debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            var sucursal = cbxSucursal.SelectedValue.ToString();
            sucursal = sucursal.Replace(" ", "");


            if (cbxSucursal.SelectedIndex == 0)
            {
                sucursal = "";
            }

            fechaFin = dateFechaFin.Value;
            fechaInicio = dateFechaInicio.Value;

            fListadoServicio form = new fListadoServicio(id, sucursal, interno, dominio, tipo, filtro, fechaInicio, fechaFin);
            form.Show();
            this.Close();
        }
    }
}
