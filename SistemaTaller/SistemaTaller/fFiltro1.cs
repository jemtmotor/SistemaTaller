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
    public partial class fFiltro1 : Form
    {
        public Boolean filtro;
        int id;
        string tipo;
        DateTime fechaInicio;
        DateTime fechaFin;
        double montoIn;
        double montoFn;
        string nombre;
        string apellido;

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

            ////Sucursal
            //VehiculosDao vecDao = new VehiculosDao();
            //vecDao.GetMecanicos()
            //var sucursales = from tablaVehiculo in contexto.Vehiculos
            //                 select  tablaVehiculo.Sucursal;
            //var listaSucursales = sucursales.ToList();
            //listaSucursales.Insert(0, "Sin Filtro");

            List<string> listaSucursales = new List<string>();

            listaSucursales.Add("Sin Filtro");
            listaSucursales.Add("San Salvador de Jujuy");
            listaSucursales.Add("San Pedro");
            listaSucursales.Add("Maimara");
            listaSucursales.Add("Humahuaca");

            cbxSucursal.DataSource = listaSucursales;

            chkCheck.Checked = true;
            chkReparacion.Checked = true;

            dateFechaInicio.Value = new DateTime(1980, 01, 01);
            dateFechaFin.Value = new DateTime(3018, 01, 01);

            dateFechaFin.Enabled = false;
            dateFechaInicio.Enabled = false;

            txtMonIni.Text = "0";
            txtMonFin.Text = "1000000000000000000";

            txtMonFin.Enabled = false;
            txtMonIni.Enabled = false;

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

                //MONTO INICIAL Y MONTO FINAL
                var montoInTx = txtMonIni.Text;
                montoInTx = montoInTx.Replace(" ", "");

                var montoFinTx = txtMonFin.Text;
                montoFinTx = montoFinTx.Replace(" ", "");

                if (montoFinTx != "" || montoInTx != "")
                {
                    montoIn = Convert.ToDouble(montoInTx);
                    montoFn = Convert.ToDouble(montoFinTx);
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

                //NOMBRE
                nombre = txtNombre.Text;
                nombre = nombre.Replace(" ", "");
                nombre = nombre.ToUpper();

                //APELLIDO
                apellido = txtApellido.Text;
                apellido = apellido.Replace(" ", "");
                apellido = apellido.ToUpper();

                //SUCURSAL
                var sucursal = cbxSucursal.SelectedValue.ToString();
                sucursal = sucursal.Replace(" ", "");


                if (cbxSucursal.SelectedIndex == 0)
                {
                    sucursal = "";
                }

                //FECHA INICIO Y FECHA FIN
                fechaFin = dateFechaFin.Value;
                fechaInicio = dateFechaInicio.Value;

                //
                fListadoServicio form = new fListadoServicio(id, sucursal, interno, dominio, tipo, filtro, fechaInicio, fechaFin, nombre, apellido, montoIn, montoFn);
                form.Show();
                this.Close();
            }
            catch (System.FormatException error)
            {
                MessageBox.Show("Los campos 'ID','Interno' y 'Montos' deben ser numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAc2_Click(object sender, EventArgs e)
        {
            if (txtMonIni.Enabled == false && txtMonFin.Enabled == false)
            {
                txtMonIni.Text = ""; 
                txtMonFin.Text = "";

                txtMonIni.Enabled = true;
                txtMonFin.Enabled = true;
            }
            else
            {
                txtMonIni.Text = "0";
                txtMonFin.Text = "100000000000000000000000000000000000000000";

                txtMonIni.Enabled = false;
                txtMonFin.Enabled = false;

            }
        }
    }
}
