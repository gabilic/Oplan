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
    public partial class frmPostrojbe : Form
    {
        public frmPostrojbe()
        {
            InitializeComponent();
        }

        private void frmPostrojbe_Load(object sender, EventArgs e)
        {
            RadSPostrojbama.PrikaziPostrojbe(dgvPostrojbe);
        }

        private void btnDodajPostrojbu_Click(object sender, EventArgs e)
        {
            RadSPostrojbama.DodajPostrojbu(dgvPostrojbe);
        }

        private void btnIzmijeniPostrojbu_Click(object sender, EventArgs e)
        {
            RadSPostrojbama.IzmijeniPostrojbu(dgvPostrojbe, dgvPostrojbe.CurrentRow);
        }

        private void btnIzbrisiPostrojbu_Click(object sender, EventArgs e)
        {
            RadSPostrojbama.IzbrisiPostrojbu(dgvPostrojbe, dgvPostrojbe.CurrentRow);
        }
    }
}
