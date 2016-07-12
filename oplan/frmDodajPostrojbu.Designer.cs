namespace oplan
{
    partial class frmDodajPostrojbu
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
            this.tkbIzdrzljivost = new System.Windows.Forms.TrackBar();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblVrstaHelp = new System.Windows.Forms.Label();
            this.lblTipHelp = new System.Windows.Forms.Label();
            this.gbxIzdrzljivost = new System.Windows.Forms.GroupBox();
            this.txtVI = new System.Windows.Forms.TextBox();
            this.lblVI = new System.Windows.Forms.Label();
            this.gbxBrzina = new System.Windows.Forms.GroupBox();
            this.lblVB = new System.Windows.Forms.Label();
            this.txtVB = new System.Windows.Forms.TextBox();
            this.tkbBrzina = new System.Windows.Forms.TrackBar();
            this.tltVrsta = new System.Windows.Forms.ToolTip(this.components);
            this.tltTip = new System.Windows.Forms.ToolTip(this.components);
            this.vrstaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tkbIzdrzljivost)).BeginInit();
            this.gbxIzdrzljivost.SuspendLayout();
            this.gbxBrzina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrzina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbIzdrzljivost
            // 
            this.tkbIzdrzljivost.Location = new System.Drawing.Point(6, 22);
            this.tkbIzdrzljivost.Maximum = 100;
            this.tkbIzdrzljivost.Minimum = 1;
            this.tkbIzdrzljivost.Name = "tkbIzdrzljivost";
            this.tkbIzdrzljivost.Size = new System.Drawing.Size(168, 45);
            this.tkbIzdrzljivost.TabIndex = 0;
            this.tkbIzdrzljivost.Value = 1;
            this.tkbIzdrzljivost.Scroll += new System.EventHandler(this.tkbIzdrzljivost_Scroll);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnOdustani.Location = new System.Drawing.Point(298, 184);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 32);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSpremi.Location = new System.Drawing.Point(206, 184);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 32);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVrsta.Location = new System.Drawing.Point(13, 15);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(108, 17);
            this.lblVrsta.TabIndex = 3;
            this.lblVrsta.Text = "Vrsta postrojbe:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTip.Location = new System.Drawing.Point(12, 42);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(95, 17);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Tip postrojbe:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(125, 14);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(243, 21);
            this.cmbVrsta.TabIndex = 5;
            this.cmbVrsta.SelectedValueChanged += new System.EventHandler(this.cmbVrsta_SelectedValueChanged);
            // 
            // cmbTip
            // 
            this.cmbTip.DisplayMember = "id_tip";
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(125, 42);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(243, 21);
            this.cmbTip.TabIndex = 6;
            this.cmbTip.ValueMember = "id_tip";
            this.cmbTip.SelectedValueChanged += new System.EventHandler(this.cmbTip_SelectedValueChanged);
            // 
            // lblVrstaHelp
            // 
            this.lblVrstaHelp.AutoSize = true;
            this.lblVrstaHelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrstaHelp.Location = new System.Drawing.Point(370, 16);
            this.lblVrstaHelp.Name = "lblVrstaHelp";
            this.lblVrstaHelp.Size = new System.Drawing.Size(16, 16);
            this.lblVrstaHelp.TabIndex = 7;
            this.lblVrstaHelp.Text = "?";
            // 
            // lblTipHelp
            // 
            this.lblTipHelp.AutoSize = true;
            this.lblTipHelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipHelp.Location = new System.Drawing.Point(370, 43);
            this.lblTipHelp.Name = "lblTipHelp";
            this.lblTipHelp.Size = new System.Drawing.Size(16, 16);
            this.lblTipHelp.TabIndex = 8;
            this.lblTipHelp.Text = "?";
            // 
            // gbxIzdrzljivost
            // 
            this.gbxIzdrzljivost.Controls.Add(this.txtVI);
            this.gbxIzdrzljivost.Controls.Add(this.lblVI);
            this.gbxIzdrzljivost.Controls.Add(this.tkbIzdrzljivost);
            this.gbxIzdrzljivost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbxIzdrzljivost.Location = new System.Drawing.Point(16, 74);
            this.gbxIzdrzljivost.Name = "gbxIzdrzljivost";
            this.gbxIzdrzljivost.Size = new System.Drawing.Size(180, 100);
            this.gbxIzdrzljivost.TabIndex = 9;
            this.gbxIzdrzljivost.TabStop = false;
            this.gbxIzdrzljivost.Text = "Izdržljivost";
            // 
            // txtVI
            // 
            this.txtVI.Location = new System.Drawing.Point(91, 61);
            this.txtVI.Name = "txtVI";
            this.txtVI.Size = new System.Drawing.Size(75, 23);
            this.txtVI.TabIndex = 1;
            this.txtVI.Text = "1";
            this.txtVI.TextChanged += new System.EventHandler(this.txtVI_TextChanged);
            // 
            // lblVI
            // 
            this.lblVI.AutoSize = true;
            this.lblVI.Location = new System.Drawing.Point(12, 63);
            this.lblVI.Name = "lblVI";
            this.lblVI.Size = new System.Drawing.Size(75, 17);
            this.lblVI.TabIndex = 11;
            this.lblVI.Text = "Vrijednost:";
            // 
            // gbxBrzina
            // 
            this.gbxBrzina.Controls.Add(this.lblVB);
            this.gbxBrzina.Controls.Add(this.txtVB);
            this.gbxBrzina.Controls.Add(this.tkbBrzina);
            this.gbxBrzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbxBrzina.Location = new System.Drawing.Point(203, 74);
            this.gbxBrzina.Name = "gbxBrzina";
            this.gbxBrzina.Size = new System.Drawing.Size(180, 100);
            this.gbxBrzina.TabIndex = 10;
            this.gbxBrzina.TabStop = false;
            this.gbxBrzina.Text = "Brzina";
            // 
            // lblVB
            // 
            this.lblVB.AutoSize = true;
            this.lblVB.Location = new System.Drawing.Point(13, 63);
            this.lblVB.Name = "lblVB";
            this.lblVB.Size = new System.Drawing.Size(75, 17);
            this.lblVB.TabIndex = 12;
            this.lblVB.Text = "Vrijednost:";
            // 
            // txtVB
            // 
            this.txtVB.Location = new System.Drawing.Point(92, 61);
            this.txtVB.Name = "txtVB";
            this.txtVB.Size = new System.Drawing.Size(75, 23);
            this.txtVB.TabIndex = 1;
            this.txtVB.Text = "1";
            this.txtVB.TextChanged += new System.EventHandler(this.txtVB_TextChanged);
            // 
            // tkbBrzina
            // 
            this.tkbBrzina.Location = new System.Drawing.Point(7, 22);
            this.tkbBrzina.Maximum = 100;
            this.tkbBrzina.Minimum = 1;
            this.tkbBrzina.Name = "tkbBrzina";
            this.tkbBrzina.Size = new System.Drawing.Size(167, 45);
            this.tkbBrzina.TabIndex = 0;
            this.tkbBrzina.Value = 1;
            this.tkbBrzina.Scroll += new System.EventHandler(this.tkbBrzina_Scroll);
            // 
            // vrstaBindingSource1
            // 
            this.vrstaBindingSource1.DataSource = typeof(oplan.vrsta);
            // 
            // vrstaBindingSource
            // 
            this.vrstaBindingSource.DataSource = typeof(oplan.vrsta);
            // 
            // frmDodajPostrojbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 227);
            this.Controls.Add(this.gbxBrzina);
            this.Controls.Add(this.gbxIzdrzljivost);
            this.Controls.Add(this.lblTipHelp);
            this.Controls.Add(this.lblVrstaHelp);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDodajPostrojbu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje postrojbe";
            this.Load += new System.EventHandler(this.frmPostrojba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbIzdrzljivost)).EndInit();
            this.gbxIzdrzljivost.ResumeLayout(false);
            this.gbxIzdrzljivost.PerformLayout();
            this.gbxBrzina.ResumeLayout(false);
            this.gbxBrzina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrzina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbIzdrzljivost;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label lblVrstaHelp;
        private System.Windows.Forms.Label lblTipHelp;
        private System.Windows.Forms.GroupBox gbxIzdrzljivost;
        private System.Windows.Forms.GroupBox gbxBrzina;
        private System.Windows.Forms.TrackBar tkbBrzina;
        private System.Windows.Forms.TextBox txtVI;
        private System.Windows.Forms.Label lblVI;
        private System.Windows.Forms.Label lblVB;
        private System.Windows.Forms.TextBox txtVB;
        private System.Windows.Forms.ToolTip tltVrsta;
        private System.Windows.Forms.ToolTip tltTip;
        private System.Windows.Forms.BindingSource vrstaBindingSource1;
        private System.Windows.Forms.BindingSource vrstaBindingSource;
    }
}