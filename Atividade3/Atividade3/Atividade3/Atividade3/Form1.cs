using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;  
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida !");
            }
            else if (altura <= 0)
            {
                MessageBox.Show("A altura deve ser maior que zero !");
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtPeso.Text, out peso) && (double.TryParse(txtAltura.Text, out altura)))
            {
                imc = peso / Math.Pow(altura, 2);
                imc = Math.Round(imc, 1);

                txtIMC.Text = imc.ToString();

            }

            if(imc < 18.5)
            {
                MessageBox.Show("Magreza. Obesidade Grau 0 !");
            }
            else if(imc < 25)
            {
                MessageBox.Show("Normal. Obesidade Grau 0 !");
            }
            else if(imc < 30)
            {
                MessageBox.Show("Sobrepeso. Obesidade Grau 1 !");
            }
            else if(imc < 40)
            {
                MessageBox.Show("Obesidade. Obesidade Grau 2 !");
            }
            else
            {
                MessageBox.Show("Obesidade Grave. Obesidade Grau 3 !");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtIMC.Clear();
        }

        private void TxtPeso_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido !");
            }
            else if(peso <= 0)
            {
                MessageBox.Show("O peso deve ser maior que zero !");
            }
        }
    }
}
