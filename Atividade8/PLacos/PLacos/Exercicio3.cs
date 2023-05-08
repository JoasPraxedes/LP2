using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PLacos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            string frase = txtFrase.Text.Trim().ToLower().Replace(" ", "");
                string fraseReversa = new string(frase.Reverse().ToArray());


            if (frase == fraseReversa)
            {
                MessageBox.Show("A frase é um palíndromo !!");
            }
            else
            {
                MessageBox.Show("A frase não é um palíndromo !!");

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
        }
    }
}
