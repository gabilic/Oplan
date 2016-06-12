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
        static public void ProvjeriKorisnika(string korisnickoIme, string lozinka)
        {
            if (lozinka == "admin")
            {
                frmAdminIzbor formaAdmin = new frmAdminIzbor();
                formaAdmin.ShowDialog();
            }
            else
            {
                frmKorisnikIzbor formaKorisnik = new frmKorisnikIzbor();
                formaKorisnik.ShowDialog();
            }
        }
    }
}
