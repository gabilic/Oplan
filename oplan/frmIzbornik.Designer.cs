namespace oplan
{
    partial class frmIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzbornik));
            this.msGlavni = new System.Windows.Forms.MenuStrip();
            this.miIzbornik = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzbornikNoviPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzbornikUcitajPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tslCrta = new System.Windows.Forms.ToolStripSeparator();
            this.miIzbornikIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracija = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaPostrojbe = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocPrikaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocOPLAN = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arsenalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zemljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipOpremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postrojbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msGlavni.SuspendLayout();
            this.SuspendLayout();
            // 
            // msGlavni
            // 
            this.msGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIzbornik,
            this.miAdministracija,
            this.statistikaToolStripMenuItem,
            this.miPomoc});
            this.msGlavni.Location = new System.Drawing.Point(0, 0);
            this.msGlavni.Name = "msGlavni";
            this.msGlavni.Size = new System.Drawing.Size(1008, 24);
            this.msGlavni.TabIndex = 1;
            this.msGlavni.Text = "menuStrip1";
            // 
            // miIzbornik
            // 
            this.miIzbornik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIzbornikNoviPlan,
            this.miIzbornikUcitajPlan,
            this.toolStripSeparator1,
            this.arsenalToolStripMenuItem,
            this.opremaToolStripMenuItem,
            this.tslCrta,
            this.miIzbornikIzlaz});
            this.miIzbornik.Name = "miIzbornik";
            this.miIzbornik.Size = new System.Drawing.Size(61, 20);
            this.miIzbornik.Text = "Izbornik";
            // 
            // miIzbornikNoviPlan
            // 
            this.miIzbornikNoviPlan.Name = "miIzbornikNoviPlan";
            this.miIzbornikNoviPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miIzbornikNoviPlan.Size = new System.Drawing.Size(234, 22);
            this.miIzbornikNoviPlan.Text = "Novi plan";
            this.miIzbornikNoviPlan.Click += new System.EventHandler(this.miIzbornikNoviPlan_Click);
            // 
            // miIzbornikUcitajPlan
            // 
            this.miIzbornikUcitajPlan.Name = "miIzbornikUcitajPlan";
            this.miIzbornikUcitajPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miIzbornikUcitajPlan.Size = new System.Drawing.Size(234, 22);
            this.miIzbornikUcitajPlan.Text = "Učitaj plan";
            this.miIzbornikUcitajPlan.Click += new System.EventHandler(this.miIzbornikUcitajPlan_Click);
            // 
            // tslCrta
            // 
            this.tslCrta.Name = "tslCrta";
            this.tslCrta.Size = new System.Drawing.Size(231, 6);
            // 
            // miIzbornikIzlaz
            // 
            this.miIzbornikIzlaz.Name = "miIzbornikIzlaz";
            this.miIzbornikIzlaz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miIzbornikIzlaz.Size = new System.Drawing.Size(234, 22);
            this.miIzbornikIzlaz.Text = "Izlaz";
            this.miIzbornikIzlaz.Click += new System.EventHandler(this.miIzbornikIzlaz_Click);
            // 
            // miAdministracija
            // 
            this.miAdministracija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdministracijaPostrojbe,
            this.miAdministracijaKorisnici});
            this.miAdministracija.Name = "miAdministracija";
            this.miAdministracija.Size = new System.Drawing.Size(95, 20);
            this.miAdministracija.Text = "Administracija";
            // 
            // miAdministracijaPostrojbe
            // 
            this.miAdministracijaPostrojbe.Name = "miAdministracijaPostrojbe";
            this.miAdministracijaPostrojbe.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.miAdministracijaPostrojbe.Size = new System.Drawing.Size(246, 22);
            this.miAdministracijaPostrojbe.Text = "Rad s postrojbama";
            this.miAdministracijaPostrojbe.Click += new System.EventHandler(this.miAdministracijaPostrojbe_Click);
            // 
            // miAdministracijaKorisnici
            // 
            this.miAdministracijaKorisnici.Name = "miAdministracijaKorisnici";
            this.miAdministracijaKorisnici.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.miAdministracijaKorisnici.Size = new System.Drawing.Size(246, 22);
            this.miAdministracijaKorisnici.Text = "Rad s korisnicima";
            this.miAdministracijaKorisnici.Click += new System.EventHandler(this.miAdministracijaKorisnici_Click);
            // 
            // miPomoc
            // 
            this.miPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPomocPrikaz,
            this.miPomocOPLAN});
            this.miPomoc.Name = "miPomoc";
            this.miPomoc.Size = new System.Drawing.Size(57, 20);
            this.miPomoc.Text = "Pomoć";
            // 
            // miPomocPrikaz
            // 
            this.miPomocPrikaz.Name = "miPomocPrikaz";
            this.miPomocPrikaz.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miPomocPrikaz.Size = new System.Drawing.Size(168, 22);
            this.miPomocPrikaz.Text = "Prikaz pomoći";
            this.miPomocPrikaz.Click += new System.EventHandler(this.miPomocPrikaz_Click);
            // 
            // miPomocOPLAN
            // 
            this.miPomocOPLAN.Name = "miPomocOPLAN";
            this.miPomocOPLAN.Size = new System.Drawing.Size(168, 22);
            this.miPomocOPLAN.Text = "O OPLAN-u";
            this.miPomocOPLAN.Click += new System.EventHandler(this.miPomocOPLAN_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zemljeToolStripMenuItem,
            this.tipOpremeToolStripMenuItem,
            this.postrojbeToolStripMenuItem,
            this.opremaToolStripMenuItem1});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // opremaToolStripMenuItem
            // 
            this.opremaToolStripMenuItem.Name = "opremaToolStripMenuItem";
            this.opremaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.opremaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.opremaToolStripMenuItem.Text = "Rad s opremom";
            this.opremaToolStripMenuItem.Click += new System.EventHandler(this.opremaToolStripMenuItem_Click);
            // 
            // arsenalToolStripMenuItem
            // 
            this.arsenalToolStripMenuItem.Name = "arsenalToolStripMenuItem";
            this.arsenalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.arsenalToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.arsenalToolStripMenuItem.Text = "Rad s arsenalom";
            this.arsenalToolStripMenuItem.Click += new System.EventHandler(this.arsenalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // zemljeToolStripMenuItem
            // 
            this.zemljeToolStripMenuItem.Name = "zemljeToolStripMenuItem";
            this.zemljeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.zemljeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zemljeToolStripMenuItem.Text = "Zemlje";
            // 
            // tipOpremeToolStripMenuItem
            // 
            this.tipOpremeToolStripMenuItem.Name = "tipOpremeToolStripMenuItem";
            this.tipOpremeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.tipOpremeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tipOpremeToolStripMenuItem.Text = "Tip opreme";
            // 
            // postrojbeToolStripMenuItem
            // 
            this.postrojbeToolStripMenuItem.Name = "postrojbeToolStripMenuItem";
            this.postrojbeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.postrojbeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.postrojbeToolStripMenuItem.Text = "Postrojbe";
            // 
            // opremaToolStripMenuItem1
            // 
            this.opremaToolStripMenuItem1.Name = "opremaToolStripMenuItem1";
            this.opremaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.opremaToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.opremaToolStripMenuItem1.Text = "Oprema";
            // 
            // frmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.msGlavni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msGlavni;
            this.Name = "frmIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPLAN";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.msGlavni.ResumeLayout(false);
            this.msGlavni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavni;
        private System.Windows.Forms.ToolStripMenuItem miIzbornik;
        private System.Windows.Forms.ToolStripMenuItem miIzbornikNoviPlan;
        private System.Windows.Forms.ToolStripMenuItem miIzbornikUcitajPlan;
        private System.Windows.Forms.ToolStripMenuItem miAdministracija;
        private System.Windows.Forms.ToolStripMenuItem miAdministracijaPostrojbe;
        private System.Windows.Forms.ToolStripMenuItem miAdministracijaKorisnici;
        private System.Windows.Forms.ToolStripMenuItem miPomoc;
        private System.Windows.Forms.ToolStripMenuItem miPomocPrikaz;
        private System.Windows.Forms.ToolStripMenuItem miPomocOPLAN;
        private System.Windows.Forms.ToolStripSeparator tslCrta;
        private System.Windows.Forms.ToolStripMenuItem miIzbornikIzlaz;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arsenalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zemljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipOpremeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postrojbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaToolStripMenuItem1;
    }
}