namespace oplan
{
    partial class frmArsenal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArsenal));
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.rdbOprema = new System.Windows.Forms.RadioButton();
            this.rdbPostrojba = new System.Windows.Forms.RadioButton();
            this.dgvArsenal = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiDodjelu = new System.Windows.Forms.Button();
            this.btnIzmijeniDodjelu = new System.Windows.Forms.Button();
            this.btnDodajDodjelu = new System.Windows.Forms.Button();
            this.btnOpis = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.pomoc = new System.Windows.Forms.HelpProvider();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArsenal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilter.Location = new System.Drawing.Point(12, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(106, 17);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Odaberite filter:";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.rdbOprema);
            this.gbxFilter.Controls.Add(this.rdbPostrojba);
            this.gbxFilter.Location = new System.Drawing.Point(124, 0);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(152, 33);
            this.gbxFilter.TabIndex = 1;
            this.gbxFilter.TabStop = false;
            // 
            // rdbOprema
            // 
            this.rdbOprema.AutoSize = true;
            this.rdbOprema.Location = new System.Drawing.Point(84, 10);
            this.rdbOprema.Name = "rdbOprema";
            this.rdbOprema.Size = new System.Drawing.Size(62, 17);
            this.rdbOprema.TabIndex = 2;
            this.rdbOprema.TabStop = true;
            this.rdbOprema.Text = "Oprema";
            this.rdbOprema.UseVisualStyleBackColor = true;
            // 
            // rdbPostrojba
            // 
            this.rdbPostrojba.AutoSize = true;
            this.rdbPostrojba.Location = new System.Drawing.Point(10, 10);
            this.rdbPostrojba.Name = "rdbPostrojba";
            this.rdbPostrojba.Size = new System.Drawing.Size(69, 17);
            this.rdbPostrojba.TabIndex = 1;
            this.rdbPostrojba.TabStop = true;
            this.rdbPostrojba.Text = "Postrojba";
            this.rdbPostrojba.UseVisualStyleBackColor = true;
            this.rdbPostrojba.CheckedChanged += new System.EventHandler(this.rdbPostrojba_CheckedChanged);
            // 
            // dgvArsenal
            // 
            this.dgvArsenal.AllowUserToAddRows = false;
            this.dgvArsenal.AllowUserToDeleteRows = false;
            this.dgvArsenal.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArsenal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArsenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArsenal.Location = new System.Drawing.Point(15, 40);
            this.dgvArsenal.Name = "dgvArsenal";
            this.dgvArsenal.ReadOnly = true;
            this.dgvArsenal.Size = new System.Drawing.Size(594, 352);
            this.dgvArsenal.TabIndex = 3;
            // 
            // btnIzbrisiDodjelu
            // 
            this.btnIzbrisiDodjelu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzbrisiDodjelu.Location = new System.Drawing.Point(484, 398);
            this.btnIzbrisiDodjelu.Name = "btnIzbrisiDodjelu";
            this.btnIzbrisiDodjelu.Size = new System.Drawing.Size(125, 32);
            this.btnIzbrisiDodjelu.TabIndex = 4;
            this.btnIzbrisiDodjelu.Text = "Izbriši dodjelu";
            this.btnIzbrisiDodjelu.UseVisualStyleBackColor = true;
            this.btnIzbrisiDodjelu.Click += new System.EventHandler(this.btnIzbrisiDodjelu_Click);
            // 
            // btnIzmijeniDodjelu
            // 
            this.btnIzmijeniDodjelu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnIzmijeniDodjelu.Location = new System.Drawing.Point(353, 398);
            this.btnIzmijeniDodjelu.Name = "btnIzmijeniDodjelu";
            this.btnIzmijeniDodjelu.Size = new System.Drawing.Size(125, 32);
            this.btnIzmijeniDodjelu.TabIndex = 5;
            this.btnIzmijeniDodjelu.Text = "Izmjeni dodjelu";
            this.btnIzmijeniDodjelu.UseVisualStyleBackColor = true;
            this.btnIzmijeniDodjelu.Click += new System.EventHandler(this.btnIzmijeniDodjelu_Click);
            // 
            // btnDodajDodjelu
            // 
            this.btnDodajDodjelu.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDodajDodjelu.Location = new System.Drawing.Point(222, 398);
            this.btnDodajDodjelu.Name = "btnDodajDodjelu";
            this.btnDodajDodjelu.Size = new System.Drawing.Size(125, 32);
            this.btnDodajDodjelu.TabIndex = 6;
            this.btnDodajDodjelu.Text = "Dodijeli opremu";
            this.btnDodajDodjelu.UseVisualStyleBackColor = true;
            this.btnDodajDodjelu.Click += new System.EventHandler(this.btnDodajDodjelu_Click);
            // 
            // btnOpis
            // 
            this.btnOpis.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnOpis.Location = new System.Drawing.Point(15, 398);
            this.btnOpis.Name = "btnOpis";
            this.btnOpis.Size = new System.Drawing.Size(117, 32);
            this.btnOpis.TabIndex = 7;
            this.btnOpis.Text = "Opis opreme";
            this.btnOpis.UseVisualStyleBackColor = true;
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(288, 8);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(321, 24);
            this.cmbFilter.TabIndex = 8;
            this.cmbFilter.SelectedValueChanged += new System.EventHandler(this.cmbFilter_SelectedValueChanged);
            // 
            // pomoc
            // 
            this.pomoc.HelpNamespace = "../../help/oplan.chm";
            // 
            // frmArsenal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnOpis);
            this.Controls.Add(this.btnDodajDodjelu);
            this.Controls.Add(this.btnIzmijeniDodjelu);
            this.Controls.Add(this.btnIzbrisiDodjelu);
            this.Controls.Add(this.dgvArsenal);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.lblFilter);
            this.pomoc.SetHelpKeyword(this, "F1");
            this.pomoc.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pomoc.SetHelpString(this, "F1");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArsenal";
            this.pomoc.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad s arsenalom";
            this.Load += new System.EventHandler(this.frmArsenal_Load);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArsenal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.RadioButton rdbOprema;
        private System.Windows.Forms.RadioButton rdbPostrojba;
        private System.Windows.Forms.DataGridView dgvArsenal;
        private System.Windows.Forms.Button btnIzbrisiDodjelu;
        private System.Windows.Forms.Button btnIzmijeniDodjelu;
        private System.Windows.Forms.Button btnDodajDodjelu;
        private System.Windows.Forms.Button btnOpis;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.HelpProvider pomoc;
    }
}