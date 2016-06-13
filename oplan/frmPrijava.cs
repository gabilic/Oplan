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
    public partial class frmPrijava : Form
    {

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            btnPrijava.Enabled = false;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if ( ProvjeraUnosa.ProvjeriTekst(txtKorime.Text) || ProvjeraUnosa.ProvjeriTekst(txtLozinka.Text) )
            {
                this.Hide();
                ProvjeraKorisnika.ProvjeriKorisnika(txtKorime.Text, txtLozinka.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Unesena polja nisu u dobrom obliku");
            }
        }

        private void txtKorime_TextChanged(object sender, EventArgs e)
        {
            ProvjeraPraznogUnosa();
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            ProvjeraPraznogUnosa();
        }

        private void ProvjeraPraznogUnosa()
        {
            if (string.IsNullOrEmpty(txtKorime.Text) || string.IsNullOrEmpty(txtLozinka.Text))
            {
                btnPrijava.Enabled = false;
            }
            else
            {
                btnPrijava.Enabled = true;
            }
        }
    }
}
