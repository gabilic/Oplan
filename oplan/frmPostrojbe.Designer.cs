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
            this.dgvDivizije = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiPostrojbu = new System.Windows.Forms.Button();
            this.btnDodajDiviziju = new System.Windows.Forms.Button();
            this.btnIzmijeniDiviziju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivizije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDivizije
            // 
            this.dgvDivizije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivizije.Location = new System.Drawing.Point(13, 13);
            this.dgvDivizije.Name = "dgvDivizije";
            this.dgvDivizije.Size = new System.Drawing.Size(600, 360);
            this.dgvDivizije.TabIndex = 0;
            // 
            // btnIzbrisiPostrojbu
            // 
            this.btnIzbrisiPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiPostrojbu.Location = new System.Drawing.Point(488, 391);
            this.btnIzbrisiPostrojbu.Name = "btnIzbrisiPostrojbu";
            this.btnIzbrisiPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiPostrojbu.TabIndex = 2;
            this.btnIzbrisiPostrojbu.Text = "Izbriši diviziju";
            this.btnIzbrisiPostrojbu.UseVisualStyleBackColor = true;
            // 
            // btnDodajDiviziju
            // 
            this.btnDodajDiviziju.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajDiviziju.Location = new System.Drawing.Point(226, 391);
            this.btnDodajDiviziju.Name = "btnDodajDiviziju";
            this.btnDodajDiviziju.Size = new System.Drawing.Size(125, 32);
            this.btnDodajDiviziju.TabIndex = 3;
            this.btnDodajDiviziju.Text = "Dodaj diviziju";
            this.btnDodajDiviziju.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniDiviziju
            // 
            this.btnIzmijeniDiviziju.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniDiviziju.Location = new System.Drawing.Point(357, 391);
            this.btnIzmijeniDiviziju.Name = "btnIzmijeniDiviziju";
            this.btnIzmijeniDiviziju.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniDiviziju.TabIndex = 4;
            this.btnIzmijeniDiviziju.Text = "Izmijeni diviziju";
            this.btnIzmijeniDiviziju.UseVisualStyleBackColor = true;
            // 
            // frmPostrojbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnIzmijeniDiviziju);
            this.Controls.Add(this.btnDodajDiviziju);
            this.Controls.Add(this.btnIzbrisiPostrojbu);
            this.Controls.Add(this.dgvDivizije);
            this.Name = "frmPostrojbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s divizijama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivizije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDivizije;
        private System.Windows.Forms.Button btnIzbrisiPostrojbu;
        private System.Windows.Forms.Button btnDodajDiviziju;
        private System.Windows.Forms.Button btnIzmijeniDiviziju;
    }
}