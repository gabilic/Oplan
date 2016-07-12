namespace oplan
{
    partial class frmOpis
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.ucCitac = new oplan.ucCitac();
            this.pomoc = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnZatvori.Location = new System.Drawing.Point(247, 718);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(85, 32);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ucCitac
            // 
            this.ucCitac.Location = new System.Drawing.Point(12, 13);
            this.ucCitac.Name = "ucCitac";
            this.ucCitac.Size = new System.Drawing.Size(560, 700);
            this.ucCitac.TabIndex = 2;
            // 
            // pomoc
            // 
            this.pomoc.HelpNamespace = "../../help/oplan.chm";
            // 
            // frmOpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 762);
            this.Controls.Add(this.ucCitac);
            this.Controls.Add(this.btnZatvori);
            this.pomoc.SetHelpKeyword(this, "F1");
            this.pomoc.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pomoc.SetHelpString(this, "F1");
            this.Name = "frmOpis";
            this.pomoc.SetShowHelp(this, true);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpis";
            this.Load += new System.EventHandler(this.frmOpis_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZatvori;
        private ucCitac ucCitac;
        private System.Windows.Forms.HelpProvider pomoc;
    }
}