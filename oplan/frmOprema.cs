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
    public partial class frmOprema : Form
    {
        public frmOprema()
        {
            InitializeComponent();
        }

        private void frmOprema_Load(object sender, EventArgs e)
        {
            RadSOpremom.PrikaziOpremu(dgvOprema);
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            RadSOpremom.DodajOpremu(dgvOprema);
        }

        private void btnIzmjeniOpremu_Click(object sender, EventArgs e)
        {
            RadSOpremom.IzmijeniOpremu(dgvOprema, dgvOprema.CurrentRow);
        }

        private void btnIzbrisiOpremu_Click(object sender, EventArgs e)
        {
            RadSOpremom.IzbrisiOpremu(dgvOprema, dgvOprema.CurrentRow);
        }
    }
}
