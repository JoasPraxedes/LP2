namespace PClasses
{
    partial class frmMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensa = new System.Windows.Forms.Label();
            this.lblEntradaEmpresa = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstanciarComParametro = new System.Windows.Forms.Button();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(84, 102);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 16);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 139);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensa
            // 
            this.lblSalarioMensa.AutoSize = true;
            this.lblSalarioMensa.Location = new System.Drawing.Point(84, 190);
            this.lblSalarioMensa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioMensa.Name = "lblSalarioMensa";
            this.lblSalarioMensa.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioMensa.TabIndex = 2;
            this.lblSalarioMensa.Text = "Salário Mensal";
            // 
            // lblEntradaEmpresa
            // 
            this.lblEntradaEmpresa.AutoSize = true;
            this.lblEntradaEmpresa.Location = new System.Drawing.Point(84, 235);
            this.lblEntradaEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntradaEmpresa.Name = "lblEntradaEmpresa";
            this.lblEntradaEmpresa.Size = new System.Drawing.Size(162, 16);
            this.lblEntradaEmpresa.TabIndex = 3;
            this.lblEntradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(264, 98);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(132, 22);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(264, 135);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(377, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(264, 186);
            this.txtSalarioMensal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtEntradaEmpresa
            // 
            this.txtEntradaEmpresa.Location = new System.Drawing.Point(264, 235);
            this.txtEntradaEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntradaEmpresa.Name = "txtEntradaEmpresa";
            this.txtEntradaEmpresa.Size = new System.Drawing.Size(132, 22);
            this.txtEntradaEmpresa.TabIndex = 7;
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(143, 363);
            this.btnInstanciarMensalista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(184, 66);
            this.btnInstanciarMensalista.TabIndex = 8;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.BtnInstanciarMensalista_Click);
            // 
            // btnInstanciarComParametro
            // 
            this.btnInstanciarComParametro.Location = new System.Drawing.Point(392, 363);
            this.btnInstanciarComParametro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstanciarComParametro.Name = "btnInstanciarComParametro";
            this.btnInstanciarComParametro.Size = new System.Drawing.Size(205, 66);
            this.btnInstanciarComParametro.TabIndex = 9;
            this.btnInstanciarComParametro.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciarComParametro.UseVisualStyleBackColor = true;
            this.btnInstanciarComParametro.Click += new System.EventHandler(this.btnInstanciarComParametro_Click);
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNao);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(727, 82);
            this.gbxHomeOffice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHomeOffice.Size = new System.Drawing.Size(267, 123);
            this.gbxHomeOffice.TabIndex = 10;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(21, 65);
            this.rbtnNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(57, 20);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(21, 37);
            this.rbtnSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(51, 20);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.btnInstanciarComParametro);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblEntradaEmpresa);
            this.Controls.Add(this.lblSalarioMensa);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensa;
        private System.Windows.Forms.Label lblEntradaEmpresa;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtEntradaEmpresa;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstanciarComParametro;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
    }
}