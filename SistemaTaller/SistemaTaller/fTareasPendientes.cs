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
    public partial class fTareasPendientes : Form
    {
        public fTareasPendientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fFiltroPendientes form = new fFiltroPendientes();
            form.Show();
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
    }
}
