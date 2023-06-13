using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato004
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["Cidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtIDcidade.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtNOMEcidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxUFcidade.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao listar cidade");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();

            txtNOMEcidade.Enabled = true;
            cbxUFcidade.Enabled = true;
            cbxUFcidade.SelectedIndex = 0;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;


            bInclusao = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNOMEcidade.Text == "" || txtNOMEcidade.Text.Length < 3)
            {
                MessageBox.Show("Nome da cidade inválido");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt32(txtIDcidade.Text);
                RegCid.Nomecidade = txtNOMEcidade.Text;
                RegCid.Ufcidade = cbxUFcidade.SelectedItem.ToString();

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso");

                        txtNOMEcidade.Enabled = false;
                        cbxUFcidade.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        //recarrega o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!!!", "ERRO");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");


                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        txtIDcidade.Enabled = false;
                        txtNOMEcidade.Enabled = false;
                        cbxUFcidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar cidade!");
                    }
                }
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            txtNOMEcidade.Enabled = true;
            cbxUFcidade.Enabled = true;
            txtNOMEcidade.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtIDcidade.Text);
               
                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["Cidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            txtNOMEcidade.Enabled = false;
            cbxUFcidade.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
