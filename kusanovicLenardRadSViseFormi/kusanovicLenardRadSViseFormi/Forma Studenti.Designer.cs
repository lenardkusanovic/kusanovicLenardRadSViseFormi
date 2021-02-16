namespace kusanovicLenardRadSViseFormi
{
    partial class FormaStudenti
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
            this.lstStudenti = new System.Windows.Forms.ListBox();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudenti
            // 
            this.lstStudenti.FormattingEnabled = true;
            this.lstStudenti.Location = new System.Drawing.Point(64, 102);
            this.lstStudenti.Name = "lstStudenti";
            this.lstStudenti.Size = new System.Drawing.Size(441, 199);
            this.lstStudenti.TabIndex = 6;
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(64, 307);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(113, 23);
            this.btnObrisiSve.TabIndex = 5;
            this.btnObrisiSve.Text = "Obrisi sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(64, 73);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(113, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novog studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Location = new System.Drawing.Point(511, 190);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(112, 23);
            this.btnObrisiStudenta.TabIndex = 7;
            this.btnObrisiStudenta.Text = "Obrisi studenta";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // FormaStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.lstStudenti);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormaStudenti";
            this.Text = "Forma Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudenti;
        private System.Windows.Forms.Button btnObrisiSve;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisiStudenta;
    }
}