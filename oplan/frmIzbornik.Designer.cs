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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miIzbornikArsenal = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzboenikOprema = new System.Windows.Forms.ToolStripMenuItem();
            this.tslCrta = new System.Windows.Forms.ToolStripSeparator();
            this.miIzbornikIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracija = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaPostrojbe = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatistika = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatistikaZemlje = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocPrikaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocOPLAN = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoc = new System.Windows.Forms.HelpProvider();
            this.msGlavni.SuspendLayout();
            this.SuspendLayout();
            // 
            // msGlavni
            // 
            this.msGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIzbornik,
            this.miAdministracija,
            this.miStatistika,
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
            this.miIzbornikArsenal,
            this.miIzboenikOprema,
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // miIzbornikArsenal
            // 
            this.miIzbornikArsenal.Name = "miIzbornikArsenal";
            this.miIzbornikArsenal.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.miIzbornikArsenal.Size = new System.Drawing.Size(234, 22);
            this.miIzbornikArsenal.Text = "Rad s arsenalom";
            this.miIzbornikArsenal.Click += new System.EventHandler(this.miIzbornikArsenal_Click);
            // 
            // miIzboenikOprema
            // 
            this.miIzboenikOprema.Name = "miIzboenikOprema";
            this.miIzboenikOprema.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.miIzboenikOprema.Size = new System.Drawing.Size(234, 22);
            this.miIzboenikOprema.Text = "Rad s opremom";
            this.miIzboenikOprema.Click += new System.EventHandler(this.miIzboenikOprema_Click);
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
            // miStatistika
            // 
            this.miStatistika.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStatistikaZemlje});
            this.miStatistika.Name = "miStatistika";
            this.miStatistika.Size = new System.Drawing.Size(66, 20);
            this.miStatistika.Text = "Statistika";
            // 
            // miStatistikaZemlje
            // 
            this.miStatistikaZemlje.Name = "miStatistikaZemlje";
            this.miStatistikaZemlje.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.miStatistikaZemlje.Size = new System.Drawing.Size(175, 22);
            this.miStatistikaZemlje.Text = "Zemlje";
            this.miStatistikaZemlje.Click += new System.EventHandler(this.miStatistikaZemlje_Click);
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
            // pomoc
            // 
            this.pomoc.HelpNamespace = "../../help/oplan.chm";
            // 
            // frmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.msGlavni);
            this.pomoc.SetHelpKeyword(this, "F1");
            this.pomoc.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.pomoc.SetHelpString(this, "F1");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msGlavni;
            this.Name = "frmIzbornik";
            this.pomoc.SetShowHelp(this, true);
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
        private System.Windows.Forms.ToolStripMenuItem miStatistika;
        private System.Windows.Forms.ToolStripMenuItem miIzboenikOprema;
        private System.Windows.Forms.ToolStripMenuItem miIzbornikArsenal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miStatistikaZemlje;
        private System.Windows.Forms.HelpProvider pomoc;
    }
}