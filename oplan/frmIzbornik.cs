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
        private int prijavljeniKorisnik;

        public frmIzbornik(bool administrator, int id)
        {
            InitializeComponent();
            prijavljeniKorisnik = id;
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
            this.Close();
        }

        private void miIzbornikNoviPlan_Click(object sender, EventArgs e)
        {
            frmPlan formaPlan = new frmPlan();
            formaPlan.MdiParent = this;
            formaPlan.WindowState = FormWindowState.Maximized;
            formaPlan.Show();
        }

        private void miIzbornikUcitajPlan_Click(object sender, EventArgs e)
        {

        }

        private void miPomocPrikaz_Click(object sender, EventArgs e)
        {

        }

        private void miPomocOPLAN_Click(object sender, EventArgs e)
        {

        }

        private void opremaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arsenalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
