namespace oplan
{
    partial class frmAdminIzbor
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
            this.btnPostrojba = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.lblPregled = new System.Windows.Forms.Label();
            this.btnPlanovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPostrojba
            // 
            this.btnPostrojba.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPostrojba.Location = new System.Drawing.Point(36, 87);
            this.btnPostrojba.Name = "btnPostrojba";
            this.btnPostrojba.Size = new System.Drawing.Size(225, 50);
            this.btnPostrojba.TabIndex = 0;
            this.btnPostrojba.Text = "Postrojbe";
            this.btnPostrojba.UseVisualStyleBackColor = true;
            this.btnPostrojba.Click += new System.EventHandler(this.btnPostrojbe_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKorisnici.Location = new System.Drawing.Point(36, 157);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(225, 50);
            this.btnKorisnici.TabIndex = 1;
            this.btnKorisnici.Text = "Korisnike";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // lblPregled
            // 
            this.lblPregled.AutoSize = true;
            this.lblPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPregled.Location = new System.Drawing.Point(38, 39);
            this.lblPregled.Name = "lblPregled";
            this.lblPregled.Size = new System.Drawing.Size(220, 20);
            this.lblPregled.TabIndex = 2;
            this.lblPregled.Text = "Odaberite što želite pregledati";
            // 
            // btnPlanovi
            // 
            this.btnPlanovi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlanovi.Location = new System.Drawing.Point(36, 228);
            this.btnPlanovi.Name = "btnPlanovi";
            this.btnPlanovi.Size = new System.Drawing.Size(225, 50);
            this.btnPlanovi.TabIndex = 3;
            this.btnPlanovi.Text = "Planovi";
            this.btnPlanovi.UseVisualStyleBackColor = true;
            this.btnPlanovi.Click += new System.EventHandler(this.btnPlanovi_Click);
            // 
            // frmAdminIzbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 334);
            this.Controls.Add(this.btnPlanovi);
            this.Controls.Add(this.lblPregled);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnPostrojba);
            this.Name = "frmAdminIzbor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostrojba;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Label lblPregled;
        private System.Windows.Forms.Button btnPlanovi;
    }
}