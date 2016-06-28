namespace oplan
{
    partial class frmDodajOpremu
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbTipOpreme = new System.Windows.Forms.ComboBox();
            this.cmbZemlja = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblModel.Location = new System.Drawing.Point(11, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTip.Location = new System.Drawing.Point(11, 44);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(84, 17);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Tip opreme:";
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblZemlja.Location = new System.Drawing.Point(11, 72);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(111, 17);
            this.lblZemlja.TabIndex = 2;
            this.lblZemlja.Text = "Zemlja porijekla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtModel.Location = new System.Drawing.Point(67, 13);
            this.txtModel.MaxLength = 100;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(309, 23);
            this.txtModel.TabIndex = 4;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtOpis.Location = new System.Drawing.Point(67, 101);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(309, 142);
            this.txtOpis.TabIndex = 5;
            // 
            // cmbTipOpreme
            // 
            this.cmbTipOpreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbTipOpreme.FormattingEnabled = true;
            this.cmbTipOpreme.Location = new System.Drawing.Point(125, 43);
            this.cmbTipOpreme.Name = "cmbTipOpreme";
            this.cmbTipOpreme.Size = new System.Drawing.Size(251, 21);
            this.cmbTipOpreme.TabIndex = 6;
            // 
            // cmbZemlja
            // 
            this.cmbZemlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbZemlja.FormattingEnabled = true;
            this.cmbZemlja.Location = new System.Drawing.Point(125, 70);
            this.cmbZemlja.Name = "cmbZemlja";
            this.cmbZemlja.Size = new System.Drawing.Size(251, 21);
            this.cmbZemlja.TabIndex = 7;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnOdustani.Location = new System.Drawing.Point(291, 257);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(85, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnSpremi.Location = new System.Drawing.Point(200, 257);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 32);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // frmDodajOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 302);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbZemlja);
            this.Controls.Add(this.cmbTipOpreme);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblModel);
            this.Name = "frmDodajOpremu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajOpremu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbTipOpreme;
        private System.Windows.Forms.ComboBox cmbZemlja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}