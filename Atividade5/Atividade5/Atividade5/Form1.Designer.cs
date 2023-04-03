namespace Atividade5
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINNS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemino = new System.Windows.Forms.RadioButton();
            this.pnlEstadoCivil = new System.Windows.Forms.Panel();
            this.ckbxEstadoCivil = new System.Windows.Forms.CheckBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.pnlEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 46);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(16, 87);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(84, 16);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(16, 128);
            this.lblFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(108, 16);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // lblINNS
            // 
            this.lblINNS.AutoSize = true;
            this.lblINNS.Location = new System.Drawing.Point(16, 309);
            this.lblINNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblINNS.Name = "lblINNS";
            this.lblINNS.Size = new System.Drawing.Size(91, 16);
            this.lblINNS.TabIndex = 3;
            this.lblINNS.Text = "Aliquota INNS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(16, 350);
            this.lblIRPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(89, 16);
            this.lblIRPF.TabIndex = 4;
            this.lblIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(16, 389);
            this.lblSalarioFamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioFamilia.TabIndex = 5;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(148, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 6;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.txtNome.Validated += new System.EventHandler(this.TxtNome_Validated);
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(123, 305);
            this.txtINSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(132, 22);
            this.txtINSS.TabIndex = 8;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Location = new System.Drawing.Point(123, 342);
            this.txtIRPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(132, 22);
            this.txtIRPF.TabIndex = 9;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(123, 385);
            this.txtSalarioFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioFamilia.TabIndex = 10;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(148, 87);
            this.mskbxSalarioBruto.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxSalarioBruto.Mask = "99990.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(132, 22);
            this.mskbxSalarioBruto.TabIndex = 11;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(109, 175);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(212, 31);
            this.btnVerificar.TabIndex = 12;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(11, 432);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioLiquido.TabIndex = 13;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(148, 126);
            this.nudFilhos.Margin = new System.Windows.Forms.Padding(4);
            this.nudFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(160, 22);
            this.nudFilhos.TabIndex = 14;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFemino);
            this.gbxSexo.Location = new System.Drawing.Point(501, 30);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Size = new System.Drawing.Size(267, 123);
            this.gbxSexo.TabIndex = 15;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(39, 63);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(39, 20);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemino
            // 
            this.rbtnFemino.AutoSize = true;
            this.rbtnFemino.Location = new System.Drawing.Point(39, 34);
            this.rbtnFemino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFemino.Name = "rbtnFemino";
            this.rbtnFemino.Size = new System.Drawing.Size(36, 20);
            this.rbtnFemino.TabIndex = 0;
            this.rbtnFemino.TabStop = true;
            this.rbtnFemino.Text = "F";
            this.rbtnFemino.UseVisualStyleBackColor = true;
            // 
            // pnlEstadoCivil
            // 
            this.pnlEstadoCivil.Controls.Add(this.ckbxEstadoCivil);
            this.pnlEstadoCivil.Location = new System.Drawing.Point(501, 160);
            this.pnlEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEstadoCivil.Name = "pnlEstadoCivil";
            this.pnlEstadoCivil.Size = new System.Drawing.Size(267, 103);
            this.pnlEstadoCivil.TabIndex = 16;
            // 
            // ckbxEstadoCivil
            // 
            this.ckbxEstadoCivil.AutoSize = true;
            this.ckbxEstadoCivil.Location = new System.Drawing.Point(39, 39);
            this.ckbxEstadoCivil.Name = "ckbxEstadoCivil";
            this.ckbxEstadoCivil.Size = new System.Drawing.Size(77, 20);
            this.ckbxEstadoCivil.TabIndex = 0;
            this.ckbxEstadoCivil.Text = "Casado";
            this.ckbxEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(401, 305);
            this.lblDescontoINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(100, 16);
            this.lblDescontoINSS.TabIndex = 17;
            this.lblDescontoINSS.Text = "Desconto INNS";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(123, 428);
            this.txtSalarioLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(132, 22);
            this.txtSalarioLiquido.TabIndex = 18;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(519, 300);
            this.txtDescontoINSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(132, 22);
            this.txtDescontoINSS.TabIndex = 19;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(519, 342);
            this.txtDescontoIRPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(132, 22);
            this.txtDescontoIRPF.TabIndex = 20;
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(400, 346);
            this.lblDescontoIRPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(101, 16);
            this.lblDescontoIRPF.TabIndex = 21;
            this.lblDescontoIRPF.Text = "Desconto IRPF ";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(16, 224);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(62, 16);
            this.lblDados.TabIndex = 22;
            this.lblDados.Text = "lblDados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.pnlEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINNS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlEstadoCivil.ResumeLayout(false);
            this.pnlEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblINNS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemino;
        private System.Windows.Forms.Panel pnlEstadoCivil;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.CheckBox ckbxEstadoCivil;
        private System.Windows.Forms.Label lblDados;
    }
}

