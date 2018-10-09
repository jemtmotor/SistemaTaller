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
        int id;        
        string tipo;
        DateTime fechaInicio;
        DateTime fechaFin;
 
           
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

            chkCheck.Checked = true;
            chkReparacion.Checked = true;

            dateFechaInicio.Value = new DateTime(1980,01,01);
            dateFechaFin.Value = new DateTime(3018, 01, 01);

            dateFechaFin.Enabled = false;
            dateFechaInicio.Enabled = false;

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                filtro = true;

                //ID
                var idtxt = txtID.Text;
                idtxt = idtxt.Replace(" ", "");
                if (idtxt == "")
                {
                    id = 0;
                }
                else
                {                    
                    id = Convert.ToInt32(txtID.Text);                    
                }


                //TIPO
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



                //DOMINIO
                var dominio = cbxDominio.Text;
                dominio = dominio.Replace(" ", "");
                dominio = dominio.ToUpper();

                //INTERNO
                var interno = cbxInterno.Text;
                interno = interno.Replace(" ", "");

                if (interno != "")
                {                    
                    int controlFormatoInterno = Convert.ToInt32(cbxInterno.Text);                    
                }


                //SUCURSAL
                var sucursal = cbxSucursal.SelectedValue.ToString();
                sucursal = sucursal.Replace(" ", "");


                if (cbxSucursal.SelectedIndex == 0)
                {
                    sucursal = "";
                }

                fechaFin = dateFechaFin.Value;
                fechaInicio = dateFechaInicio.Value;

                //
                fTareasPendientes form = new fTareasPendientes(id, sucursal, interno, dominio, tipo, filtro, fechaInicio, fechaFin);
                form.Show();
                this.Close();

            }
            catch (System.FormatException error)
            {
                MessageBox.Show("Los campos 'ID' e 'Interno' deben ser numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateFechaFin.Enabled == false && dateFechaInicio.Enabled == false)
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
    }
}
