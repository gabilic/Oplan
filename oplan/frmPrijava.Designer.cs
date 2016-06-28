namespace oplan
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblKorime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::oplan.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(36, 29);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(218, 52);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // txtKorime
            // 
            this.txtKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKorime.Location = new System.Drawing.Point(36, 130);
            this.txtKorime.MaxLength = 20;
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(218, 26);
            this.txtKorime.TabIndex = 1;
            this.txtKorime.TextChanged += new System.EventHandler(this.txtKorime_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLozinka.Location = new System.Drawing.Point(36, 198);
            this.txtLozinka.MaxLength = 15;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(218, 26);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.UseSystemPasswordChar = true;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // lblKorime
            // 
            this.lblKorime.AutoSize = true;
            this.lblKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKorime.Location = new System.Drawing.Point(74, 99);
            this.lblKorime.Name = "lblKorime";
            this.lblKorime.Size = new System.Drawing.Size(138, 24);
            this.lblKorime.TabIndex = 3;
            this.lblKorime.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLozinka.Location = new System.Drawing.Point(108, 167);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(79, 24);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(78, 249);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(143, 56);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // frmPrijava
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 334);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorime);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.pbxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPLAN Prijava";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblKorime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}

