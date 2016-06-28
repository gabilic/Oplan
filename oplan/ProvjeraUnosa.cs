using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class ProvjeraUnosa
    {
        ///<summary>
        ///Provjerava jesu li u upisanom polju brojke i slova.
        ///</summary>
        ///<returns>True ako je unos u redu, false ako nije.</returns>
        static public bool ProvjeriTekst (string tekst)
        {
            if (Regex.IsMatch(tekst, @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<summary>
        ///Provjerava jesu li u upisanom brojke, slova i razmak.
        ///</summary>
        ///<returns>True ako je unos u redu, false ako nije.</returns>
        static public bool ProvjeriNaziv (string tekst)
        {
            if (Regex.IsMatch(tekst, @"^[a-zA-Z0-9 ]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Provjerava jesu li korisničko ime i lozinka pravilno upisani.
        /// </summary>
        /// <returns>Tekst pogreške ako se dogodila ili null ako je upis u redu.</returns>
        static public string ProvjeriOblik (string Korime, string Lozinka)
        {
            string poruka = null;
            
            if (!ProvjeriTekst(Korime))
            {
                poruka += "Korisničko ime može sadržavati samo velika i mala slova te brojeve!\n";
            }

            if (!ProvjeriTekst(Lozinka))
            {
                poruka += "Lozinka može sadržavati samo velika i mala slova te brojeve!\n";
            }
            
            return poruka;
        }
    }
}
