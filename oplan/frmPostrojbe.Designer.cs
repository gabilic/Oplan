namespace oplan
{
    partial class frmPostrojbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostrojbe));
            this.dgvPostrojbe = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiPostrojbu = new System.Windows.Forms.Button();
            this.btnDodajPostrojbu = new System.Windows.Forms.Button();
            this.btnIzmijeniPostrojbu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostrojbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPostrojbe
            // 
            this.dgvPostrojbe.AllowUserToAddRows = false;
            this.dgvPostrojbe.AllowUserToDeleteRows = false;
            this.dgvPostrojbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPostrojbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPostrojbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostrojbe.Location = new System.Drawing.Point(13, 13);
            this.dgvPostrojbe.Name = "dgvPostrojbe";
            this.dgvPostrojbe.ReadOnly = true;
            this.dgvPostrojbe.Size = new System.Drawing.Size(600, 352);
            this.dgvPostrojbe.TabIndex = 0;
            // 
            // btnIzbrisiPostrojbu
            // 
            this.btnIzbrisiPostrojbu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzbrisiPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiPostrojbu.Location = new System.Drawing.Point(488, 378);
            this.btnIzbrisiPostrojbu.Name = "btnIzbrisiPostrojbu";
            this.btnIzbrisiPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiPostrojbu.TabIndex = 2;
            this.btnIzbrisiPostrojbu.Text = "Izbriši postrojbu";
            this.btnIzbrisiPostrojbu.UseVisualStyleBackColor = true;
            this.btnIzbrisiPostrojbu.Click += new System.EventHandler(this.btnIzbrisiPostrojbu_Click);
            // 
            // btnDodajPostrojbu
            // 
            this.btnDodajPostrojbu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodajPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajPostrojbu.Location = new System.Drawing.Point(226, 378);
            this.btnDodajPostrojbu.Name = "btnDodajPostrojbu";
            this.btnDodajPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnDodajPostrojbu.TabIndex = 3;
            this.btnDodajPostrojbu.Text = "Dodaj postrojbu";
            this.btnDodajPostrojbu.UseVisualStyleBackColor = true;
            this.btnDodajPostrojbu.Click += new System.EventHandler(this.btnDodajPostrojbu_Click);
            // 
            // btnIzmijeniPostrojbu
            // 
            this.btnIzmijeniPostrojbu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzmijeniPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniPostrojbu.Location = new System.Drawing.Point(357, 378);
            this.btnIzmijeniPostrojbu.Name = "btnIzmijeniPostrojbu";
            this.btnIzmijeniPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniPostrojbu.TabIndex = 4;
            this.btnIzmijeniPostrojbu.Text = "Izmijeni postrojbu";
            this.btnIzmijeniPostrojbu.UseVisualStyleBackColor = true;
            this.btnIzmijeniPostrojbu.Click += new System.EventHandler(this.btnIzmijeniPostrojbu_Click);
            // 
            // frmPostrojbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 422);
            this.Controls.Add(this.btnIzmijeniPostrojbu);
            this.Controls.Add(this.btnDodajPostrojbu);
            this.Controls.Add(this.btnIzbrisiPostrojbu);
            this.Controls.Add(this.dgvPostrojbe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPostrojbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s postrojbama";
            this.Load += new System.EventHandler(this.frmPostrojbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostrojbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostrojbe;
        private System.Windows.Forms.Button btnIzbrisiPostrojbu;
        private System.Windows.Forms.Button btnDodajPostrojbu;
        private System.Windows.Forms.Button btnIzmijeniPostrojbu;
    }
}