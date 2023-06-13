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
    public partial class frmContato : Form
    {
        private BindingSource bnContato = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsContato = new DataSet();
        private DataSet dsCidade = new DataSet();

        public frmContato()
        {
            InitializeComponent();
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            try
            {
                Contato Con = new Contato();
                dsContato.Tables.Add(Con.Listar());
                bnContato.DataSource = dsContato.Tables["Contato"];
                dgvContato.DataSource = bnContato;
                bnvContato.BindingSource = bnContato;

                txtIDcontato.DataBindings.Add("TEXT", bnContato, "id_contato");
                txtNomeContato.DataBindings.Add("TEXT", bnContato, "nome_contato");
                txtEndereco.DataBindings.Add("TEXT", bnContato, "end_contato");
                txtTelefone.DataBindings.Add("TEXT", bnContato, "cel_contato");
                txtEmail.DataBindings.Add("TEXT", bnContato, "email_contato");
                dtpCadastro.DataBindings.Add("TEXT", bnContato, "dtcadastro_contato");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];

                cbxCidade.DisplayMember = "nome_cidade";

                cbxCidade.ValueMember = "id_cidade";

                cbxCidade.DataBindings.Add("SelectedValue", bnContato, "cidade_id_cidade");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }
            bnContato.AddNew();

            txtNomeContato.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            dtpCadastro.Enabled = true;

            

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;


            bInclusao = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeContato.Text == "" || txtNomeContato.Text.Length > 50)
            {
                MessageBox.Show("Nome do contato inválido");
            }
            else if(txtEndereco.Text == "" || txtEndereco.Text.Length > 100)
            {
                MessageBox.Show("Endereço inválido");
            }
            else if (txtEmail.Text == "" || txtEmail.Text.Length > 100)
            {
                MessageBox.Show("Email inválido");
            }
            else if(txtTelefone.Text == "" || txtTelefone.Text.Length > 15)
            {
                MessageBox.Show("Telefone inválido");
            }

            else
            {
                Contato RegCon = new Contato();

                RegCon.Nomecontato = txtNomeContato.Text;
                RegCon.Emailcontato = txtEmail.Text;
                RegCon.Endcontato = txtEndereco.Text;
                RegCon.Cidadeidcidade = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                RegCon.Celcontato = txtTelefone.Text;
                RegCon.Dtcadastrocontato = dtpCadastro.Value;


                if (bInclusao)
                {
                    if (RegCon.Salvar() > 0)
                    {
                        MessageBox.Show("Contato adicionado com sucesso");

                        txtNomeContato.Enabled = false;
                        cbxCidade.Enabled = false;
                        txtEndereco.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                        dtpCadastro.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        //recarrega o grid
                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsContato.Tables["Contato"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar contato!!!", "ERRO");
                    }
                }
                else
                {
                    RegCon.Idcontato = Convert.ToInt32(txtIDcontato.Text);

                    if (RegCon.Alterar() > 0)
                    {
                        MessageBox.Show("Contato alterado com sucesso!");


                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        txtIDcontato.Enabled = false;
                        txtNomeContato.Enabled = false;
                        cbxCidade.Enabled = false;
                        txtEmail.Enabled = false ;
                        txtEndereco.Enabled = false;
                        txtTelefone.Enabled = false;
                        dtpCadastro.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar contato!");
                    }
                }
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }

            txtNomeContato.Enabled = true;
            cbxCidade.Enabled = true;
            txtNomeContato.Focus();
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            dtpCadastro.Enabled = true;



            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Contato RegCon = new Contato();
                RegCon.Idcontato = Convert.ToInt16(txtIDcontato.Text);

                if (RegCon.Excluir() > 0)
                {
                    MessageBox.Show("Contato excluída com sucesso!");
                    Contato R = new Contato();
                    dsContato.Tables.Clear();
                    dsContato.Tables.Add(R.Listar());
                    bnContato.DataSource = dsContato.Tables["Contato"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir contato!");
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            bnContato.CancelEdit();

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            txtNomeContato.Enabled = false;
            cbxCidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            dtpCadastro.Enabled = false;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
