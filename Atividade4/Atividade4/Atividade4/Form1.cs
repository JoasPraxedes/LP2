using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        double numero1, numero2, numero3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
        }

        private void txtNum3_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum3.Text, out numero3))
            {
                MessageBox.Show("Número 3 inválido !");
            }
            else if (numero3 <= 0)
            {
                MessageBox.Show("Número 3 tem que ser maior que zero !");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if((numero1 < (numero2 + numero3)) && (numero1 > Math.Abs(numero2 - numero3)) &&
                (numero2 < (numero1 + numero3)) && (numero2 > Math.Abs(numero1 - numero3)) &&
                (numero3 < (numero2 + numero1)) && (numero3 > Math.Abs(numero2 - numero1)) && 
                (numero1 == numero2) && (numero2 == numero3))
            {
                MessageBox.Show("É triângulo,e é equilátero");
            }
            else if ((numero1 < (numero2 + numero3)) && (numero1 > Math.Abs(numero2 - numero3)) &&
                (numero2 < (numero1 + numero3)) && (numero2 > Math.Abs(numero1 - numero3)) &&
                (numero3 < (numero2 + numero1)) && (numero3 > Math.Abs(numero2 - numero1)) &&
                (numero1 == numero2) || (numero1 == numero3) || (numero2 == numero3))
            {
                MessageBox.Show("É triângulo,e é isósceles");
            }
            else
            {
                MessageBox.Show("É triângulo,e é escaleno");
            }
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido !");
            }
            else if(numero1 <= 0)
            {
                MessageBox.Show("Número 1 tem que ser maior que zero !");
            }
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido !");
            }
            else if (numero2 <= 0)
            {
                MessageBox.Show("Número 2 tem que ser maior que zero !");
            }
        }
    }
}
