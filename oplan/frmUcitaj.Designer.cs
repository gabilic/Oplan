namespace oplan
{
    partial class frmUcitaj
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
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.IntegralHeight = false;
            this.cmbNaziv.Location = new System.Drawing.Point(13, 13);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(201, 24);
            this.cmbNaziv.TabIndex = 0;
            this.cmbNaziv.SelectedValueChanged += new System.EventHandler(this.cmbNaziv_SelectedValueChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDatum.Location = new System.Drawing.Point(220, 14);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(83, 23);
            this.txtDatum.TabIndex = 1;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnUcitaj.Location = new System.Drawing.Point(114, 46);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(100, 32);
            this.btnUcitaj.TabIndex = 2;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // frmUcitaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 87);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.cmbNaziv);
            this.Name = "frmUcitaj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Učitaj plan";
            this.Load += new System.EventHandler(this.frmUcitaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnUcitaj;
    }
}