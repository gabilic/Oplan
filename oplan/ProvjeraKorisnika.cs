using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class ProvjeraKorisnika
    {
        static private korisnik korisnik = null;

        ///<summary>
        ///Provjerava jesu li korisničko ime i lozinka jednaki onima u bazi za nađenog korisnika. 
        ///Ako je nađen gleda je li korisnik administrator ili obični korisnik te otvara formu glavnog izbornika.
        ///</summary>
        static public void ProvjeriKorisnika(frmPrijava prijava, string korisnickoIme, string lozinka)
        {
            if (!ProvjeriKorisnickoIme(korisnickoIme, lozinka))
            {
                MessageBox.Show("Uneseno korisničko ime ne postoji!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (korisnik.lozinka != lozinka)
            {
                MessageBox.Show("Unijeli ste pogrešnu lozinku!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                prijava.Hide();
                if (korisnik.administrator == "Da")
                {
                    frmIzbornik izbornik = new frmIzbornik(true);
                    izbornik.ShowDialog();
                }
                else
                {
                    frmIzbornik izbornik = new frmIzbornik(false);
                    izbornik.ShowDialog();
                }
                prijava.Close();
            } 
        }

        ///<summary>
        ///Provjerava postoji li korisničko ime na temelju upita prema bazi.
        ///</summary>
        ///<returns>True ako korisničko ime postoji, false ako ne postoji.</returns>
        static public bool ProvjeriKorisnickoIme(string korisnickoIme, string lozinka)
        {
            using (var db = new EntitiesSettings())
            {
                korisnik = (from k in db.korisnik
                                     where k.korisnicko_ime == korisnickoIme
                                     select k).FirstOrDefault<korisnik>();
                if (korisnik == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
