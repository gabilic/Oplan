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
    public partial class frmKorisnikIzbor : Form
    {
        public frmKorisnikIzbor()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlan noviPlan = new frmPlan();
            noviPlan.ShowDialog();
            this.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (cbxIzbor.SelectedItem != null)
            {
                //ucitaj taj plan
            } 
            else
            {
                MessageBox.Show("Niste odabrali plan!");
            }
        }
    }
}
