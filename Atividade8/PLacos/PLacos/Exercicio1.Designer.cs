namespace PLacos
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnQtdeLetraR = new System.Windows.Forms.Button();
            this.btnParesLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(42, 42);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(365, 157);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(42, 234);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(101, 42);
            this.btnEspacoBranco.TabIndex = 1;
            this.btnEspacoBranco.Text = "Quanto espaços em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.BtnEspacoBranco_Click);
            // 
            // btnQtdeLetraR
            // 
            this.btnQtdeLetraR.Location = new System.Drawing.Point(176, 234);
            this.btnQtdeLetraR.Name = "btnQtdeLetraR";
            this.btnQtdeLetraR.Size = new System.Drawing.Size(107, 42);
            this.btnQtdeLetraR.TabIndex = 2;
            this.btnQtdeLetraR.Text = "Nº de vezes que aparece a letra \"r\"";
            this.btnQtdeLetraR.UseVisualStyleBackColor = true;
            this.btnQtdeLetraR.Click += new System.EventHandler(this.BtnQtdeLetraR_Click);
            // 
            // btnParesLetras
            // 
            this.btnParesLetras.Location = new System.Drawing.Point(318, 234);
            this.btnParesLetras.Name = "btnParesLetras";
            this.btnParesLetras.Size = new System.Drawing.Size(89, 42);
            this.btnParesLetras.TabIndex = 3;
            this.btnParesLetras.Text = "Nº de pares de letras";
            this.btnParesLetras.UseVisualStyleBackColor = true;
            this.btnParesLetras.Click += new System.EventHandler(this.BtnParesLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParesLetras);
            this.Controls.Add(this.btnQtdeLetraR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnQtdeLetraR;
        private System.Windows.Forms.Button btnParesLetras;
    }
}