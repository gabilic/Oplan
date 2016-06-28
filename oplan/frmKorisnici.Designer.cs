namespace oplan
{
    partial class frmKorisnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisnici));
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnIzmijeniKorisnika = new System.Windows.Forms.Button();
            this.btnIzbrisiKorisnika = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.idkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkorisnikDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.administratorDataGridViewTextBoxColumn,
            this.promjenaDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisnikBindingSource;
            this.dgvKorisnici.Location = new System.Drawing.Point(13, 13);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.Size = new System.Drawing.Size(480, 352);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajKorisnika.Location = new System.Drawing.Point(105, 378);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnDodajKorisnika.TabIndex = 2;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnIzmijeniKorisnika
            // 
            this.btnIzmijeniKorisnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzmijeniKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniKorisnika.Location = new System.Drawing.Point(236, 378);
            this.btnIzmijeniKorisnika.Name = "btnIzmijeniKorisnika";
            this.btnIzmijeniKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniKorisnika.TabIndex = 3;
            this.btnIzmijeniKorisnika.Text = "Izmijeni korisnika";
            this.btnIzmijeniKorisnika.UseVisualStyleBackColor = true;
            this.btnIzmijeniKorisnika.Click += new System.EventHandler(this.btnIzmijeniKorisnika_Click);
            // 
            // btnIzbrisiKorisnika
            // 
            this.btnIzbrisiKorisnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzbrisiKorisnika.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiKorisnika.Location = new System.Drawing.Point(368, 378);
            this.btnIzbrisiKorisnika.Name = "btnIzbrisiKorisnika";
            this.btnIzbrisiKorisnika.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiKorisnika.TabIndex = 4;
            this.btnIzbrisiKorisnika.Text = "Izbriši korisnika";
            this.btnIzbrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnIzbrisiKorisnika.Click += new System.EventHandler(this.btnIzbrisiKorisnika_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzvjestaj.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzvjestaj.Location = new System.Drawing.Point(13, 378);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(86, 32);
            this.btnIzvjestaj.TabIndex = 5;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // idkorisnikDataGridViewTextBoxColumn
            // 
            this.idkorisnikDataGridViewTextBoxColumn.DataPropertyName = "id_korisnik";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.idkorisnikDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idkorisnikDataGridViewTextBoxColumn.HeaderText = "ID korisnika";
            this.idkorisnikDataGridViewTextBoxColumn.Name = "idkorisnikDataGridViewTextBoxColumn";
            this.idkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnickoimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lozinkaDataGridViewTextBoxColumn.Width = 105;
            // 
            // administratorDataGridViewTextBoxColumn
            // 
            this.administratorDataGridViewTextBoxColumn.DataPropertyName = "administrator";
            this.administratorDataGridViewTextBoxColumn.HeaderText = "Administrator";
            this.administratorDataGridViewTextBoxColumn.Name = "administratorDataGridViewTextBoxColumn";
            this.administratorDataGridViewTextBoxColumn.ReadOnly = true;
            this.administratorDataGridViewTextBoxColumn.Width = 95;
            // 
            // promjenaDataGridViewTextBoxColumn
            // 
            this.promjenaDataGridViewTextBoxColumn.DataPropertyName = "promjena";
            this.promjenaDataGridViewTextBoxColumn.HeaderText = "promjena";
            this.promjenaDataGridViewTextBoxColumn.Name = "promjenaDataGridViewTextBoxColumn";
            this.promjenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.promjenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(oplan.korisnik);
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 422);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnIzbrisiKorisnika);
            this.Controls.Add(this.btnIzmijeniKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.dgvKorisnici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s korisnicima";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnIzmijeniKorisnika;
        private System.Windows.Forms.Button btnIzbrisiKorisnika;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administratorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promjenaDataGridViewTextBoxColumn;
    }
}