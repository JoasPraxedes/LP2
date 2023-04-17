namespace PMenu
{
    partial class frmExercicio3
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
            this.btnRemovePrimeiro = new System.Windows.Forms.Button();
            this.btnRemovePrimeiroReplace = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemovePrimeiro
            // 
            this.btnRemovePrimeiro.Location = new System.Drawing.Point(27, 168);
            this.btnRemovePrimeiro.Name = "btnRemovePrimeiro";
            this.btnRemovePrimeiro.Size = new System.Drawing.Size(120, 74);
            this.btnRemovePrimeiro.TabIndex = 0;
            this.btnRemovePrimeiro.Text = "Remove o primeiro do segundo";
            this.btnRemovePrimeiro.UseVisualStyleBackColor = true;
            this.btnRemovePrimeiro.Click += new System.EventHandler(this.BtnRemovePrimeiro_Click);
            // 
            // btnRemovePrimeiroReplace
            // 
            this.btnRemovePrimeiroReplace.Location = new System.Drawing.Point(153, 168);
            this.btnRemovePrimeiroReplace.Name = "btnRemovePrimeiroReplace";
            this.btnRemovePrimeiroReplace.Size = new System.Drawing.Size(127, 74);
            this.btnRemovePrimeiroReplace.TabIndex = 1;
            this.btnRemovePrimeiroReplace.Text = "Remove o primeiro do segundo(Replace )";
            this.btnRemovePrimeiroReplace.UseVisualStyleBackColor = true;
            this.btnRemovePrimeiroReplace.Click += new System.EventHandler(this.BtnRemovePrimeiroReplace_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(286, 168);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(109, 74);
            this.btnInverte.TabIndex = 2;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.BtnInverte_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(101, 61);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 6;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(100, 97);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 7;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(43, 64);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 8;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(42, 100);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 9;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemovePrimeiroReplace);
            this.Controls.Add(this.btnRemovePrimeiro);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemovePrimeiro;
        private System.Windows.Forms.Button btnRemovePrimeiroReplace;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}