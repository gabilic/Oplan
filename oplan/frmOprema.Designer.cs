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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOprema));
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiOpremu = new System.Windows.Forms.Button();
            this.btnIzmjeniOpremu = new System.Windows.Forms.Button();
            this.btnDodajOpremu = new System.Windows.Forms.Button();
            this.pomoc = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.AllowUserToAddRows = false;
            this.dgvOprema.AllowUserToDeleteRows = false;
            this.dgvOprema.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOprema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(13, 12);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.ReadOnly = true;
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
            this.btnIzbrisiOpremu.Click += new System.EventHandler(this.btnIzbrisiOpremu_Click);
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
            this.btnIzmjeniOpremu.Click += new System.EventHandler(this.btnIzmjeniOpremu_Click);
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
            this.btnDodajOpremu.Click += new System.EventHandler(this.btnDodajOpremu_Click);
            // 
            // pomoc
            // 
            this.pomoc.HelpNamespace = "../../help/oplan.chm";
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
            this.pomoc.SetHelpKeyword(this, "F1");
            this.pomoc.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pomoc.SetHelpString(this, "F1");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOprema";
            this.pomoc.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s opremom";
            this.Load += new System.EventHandler(this.frmOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnIzbrisiOpremu;
        private System.Windows.Forms.Button btnIzmjeniOpremu;
        private System.Windows.Forms.Button btnDodajOpremu;
        private System.Windows.Forms.HelpProvider pomoc;
    }
}