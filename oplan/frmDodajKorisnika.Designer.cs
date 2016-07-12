namespace oplan
{
    partial class frmDodajKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajKorisnika));
            this.lblKorime = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.rdbNe = new System.Windows.Forms.RadioButton();
            this.rdbDa = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gbxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKorime.Location = new System.Drawing.Point(13, 13);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(103, 17);
            this.lblKorime.TabIndex = 0;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // txtKorime
            // 
            this.txtKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKorime.Location = new System.Drawing.Point(16, 36);
            this.txtKorime.MaxLength = 20;
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(150, 23);
            this.txtKorime.TabIndex = 1;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLozinka.Location = new System.Drawing.Point(16, 74);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLozinka.Location = new System.Drawing.Point(18, 96);
            this.txtLozinka.MaxLength = 15;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(150, 23);
            this.txtLozinka.TabIndex = 3;
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Controls.Add(this.rdbNe);
            this.gbxAdmin.Controls.Add(this.rdbDa);
            this.gbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbxAdmin.Location = new System.Drawing.Point(186, 12);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(106, 79);
            this.gbxAdmin.TabIndex = 4;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "Administrator";
            // 
            // rdbNe
            // 
            this.rdbNe.AutoSize = true;
            this.rdbNe.Location = new System.Drawing.Point(12, 48);
            this.rdbNe.Name = "rdbNe";
            this.rdbNe.Size = new System.Drawing.Size(44, 21);
            this.rdbNe.TabIndex = 1;
            this.rdbNe.Text = "Ne";
            this.rdbNe.UseVisualStyleBackColor = true;
            // 
            // rdbDa
            // 
            this.rdbDa.AutoSize = true;
            this.rdbDa.Checked = true;
            this.rdbDa.Location = new System.Drawing.Point(12, 24);
            this.rdbDa.Name = "rdbDa";
            this.rdbDa.Size = new System.Drawing.Size(44, 21);
            this.rdbDa.TabIndex = 0;
            this.rdbDa.TabStop = true;
            this.rdbDa.Text = "Da";
            this.rdbDa.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblID.Location = new System.Drawing.Point(183, 98);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(207, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 23);
            this.txtID.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSpremi.Location = new System.Drawing.Point(116, 134);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 32);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnOdustani.Location = new System.Drawing.Point(207, 134);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 182);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbxAdmin);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblKorime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDodajKorisnika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje korisnika";
            this.Load += new System.EventHandler(this.frmKorisnik_Load);
            this.gbxAdmin.ResumeLayout(false);
            this.gbxAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.GroupBox gbxAdmin;
        private System.Windows.Forms.RadioButton rdbNe;
        private System.Windows.Forms.RadioButton rdbDa;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}