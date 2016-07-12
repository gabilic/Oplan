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
    public partial class frmKorisnici : Form
    {
        private int prijavljeniKorisnik;

        /// <summary>
        /// Konstruktor kojem se proslijeđuje ID trenutnog korisnika.
        /// </summary>
        /// <param name="id">ID prijavljenog korisnika</param>
        public frmKorisnici(int id)
        {
            InitializeComponent();
            prijavljeniKorisnik = id;
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            RadSKorisnicima.PrikaziKorisnike(korisnikBindingSource);
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            RadSKorisnicima.DodajKorisnika(korisnikBindingSource);
        }

        private void btnIzmijeniKorisnika_Click(object sender, EventArgs e)
        {
            RadSKorisnicima.IzmijeniKorisnika(korisnikBindingSource, prijavljeniKorisnik);
        }

        private void btnIzbrisiKorisnika_Click(object sender, EventArgs e)
        {
            RadSKorisnicima.IzbrisiKorisnika(korisnikBindingSource);
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            korisnik odabraniKorisnik = korisnikBindingSource.Current as korisnik;
            if (Izvjestaji.ProvjeriIzvjestaj(odabraniKorisnik.id_korisnik))
            {
                frmDnevnik formaDnevnik = new frmDnevnik(odabraniKorisnik);
                formaDnevnik.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ovaj korisnik nema unosa u dnevniku rada.", "Izvještaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
