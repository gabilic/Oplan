namespace oplan
{
    partial class frmDodajArsenal
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
            this.components = new System.ComponentModel.Container();
            this.lblPostrojba = new System.Windows.Forms.Label();
            this.lblOprema = new System.Windows.Forms.Label();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblTooltip = new System.Windows.Forms.Label();
            this.tltOprema = new System.Windows.Forms.ToolTip(this.components);
            this.cmbPostrojba = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPostrojba
            // 
            this.lblPostrojba.AutoSize = true;
            this.lblPostrojba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPostrojba.Location = new System.Drawing.Point(12, 12);
            this.lblPostrojba.Name = "lblPostrojba";
            this.lblPostrojba.Size = new System.Drawing.Size(72, 17);
            this.lblPostrojba.TabIndex = 0;
            this.lblPostrojba.Text = "Postrojba:";
            // 
            // lblOprema
            // 
            this.lblOprema.AutoSize = true;
            this.lblOprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOprema.Location = new System.Drawing.Point(12, 41);
            this.lblOprema.Name = "lblOprema";
            this.lblOprema.Size = new System.Drawing.Size(63, 17);
            this.lblOprema.TabIndex = 2;
            this.lblOprema.Text = "Oprema:";
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(88, 40);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(285, 21);
            this.cmbOprema.TabIndex = 3;
            this.cmbOprema.SelectedValueChanged += new System.EventHandler(this.cmbOprema_SelectedValueChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnOdustani.Location = new System.Drawing.Point(287, 71);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 32);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSpremi.Location = new System.Drawing.Point(196, 71);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 32);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblTooltip
            // 
            this.lblTooltip.AutoSize = true;
            this.lblTooltip.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTooltip.Location = new System.Drawing.Point(72, 37);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(16, 16);
            this.lblTooltip.TabIndex = 4;
            this.lblTooltip.Text = "?";
            // 
            // cmbPostrojba
            // 
            this.cmbPostrojba.FormattingEnabled = true;
            this.cmbPostrojba.Location = new System.Drawing.Point(87, 10);
            this.cmbPostrojba.Name = "cmbPostrojba";
            this.cmbPostrojba.Size = new System.Drawing.Size(285, 21);
            this.cmbPostrojba.TabIndex = 7;
            // 
            // frmDodajArsenal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.cmbPostrojba);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblTooltip);
            this.Controls.Add(this.cmbOprema);
            this.Controls.Add(this.lblOprema);
            this.Controls.Add(this.lblPostrojba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDodajArsenal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajArsenal";
            this.Load += new System.EventHandler(this.frmDodajArsenal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostrojba;
        private System.Windows.Forms.Label lblOprema;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblTooltip;
        private System.Windows.Forms.ToolTip tltOprema;
        private System.Windows.Forms.ComboBox cmbPostrojba;
    }
}