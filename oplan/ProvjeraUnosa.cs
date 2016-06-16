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
    }
}
