using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text.Length < 4 )
            {
                MessageBox.Show("Nome não pode ter menos do que 4 caracteres");
                Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter inválido");
                Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double salarioBruto = 0;
            double producao = Convert.ToDouble(txtProducao.Text);
            double gratificacao = Convert.ToDouble(txtGratificacao.Text);

            if(!double.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Salário inválido");
                Focus();
            }
            else
            {
                if(producao >= 100 && producao < 120)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 0 + 0.1 * 0) + gratificacao;

                    if (salarioBruto < 7000.01)
                    {
                        txtSalarioBruto.Text = salarioBruto.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Salário não pode ser maior do que R$7000.00");
                    }
                }

                else if(producao >= 120 && producao < 150)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 1 + 0.1 * 0) + gratificacao;

                    if(salarioBruto < 7000.01)
                    {
                        txtSalarioBruto.Text = salarioBruto.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Salário não pode ser maior do que R$7000.00");
                    }
                }

                else if(producao >= 150 && gratificacao == 0)
                {
                    salarioBruto = salario + salario*(0.05 * 1 + 0.1 * 1 + 0.1 * 1) + gratificacao;

                    if (salarioBruto < 7000.01)
                    {
                        txtSalarioBruto.Text = salarioBruto.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Salário não pode ser maior do que R$7000.00");
                    }
                }

               else if (producao >= 150 && gratificacao > 0)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 1 + 0.1 * 1) + gratificacao;
                    txtSalarioBruto.Text = salarioBruto.ToString("N2");
                }
            }
        }

    }
}
