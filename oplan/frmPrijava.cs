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
            string poruka = ProvjeraUnosa.ProvjeriOblik(txtKorime.Text, txtLozinka.Text);
            if (poruka == null)
            {
                ProvjeraKorisnika.ProvjeriKorisnika(this, txtKorime.Text, txtLozinka.Text);
            }
            else
            {
                MessageBox.Show(poruka, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        ///<summary>
        ///Provjerava jesu li korisničko ime i lozinku prazni te omogućava gumb za prijavu.
        ///</summary>
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
