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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzbrisiPostrojbu = new System.Windows.Forms.Button();
            this.btnDodajPostrojbu = new System.Windows.Forms.Button();
            this.btnIzmjeniPostrojbu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 360);
            this.dataGridView1.TabIndex = 0;
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
            // btnIzbrisiPostrojbu
            // 
            this.btnIzbrisiPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiPostrojbu.Location = new System.Drawing.Point(488, 391);
            this.btnIzbrisiPostrojbu.Name = "btnIzbrisiPostrojbu";
            this.btnIzbrisiPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiPostrojbu.TabIndex = 2;
            this.btnIzbrisiPostrojbu.Text = "Izbriši postrojbu";
            this.btnIzbrisiPostrojbu.UseVisualStyleBackColor = true;
            // 
            // btnDodajPostrojbu
            // 
            this.btnDodajPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajPostrojbu.Location = new System.Drawing.Point(226, 391);
            this.btnDodajPostrojbu.Name = "btnDodajPostrojbu";
            this.btnDodajPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnDodajPostrojbu.TabIndex = 3;
            this.btnDodajPostrojbu.Text = "Dodaj Postrojbu";
            this.btnDodajPostrojbu.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeniPostrojbu
            // 
            this.btnIzmjeniPostrojbu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmjeniPostrojbu.Location = new System.Drawing.Point(357, 391);
            this.btnIzmjeniPostrojbu.Name = "btnIzmjeniPostrojbu";
            this.btnIzmjeniPostrojbu.Size = new System.Drawing.Size(125, 32);
            this.btnIzmjeniPostrojbu.TabIndex = 4;
            this.btnIzmjeniPostrojbu.Text = "Izmjeni postrojbu";
            this.btnIzmjeniPostrojbu.UseVisualStyleBackColor = true;
            // 
            // frmPostrojbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnIzmjeniPostrojbu);
            this.Controls.Add(this.btnDodajPostrojbu);
            this.Controls.Add(this.btnIzbrisiPostrojbu);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPostrojbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz postrojbi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzbrisiPostrojbu;
        private System.Windows.Forms.Button btnDodajPostrojbu;
        private System.Windows.Forms.Button btnIzmjeniPostrojbu;
    }
}