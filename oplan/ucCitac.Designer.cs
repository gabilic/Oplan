namespace oplan
{
    partial class ucCitac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.lblVelicina = new System.Windows.Forms.Label();
            this.cmbVelicina = new System.Windows.Forms.ComboBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(0, 27);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(560, 673);
            this.rtbOpis.TabIndex = 0;
            this.rtbOpis.Text = "";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFont.Location = new System.Drawing.Point(-2, 2);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(40, 17);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Font:";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(41, 0);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(200, 21);
            this.cmbFont.TabIndex = 2;
            this.cmbFont.SelectedValueChanged += new System.EventHandler(this.cmbFont_SelectedValueChanged);
            // 
            // lblVelicina
            // 
            this.lblVelicina.AutoSize = true;
            this.lblVelicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVelicina.Location = new System.Drawing.Point(247, 2);
            this.lblVelicina.Name = "lblVelicina";
            this.lblVelicina.Size = new System.Drawing.Size(61, 17);
            this.lblVelicina.TabIndex = 3;
            this.lblVelicina.Text = "Veličina:";
            // 
            // cmbVelicina
            // 
            this.cmbVelicina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVelicina.FormattingEnabled = true;
            this.cmbVelicina.Location = new System.Drawing.Point(311, 0);
            this.cmbVelicina.Name = "cmbVelicina";
            this.cmbVelicina.Size = new System.Drawing.Size(50, 21);
            this.cmbVelicina.TabIndex = 4;
            this.cmbVelicina.SelectedValueChanged += new System.EventHandler(this.cmbVelicina_SelectedValueChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus.Location = new System.Drawing.Point(367, -1);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 23);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinus.Location = new System.Drawing.Point(397, -1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 23);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "– ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ucCitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.cmbVelicina);
            this.Controls.Add(this.lblVelicina);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.rtbOpis);
            this.Name = "ucCitac";
            this.Size = new System.Drawing.Size(560, 700);
            this.Load += new System.EventHandler(this.ucCitac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label lblVelicina;
        private System.Windows.Forms.ComboBox cmbVelicina;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
    }
}
