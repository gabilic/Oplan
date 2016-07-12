namespace oplan
{
    partial class frmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // chStatistika
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY2.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chStatistika.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chStatistika.Legends.Add(legend1);
            this.chStatistika.Location = new System.Drawing.Point(12, 12);
            this.chStatistika.Name = "chStatistika";
            this.chStatistika.Size = new System.Drawing.Size(760, 737);
            this.chStatistika.TabIndex = 0;
            this.chStatistika.Text = "chart1";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.chStatistika);
            this.Name = "frmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika po zemljama";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.Resize += new System.EventHandler(this.frmStatistika_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chStatistika;
    }
}