using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTaller
{
    public partial class Form1 : Form
    {
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
            if(checkBox1.Checked == true)
            {
                DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Taea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    fCargarReparacion form = new fCargarReparacion();
                    form.Show();
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }          

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
            if (checkBox2.Checked == true)
            {
                DialogResult result = MessageBox.Show("Desea cargar la tarea?", "Cargar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    fCargarCheck form = new fCargarCheck();
                    form.Show();
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }

        }
    }
}
