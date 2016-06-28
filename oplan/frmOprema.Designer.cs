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
            this.btnIzmijeniOpremu = new System.Windows.Forms.Button();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(13, 13);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.Size = new System.Drawing.Size(600, 352);
            this.dgvOprema.TabIndex = 0;
            // 
            // btnIzbrisiOpremu
            // 
            this.btnIzbrisiOpremu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzbrisiOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiOpremu.Location = new System.Drawing.Point(488, 378);
            this.btnIzbrisiOpremu.Name = "btnIzbrisiOpremu";
            this.btnIzbrisiOpremu.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiOpremu.TabIndex = 1;
            this.btnIzbrisiOpremu.Text = "Obriši opremu";
            this.btnIzbrisiOpremu.UseVisualStyleBackColor = true;
            this.btnIzbrisiOpremu.Click += new System.EventHandler(this.btnIzbrisiOpremu_Click);
            // 
            // btnIzmijeniOpremu
            // 
            this.btnIzmijeniOpremu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzmijeniOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniOpremu.Location = new System.Drawing.Point(357, 378);
            this.btnIzmijeniOpremu.Name = "btnIzmijeniOpremu";
            this.btnIzmijeniOpremu.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniOpremu.TabIndex = 2;
            this.btnIzmijeniOpremu.Text = "Izmijeni opremu";
            this.btnIzmijeniOpremu.UseVisualStyleBackColor = true;
            this.btnIzmijeniOpremu.Click += new System.EventHandler(this.btnIzmijeniOpremu_Click);
            // 
            // btnDodajOpremu
            // 
            this.btnDodajOpremu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodajOpremu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajOpremu.Location = new System.Drawing.Point(226, 378);
            this.btnDodajOpremu.Name = "btnDodajOpremu";
            this.btnDodajOpremu.Size = new System.Drawing.Size(125, 32);
            this.btnDodajOpremu.TabIndex = 3;
            this.btnDodajOpremu.Text = "Dodaj opremu";
            this.btnDodajOpremu.UseVisualStyleBackColor = true;
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // frmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 422);
            this.Controls.Add(this.btnDodajOpremu);
            this.Controls.Add(this.btnIzmijeniOpremu);
            this.Controls.Add(this.btnIzbrisiOpremu);
            this.Controls.Add(this.dgvOprema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOprema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s opremom";
            this.Load += new System.EventHandler(this.frmOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnIzbrisiOpremu;
        private System.Windows.Forms.Button btnIzmijeniOpremu;
        private System.Windows.Forms.Button btnDodajOpremu;
    }
}