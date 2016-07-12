namespace oplan
{
    partial class frmNaoruzanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNaoruzanje));
            this.rpvNaoruzanje = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pomoc = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // rpvNaoruzanje
            // 
            this.rpvNaoruzanje.Location = new System.Drawing.Point(0, 0);
            this.rpvNaoruzanje.Name = "rpvNaoruzanje";
            this.rpvNaoruzanje.ShowBackButton = false;
            this.rpvNaoruzanje.ShowPageNavigationControls = false;
            this.rpvNaoruzanje.ShowRefreshButton = false;
            this.rpvNaoruzanje.ShowStopButton = false;
            this.rpvNaoruzanje.Size = new System.Drawing.Size(1008, 730);
            this.rpvNaoruzanje.TabIndex = 0;
            // 
            // pomoc
            // 
            this.pomoc.HelpNamespace = "../../help/oplan.chm";
            // 
            // frmNaoruzanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.rpvNaoruzanje);
            this.pomoc.SetHelpKeyword(this, "F1");
            this.pomoc.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pomoc.SetHelpString(this, "F1");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNaoruzanje";
            this.pomoc.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNaoruzanje";
            this.Load += new System.EventHandler(this.frmNaoruzanje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNaoruzanje;
        private System.Windows.Forms.HelpProvider pomoc;
    }
}