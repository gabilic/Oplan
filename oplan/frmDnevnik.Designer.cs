namespace oplan
{
    partial class frmDnevnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevnik));
            this.rtvDnevnik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rtvDnevnik
            // 
            this.rtvDnevnik.Location = new System.Drawing.Point(0, 0);
            this.rtvDnevnik.Name = "rtvDnevnik";
            this.rtvDnevnik.ShowBackButton = false;
            this.rtvDnevnik.ShowPageNavigationControls = false;
            this.rtvDnevnik.ShowRefreshButton = false;
            this.rtvDnevnik.ShowStopButton = false;
            this.rtvDnevnik.Size = new System.Drawing.Size(1008, 730);
            this.rtvDnevnik.TabIndex = 0;
            // 
            // frmDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.rtvDnevnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDnevnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDnevnik";
            this.Load += new System.EventHandler(this.frmDnevnik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rtvDnevnik;
    }
}