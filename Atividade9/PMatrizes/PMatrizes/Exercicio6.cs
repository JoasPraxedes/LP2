using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatrizes
{
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int N = 10;
            string[] nomes = new string[N];
            int[] tamanho = new int[N];

            for (int i = 0; i < N; i++)
            {
                nomes[i] = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome " + (i + 1) + ":");
                tamanho[i] = nomes[i].Replace(" ", "").Length;
            }

            for (int i = 0; i < N; i++)
                lstbxNomes.Items.Add("O nome de " + nomes[i] + " tem " + tamanho[i] + " caracteres");

        }
    }
}
