using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Reflection;

namespace PMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExerc1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";

            for(var i=0;i<20;i++) 
            {
                auxiliar = Interaction.InputBox("Digite o número" + (i + 1).ToString(),
                    "Entrada de Dados");
                if(!int.TryParse(auxiliar, out Vetor[i])) 
                {
                    MessageBox.Show("número inválido");
                    i--;
                }
            }

            //ordem inversa
            auxiliar = "";
            for(var i=19;i>=0;i--)
            {
                auxiliar += "\n" + Vetor[i].ToString();
            }
                MessageBox.Show(auxiliar);
            
            //ordem inversa usando reverse
            Array.Reverse(Vetor);
            auxiliar = "";

            foreach(var j in Vetor) 
            { 
                auxiliar = "\n" + j.ToString();
            }
                MessageBox.Show(auxiliar);
        }

        private void btnExerc2_Click(object sender, EventArgs e)
        {
            double[] Quantidade = new double[10];
            double[] Preco = new double[10];

            string auxiliar = "";
            double faturamento = 0;
            for(var i=0;i<10;i++) 
            {
                auxiliar = Interaction.InputBox("Digite Quantidade" + (i + 1).ToString(),
                    "Entrada das Quantidades");
                if(!double.TryParse(auxiliar,out Quantidade[i])) 
                {
                    MessageBox.Show("Quantidade Inválida");
                    i--;
                }
                else
                {
                    while (Preco[i] <= 0)
                    {
                        auxiliar = "";
                        auxiliar = Interaction.InputBox("Digite o Preço" + (i + 1).ToString(),
                            "Entrada dos Preços");
                        if(double.TryParse(auxiliar, out Preco[i]))
                        {
                            faturamento += Quantidade[i] * Preco[i]; 
                        }
                        else
                        {
                            MessageBox.Show("Preço Inválido");
                        }
                    }
                }
            }
            MessageBox.Show("Faturamento em R$: " + faturamento.ToString());
        }

        private void btnExerc3_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane","André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0; 
            Int32 N = Alunos.Length; 
            for (I = 0; I < N - 1; I++) 
            { 
                Total += Alunos[I].Length; 
            }
            MessageBox.Show("Total: " + Total.ToString());
        }

        private void btnExerc4_Click(object sender, EventArgs e)
        {
            
            ArrayList Alunos = new ArrayList();
            Alunos.Add("Ana");
            Alunos.Add("André");
            Alunos.Add("Débora");
            Alunos.Add("Fátima");
            Alunos.Add("João");
            Alunos.Add("Janete");
            Alunos.Add("Otávio");
            Alunos.Add("Marcelo");
            Alunos.Add("Pedro");
            Alunos.Add("Thais");

            Alunos.Remove("Otávio");

            foreach (string aluno in Alunos)
            {
                MessageBox.Show("Aluno(a): " + aluno + "\n");
            }
        }

        private void btnExerc5_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            string auxiliar = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                     auxiliar = Interaction.InputBox($"Digite a nota " + (j + 1) + " do aluno: " + (i + 1));
                    if (!double.TryParse(auxiliar, out notas[i, j]))
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }
                }
            }

            string mensagem = "Média dos alunos:\n\n";
            for (int i = 0; i < 20; i++)
            {
                double soma = 0;
                for (int j = 0; j < 3; j++)
                {
                    soma += notas[i, j];
                }
                double media = soma / 3;
                mensagem +="Aluno " + (i + 1).ToString() +": " + (media).ToString() + "\n";
            }

            MessageBox.Show(mensagem + "\n");
        }

        private void btnExerc6_Click(object sender, EventArgs e)
        {
            Exercicio6 exercicio6 = new Exercicio6();
            exercicio6.Show();
        }
    }
}
    
