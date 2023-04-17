using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio5 : Form
    {
        int numero1, numero2;
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido !");
            }
            else if(numero2 < numero1)
            {
                MessageBox.Show("Número 2 inválido !");
            }
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido !");
            }

            if (!int.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido !");
            }

            if (numero2 > numero1)
            {
                Random random = new Random();
                numero1 = Convert.ToInt32(txtNumero1.Text);
                numero2 = Convert.ToInt32(txtNumero2.Text);

                int valor = random.Next(numero1,numero2);
                MessageBox.Show(valor.ToString());
            }
        }
        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNumero1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido !");
            }
        }

    }
}