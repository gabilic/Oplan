namespace oplan
{
    partial class ucUnosOpisa
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblPogreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(0, 0);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(309, 142);
            this.txtOpis.TabIndex = 0;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // lblPogreska
            // 
            this.lblPogreska.AutoSize = true;
            this.lblPogreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPogreska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPogreska.Location = new System.Drawing.Point(24, 143);
            this.lblPogreska.Name = "lblPogreska";
            this.lblPogreska.Size = new System.Drawing.Size(260, 17);
            this.lblPogreska.TabIndex = 1;
            this.lblPogreska.Text = "Polje za unos opisa ne smije biti prazno!";
            // 
            // ucUnosOpisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPogreska);
            this.Controls.Add(this.txtOpis);
            this.Name = "ucUnosOpisa";
            this.Size = new System.Drawing.Size(309, 162);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblPogreska;
    }
}
