namespace PMenu
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnQtdnumeros = new System.Windows.Forms.Button();
            this.btnEspacobranco = new System.Windows.Forms.Button();
            this.btnQtdecaracteralfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(12, 45);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(451, 252);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnQtdnumeros
            // 
            this.btnQtdnumeros.Location = new System.Drawing.Point(12, 339);
            this.btnQtdnumeros.Name = "btnQtdnumeros";
            this.btnQtdnumeros.Size = new System.Drawing.Size(138, 58);
            this.btnQtdnumeros.TabIndex = 1;
            this.btnQtdnumeros.Text = "Quantidade de Números";
            this.btnQtdnumeros.UseVisualStyleBackColor = true;
            this.btnQtdnumeros.Click += new System.EventHandler(this.btnQtdnumeros_Click);
            // 
            // btnEspacobranco
            // 
            this.btnEspacobranco.Location = new System.Drawing.Point(156, 339);
            this.btnEspacobranco.Name = "btnEspacobranco";
            this.btnEspacobranco.Size = new System.Drawing.Size(142, 58);
            this.btnEspacobranco.TabIndex = 2;
            this.btnEspacobranco.Text = "Primeiro caracter em branco";
            this.btnEspacobranco.UseVisualStyleBackColor = true;
            this.btnEspacobranco.Click += new System.EventHandler(this.btnEspacobranco_Click);
            // 
            // btnQtdecaracteralfabeticos
            // 
            this.btnQtdecaracteralfabeticos.Location = new System.Drawing.Point(304, 339);
            this.btnQtdecaracteralfabeticos.Name = "btnQtdecaracteralfabeticos";
            this.btnQtdecaracteralfabeticos.Size = new System.Drawing.Size(159, 58);
            this.btnQtdecaracteralfabeticos.TabIndex = 3;
            this.btnQtdecaracteralfabeticos.Text = "Quantidade caracteres alfabéticos";
            this.btnQtdecaracteralfabeticos.UseVisualStyleBackColor = true;
            this.btnQtdecaracteralfabeticos.Click += new System.EventHandler(this.btnQtdecaracteralfabeticos_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQtdecaracteralfabeticos);
            this.Controls.Add(this.btnEspacobranco);
            this.Controls.Add(this.btnQtdnumeros);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnQtdnumeros;
        private System.Windows.Forms.Button btnEspacobranco;
        private System.Windows.Forms.Button btnQtdecaracteralfabeticos;
    }
}