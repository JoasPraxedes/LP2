using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; // globais
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido");
                //txtNum1.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            /*Opções possíveis:
              txtNum1.Text = ""; 
              txtNum2.Text = "";
              txtResultado.Text = "";
             txtNum1.Text = String.Empty;
             txtNum2.Text = String.Empty;
             txtResultado.Text = String.Empty;
                 */
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos !");
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos !");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                if(numero2 == 0)
                {
                    MessageBox.Show("Número 2 deve ser diferente de 0 !!!");
                }

                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Números inválidos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido");
                //txtNum2.Focus();
            }
        }
    }
}
