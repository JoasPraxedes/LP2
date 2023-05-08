using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnParesLetras_Click(object sender, EventArgs e)
        {
            /*  char letraAnterior = '\0';
              int numPares = 0;

              for(var i=0;i < rchtxtFrase.Text.Length;i++)
              {
                  if(rchtxtFrase.Text[i] == letraAnterior)
                  {
                      numPares += 1;
                  }

                  letraAnterior = rchtxtFrase.Text[i];
              }
              MessageBox.Show("Nº pares de letras: " + numPares.ToString());*/

            int numPares = 0;

            for (var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (rchtxtFrase.Text[i] == rchtxtFrase.Text[i + 1])
                {
                    numPares += 1;
                }
            }
            MessageBox.Show("Nº pares de letras: " + numPares.ToString());
        }

        private void BtnQtdeLetraR_Click(object sender, EventArgs e)
        {
            int numR = 0;

            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.ToUpper(rchtxtFrase.Text[i]) == 'R')
                {
                    numR += 1;
                }
            }
            MessageBox.Show("Nº de letras R: " + numR.ToString());
        }

        private void BtnEspacoBranco_Click(object sender, EventArgs e)
        {
            int numEspacoBranco = 0;

            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                {
                    numEspacoBranco += 1;
                }
            }
            MessageBox.Show("Nº de espaço em branco: " + numEspacoBranco.ToString());
        }
    }
}
