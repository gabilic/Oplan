namespace oplan
{
    partial class frmNaziv
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnPotvrdi.Location = new System.Drawing.Point(71, 45);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(100, 32);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNaziv.Location = new System.Drawing.Point(12, 12);
            this.txtNaziv.MaxLength = 50;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(210, 26);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // frmNaziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 87);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "frmNaziv";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naziv plana";
            this.Load += new System.EventHandler(this.frmNaziv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}