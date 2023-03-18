namespace Atividade2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(56, 64);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(65, 16);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(56, 113);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(65, 16);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(56, 163);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(127, 61);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.Validated += new System.EventHandler(this.txtNum1_Validated);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(127, 110);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.Validated += new System.EventHandler(this.txtNum2_Validated);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(127, 160);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(36, 245);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(138, 245);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 23);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(246, 245);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicacao.TabIndex = 8;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(360, 245);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 23);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(283, 126);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(283, 64);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 293);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

