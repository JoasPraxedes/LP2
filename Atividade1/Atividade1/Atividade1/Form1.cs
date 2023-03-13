using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            double raio;

            if(!double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
            }
            else if(raio <= 0) 
            {
                MessageBox.Show("Raio deve maior que zero");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double altura;

            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve maior que zero");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio;

            if (!double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
                textBox1.Focus();//volta no componente textBox1
            }
            else if (raio <= 0)
            {
                MessageBox.Show("Raio deve maior que zero");
                textBox1.Focus();
            }

            double altura;

            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                textBox2.Focus();
            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve maior que zero");
                textBox2.Focus();
            }

            double volume;

            volume = Math.PI * Math.Pow(raio, 2) * altura;
            textBox3.Text = volume.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
