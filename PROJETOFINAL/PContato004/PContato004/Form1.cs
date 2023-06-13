using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato004
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   Data Source = APOLO; Initial Catalog = LP2; User ID = BD2221004

            try
            {
                conexao = new SqlConnection("Data Source = APOLO; Initial Catalog = LP2; User ID = BD2221004; PASSWORD=JkLiPa2003");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de Banco de Dados =/" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros erros +/" + ex.Message);
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frmCidade>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe!");
                Application.OpenForms["frmCidade"].BringToFront();
            }
            else
            {
                frmCidade ObjC = new frmCidade();
                ObjC.MdiParent = this;
                ObjC.WindowState = FormWindowState.Maximized;
                ObjC.Show();
            }
          

        }

        private void ContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmContato>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe!");
                Application.OpenForms["frmContato"].BringToFront();
            }
            else
            {
                frmContato ObjCont = new frmContato();
                ObjCont.MdiParent = this;
                ObjCont.WindowState = FormWindowState.Maximized;
                ObjCont.Show();
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe!");
                Application.OpenForms["frmSobre"].BringToFront();
            }
            else
            {
                frmSobre ObjSobre = new frmSobre();
                ObjSobre.MdiParent = this;
                ObjSobre.WindowState = FormWindowState.Maximized;
                ObjSobre.Show();
            }
        }
    }
}
