using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class RadSKorisnicima
    {
        /// <summary>
        /// Prikazuje popis korisnika u bazi pomoću liste korisnika.
        /// </summary>
        /// <param name="korisnikBindingSource">Naziv vezanog izvora podataka</param>
        static public void PrikaziKorisnike(BindingSource korisnikBindingSource)
        {
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new EntitiesSettings())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisnik.ToList());
            }
            korisnikBindingSource.DataSource = listaKorisnika;
        }

        /// <summary>
        /// Prikazuje formu za dodavanje korisnika te prikazuje ažurirane korisnike po završetku.
        /// </summary>
        /// <param name="korisnikBindingSource">Naziv vezanog izvora podataka</param>
        static public void DodajKorisnika(BindingSource korisnikBindingSource)
        {
            frmDodajKorisnika formaKorisnik = new frmDodajKorisnika();
            formaKorisnik.ShowDialog();
            PrikaziKorisnike(korisnikBindingSource);
        }

        /// <summary>
        /// Briše korisnika ako nema zapisa u dnevniku, a u suprotnom briše i zapise ukoliko je korisnik to potvrdio.
        /// </summary>
        /// <param name="korisnikBindingSource">Naziv vezanog izvora podataka</param>
        static public void IzbrisiKorisnika(BindingSource korisnikBindingSource)
        {
            korisnik korisnik = korisnikBindingSource.Current as korisnik;
            if (Izvjestaji.ProvjeriIzvjestaj(korisnik.id_korisnik))
            {
                if (MessageBox.Show("Za ovog korisnika postoji izvještaj. Želite li obrisati i izvještaj?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Izvjestaji.IzbrisiIzvjestaj(korisnik.id_korisnik);
                    using (var db = new EntitiesSettings())
                    {
                        db.korisnik.Attach(korisnik);
                        db.korisnik.Remove(korisnik);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ste izbrisali korisnika i njegov izvještaj.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziKorisnike(korisnikBindingSource);
                }
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati ovog korisnika?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new EntitiesSettings())
                    {
                        db.korisnik.Attach(korisnik);
                        db.korisnik.Remove(korisnik);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ste izbrisali korisnika.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziKorisnike(korisnikBindingSource);
                }
            }
        }

        /// <summary>
        /// Prikazuje formu za izmjenu korisnika te prikazuje ažurirane korisnike po završetku.
        /// </summary>
        /// <param name="korisnikBindingSource">Naziv vezanog izvora podataka</param>
        /// <param name="id">ID korisnika označenog za brisanje</param>
        static public void IzmijeniKorisnika(BindingSource korisnikBindingSource, int id)
        {
            if (korisnikBindingSource.Current as korisnik != null)
            {
                frmDodajKorisnika formaKorisnik = new frmDodajKorisnika(korisnikBindingSource.Current as korisnik, id);
                formaKorisnik.ShowDialog();
                PrikaziKorisnike(korisnikBindingSource);
            }
        }
    }
}
