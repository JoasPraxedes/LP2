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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdnumeros_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (char.IsNumber(rchtxtTexto.Text[i]))
                    quantidade += 1;
            }

            MessageBox.Show("A quantidade de números é: " + quantidade);
        }

        private void btnEspacobranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < rchtxtTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    MessageBox.Show("O primeiro espaço em branco está na posição: " + i);
                    break;
                }
                else
                    i++;
            }
        }

        private void btnQtdecaracteralfabeticos_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if (char.IsLetter(c))
                    i++;
            }
            MessageBox.Show("A quantidade de caracteres alfabéticos é: " + i);
        }
    }
}
