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
            PoslovnaLogika.PrikaziOpremu(dgvOprema);
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            PoslovnaLogika.DodajOpremu(dgvOprema);
        }

        private void btnIzmijeniOpremu_Click(object sender, EventArgs e)
        {
            PoslovnaLogika.IzmijeniOpremu(dgvOprema, dgvOprema.CurrentRow);
        }

        private void btnIzbrisiOpremu_Click(object sender, EventArgs e)
        {
            PoslovnaLogika.IzbrisiOpremu(dgvOprema, dgvOprema.CurrentRow);
        }
    }
}
