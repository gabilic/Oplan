using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    public partial class frmDnevnik : Form
    {
        private korisnik odabraniKorisnik;

        public frmDnevnik(korisnik trenutniKorisnik)
        {
            InitializeComponent();
            odabraniKorisnik = trenutniKorisnik;
            this.Text = IspisiNaslov(odabraniKorisnik);
        }

        private void frmDnevnik_Load(object sender, EventArgs e)
        {
            Izvjestaji.PrikaziIzvjestaj(odabraniKorisnik, rtvDnevnik);
            this.rtvDnevnik.SetDisplayMode(DisplayMode.PrintLayout);
            this.rtvDnevnik.ZoomMode = ZoomMode.Percent;
            this.rtvDnevnik.ZoomPercent = 100;
            this.rtvDnevnik.RefreshReport();
        }

        /// <summary>
        /// Određuje naslov forme koja prikazuje izvještaj za određenog korisnika.
        /// </summary>
        /// <returns>Tekst koji predstavlja naslov forme.</returns>
        public string IspisiNaslov(korisnik korisnik)
        {
            string naslovForme = "Dnevnik rada: ";
            if (korisnik.administrator == "Da")
            {
                naslovForme += "Administrator ";
            }
            else
            {
                naslovForme += "Korisnik ";
            }
            return naslovForme + korisnik.korisnicko_ime;
        }
    }
}
