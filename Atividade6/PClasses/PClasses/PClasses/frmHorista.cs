using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalHr.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHrs.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);

            if(rbtnSim.Checked)
            {
                objHorista.HomeOffice = 'S';
            }
            else
            {
                objHorista.HomeOffice = 'N';
            }

            MessageBox.Show("Matricula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" 
                + "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " 
                + objHorista.SalarioBruto().ToString("N2") + "\n" + "Tempo de Empresa(dias): " + objHorista.TempoTrabalho()
                + "\n" + "Dias de Falta: " + objHorista.DiasFalta + "\n" + objHorista.VerificaHome()) ;
        }
    }
}
