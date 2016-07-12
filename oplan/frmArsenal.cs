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
    public partial class frmArsenal : Form
    {
        private int filter = 1;

        public frmArsenal()
        {
            InitializeComponent();
        }

        private void frmArsenal_Load(object sender, EventArgs e)
        {
            RadSArsenalom.PopuniPostrojbama(cmbFilter);
            rdbPostrojba.Checked = true;

            RadSArsenalom.PrikaziPoPostrojbama(dgvArsenal, (int)cmbFilter.SelectedValue);
        }

        private void btnDodajDodjelu_Click(object sender, EventArgs e)
        {
            frmDodajArsenal novaDodjela = new frmDodajArsenal();
            novaDodjela.ShowDialog();
            RadSArsenalom.PrikaziPodatke(filter, dgvArsenal, cmbFilter);
        }

        private void btnIzmijeniDodjelu_Click(object sender, EventArgs e)
        {
            frmDodajArsenal novaDodjela = new frmDodajArsenal((int)dgvArsenal.CurrentRow.Cells[0].Value, (int)dgvArsenal.CurrentRow.Cells[1].Value);
            novaDodjela.ShowDialog();
            RadSArsenalom.PrikaziPodatke(filter, dgvArsenal, cmbFilter);
        }

        private void btnIzbrisiDodjelu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati dio ovog arsenala?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                RadSArsenalom.ObrisiArsenal((int)dgvArsenal.CurrentRow.Cells[0].Value, (int)dgvArsenal.CurrentRow.Cells[1].Value);
                MessageBox.Show("Uspješno ste uklonili zapis.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RadSArsenalom.PrikaziPodatke(filter, dgvArsenal, cmbFilter);
        }

        private void cmbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            RadSArsenalom.PrikaziPodatke(filter, dgvArsenal, cmbFilter);
        }

        private void btnOpis_Click(object sender, EventArgs e)
        {
            if(filter == 1)
            {
                frmOpis detaljniOpis = new frmOpis(dgvArsenal.CurrentRow.Cells[2].Value.ToString(), dgvArsenal.CurrentRow.Cells[5].Value.ToString());
                detaljniOpis.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odabir nije filtriran po postrojbama.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbPostrojba_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbPostrojba.Checked == true)
            {
                filter = 1;
                RadSArsenalom.PopuniPostrojbama(cmbFilter);
            }
            else
            {
                filter = 2;
                RadSArsenalom.PopuniOpremom(cmbFilter);
            }
        }
    }
}
