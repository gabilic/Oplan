namespace oplan
{
    partial class frmOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOprema));
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiOpremu = new System.Windows.Forms.Button();
            this.btnIzmjeniOpremu = new System.Windows.Forms.Button();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(13, 12);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.Size = new System.Drawing.Size(599, 375);
            this.dgvOprema.TabIndex = 0;
            // 
            // btnIzbrisiOpremu
            // 
            this.btnIzbrisiOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiOpremu.Location = new System.Drawing.Point(492, 398);
            this.btnIzbrisiOpremu.Name = "btnIzbrisiOpremu";
            this.btnIzbrisiOpremu.Size = new System.Drawing.Size(120, 32);
            this.btnIzbrisiOpremu.TabIndex = 1;
            this.btnIzbrisiOpremu.Text = "Obriši opremu";
            this.btnIzbrisiOpremu.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeniOpremu
            // 
            this.btnIzmjeniOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmjeniOpremu.Location = new System.Drawing.Point(366, 398);
            this.btnIzmjeniOpremu.Name = "btnIzmjeniOpremu";
            this.btnIzmjeniOpremu.Size = new System.Drawing.Size(120, 32);
            this.btnIzmjeniOpremu.TabIndex = 2;
            this.btnIzmjeniOpremu.Text = "Izmijeni opremu";
            this.btnIzmjeniOpremu.UseVisualStyleBackColor = true;
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajOpremu.Location = new System.Drawing.Point(240, 398);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(120, 32);
            this.btnDodajOpremu.TabIndex = 3;
            this.btnDodajOpremu.Text = "Dodaj opremu";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            // 
            // frmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.btnIzmjeniOpremu);
            this.Controls.Add(this.btnIzbrisiOpremu);
            this.Controls.Add(this.dgvOprema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOprema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oprema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnIzbrisiOpremu;
        private System.Windows.Forms.Button btnIzmjeniOpremu;
        private System.Windows.Forms.Button btnDodajOpremu;
    }
}