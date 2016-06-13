namespace oplan
{
    partial class frmPlanovi
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
            this.dgvPlanovi = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnBrisiPlan = new System.Windows.Forms.Button();
            this.btnIzmjeniPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanovi
            // 
            this.dgvPlanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanovi.Location = new System.Drawing.Point(13, 13);
            this.dgvPlanovi.Name = "dgvPlanovi";
            this.dgvPlanovi.Size = new System.Drawing.Size(440, 360);
            this.dgvPlanovi.TabIndex = 0;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnPovratak.Location = new System.Drawing.Point(13, 391);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 32);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            // 
            // btnBrisiPlan
            // 
            this.btnBrisiPlan.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnBrisiPlan.Location = new System.Drawing.Point(353, 391);
            this.btnBrisiPlan.Name = "btnBrisiPlan";
            this.btnBrisiPlan.Size = new System.Drawing.Size(100, 32);
            this.btnBrisiPlan.TabIndex = 2;
            this.btnBrisiPlan.Text = "Izbriši plan";
            this.btnBrisiPlan.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeniPlan
            // 
            this.btnIzmjeniPlan.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmjeniPlan.Location = new System.Drawing.Point(247, 391);
            this.btnIzmjeniPlan.Name = "btnIzmjeniPlan";
            this.btnIzmjeniPlan.Size = new System.Drawing.Size(100, 32);
            this.btnIzmjeniPlan.TabIndex = 3;
            this.btnIzmjeniPlan.Text = "Izmjeni plan";
            this.btnIzmjeniPlan.UseVisualStyleBackColor = true;
            this.btnIzmjeniPlan.Click += new System.EventHandler(this.btnIzmjeniPlan_Click);
            // 
            // frmPlanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 442);
            this.Controls.Add(this.btnIzmjeniPlan);
            this.Controls.Add(this.btnBrisiPlan);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvPlanovi);
            this.Name = "frmPlanovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz planova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanovi;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnBrisiPlan;
        private System.Windows.Forms.Button btnIzmjeniPlan;
    }
}