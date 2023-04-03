using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text.Length < 10)
            {
                MessageBox.Show("Nome não pode ter menos do que 10 caracteres");
                Focus();
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter inválido");
                Focus();
            }
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double salarioBruto = 0;
            double salarioFamilia = 0;
            double salarioLiquido = 0;
            double descontoINSS = 0;
            double descontoIRPF = 0;

            if (!double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salário Bruto inválido");
                Focus();
            }
            else
            {
                if (salarioBruto <= 0)
                {
                    MessageBox.Show("Salário Bruto deve ser maior que zero");
                    Focus();
                }

                //Calculo INSS
                if(salarioBruto <= 800.47)
                {
                    txtINSS.Text = "7,65%";
                    descontoINSS = 0.0765 * salarioBruto;
                }
                else if(salarioBruto <= 1050)
                {
                    txtINSS.Text = "8,65%";
                    descontoINSS = 0.0865 * salarioBruto;
                }
                else if(salarioBruto <= 1400.77)
                {
                    txtINSS.Text = " 9,00%";
                    descontoINSS = 0.09 * salarioBruto;
                }
                else if(salarioBruto <= 2801.56)
                {
                    txtINSS.Text = " 11,00%";
                    descontoINSS = 0.11 * salarioBruto;
                }
                else
                {
                    txtINSS.Text = "Teto";
                    descontoINSS = 308.17;
                }
                txtDescontoINSS.Text = descontoINSS.ToString("N2");
                //Calculo IRPF
                if (salarioBruto <= 1257.12)
                {
                    txtIRPF.Text = "0";
                }
                else if(salarioBruto <= 2512.08)
                {
                    txtIRPF.Text = "15,00%";
                    descontoIRPF = 0.15 * salarioBruto;
                }
                else
                {
                    txtIRPF.Text = "27,50%";
                    descontoIRPF = 0.275 * salarioBruto;
                }
                txtDescontoIRPF.Text = descontoIRPF.ToString("N2");

                double numFilhos = (Double)nudFilhos.Value;
               
                //Calculo Salario Familia
                if (numFilhos > 0)
                {
                    if (salarioBruto <= 435.52)
                    {
                        salarioFamilia = 22.33 * numFilhos;
                    }
                    else if (salarioBruto <= 654.61)
                    {
                        salarioFamilia = 15.74 * numFilhos;

                    }
                    else
                    {
                        txtSalarioFamilia.Text = "0,00";
                    }
                }

                txtSalarioFamilia.Text = salarioFamilia.ToString("N2");
                
                //Calculo Salario Liquido
                salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;

                txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

                //label com texto
                lblDados.Text = "Os descontos do salário " + (rbtnMasculino.Checked ? "do Sr." : "da Sra.") + txtNome.Text +
                    " que é " + (ckbxEstadoCivil.Checked ? "casado(a)" : "solteiro(a)") + "  e que tem: " +
                    Convert.ToString(numFilhos) + " filho(s)";  
            }

        }

    }
}
