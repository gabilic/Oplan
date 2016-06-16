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
    public partial class frmIzbornik : Form
    {
        public frmIzbornik(bool administrator)
        {
            InitializeComponent();
            if (!administrator)
            {
                msGlavni.Items.Remove(miAdministracija);
            }
        }

        private void miAdministracijaPostrojbe_Click(object sender, EventArgs e)
        {
            frmPostrojbe postrojbe = new frmPostrojbe();
            postrojbe.ShowDialog();
        }

        private void miAdministracijaKorisnici_Click(object sender, EventArgs e)
        {
            frmKorisnici korisnici = new frmKorisnici();
            korisnici.ShowDialog();
        }

        private void miIzbornikIzlaz_Click(object sender, EventArgs e)
        {
            //Još bi trebalo da ako plan nije spremljen onda da ga se pita dal oće spremiti plan dok izlazi
            this.Close();
        }
    }
}
