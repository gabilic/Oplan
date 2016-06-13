namespace oplan
{
    partial class frmKorisnici
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnIzmijeniKorisnika = new System.Windows.Forms.Button();
            this.btnIzbrisiKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(13, 13);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(480, 360);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajKorisnika.Location = new System.Drawing.Point(105, 391);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnDodajKorisnika.TabIndex = 2;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniKorisnika
            // 
            this.btnIzmijeniKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniKorisnika.Location = new System.Drawing.Point(236, 391);
            this.btnIzmijeniKorisnika.Name = "btnIzmijeniKorisnika";
            this.btnIzmijeniKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniKorisnika.TabIndex = 3;
            this.btnIzmijeniKorisnika.Text = "Izmijeni korisnika";
            this.btnIzmijeniKorisnika.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiKorisnika
            // 
            this.btnIzbrisiKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiKorisnika.Location = new System.Drawing.Point(367, 391);
            this.btnIzbrisiKorisnika.Name = "btnIzbrisiKorisnika";
            this.btnIzbrisiKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiKorisnika.TabIndex = 4;
            this.btnIzbrisiKorisnika.Text = "Izbriši korisnika";
            this.btnIzbrisiKorisnika.UseVisualStyleBackColor = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 442);
            this.Controls.Add(this.btnIzbrisiKorisnika);
            this.Controls.Add(this.btnIzmijeniKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s korisnicima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnIzmijeniKorisnika;
        private System.Windows.Forms.Button btnIzbrisiKorisnika;
    }
}