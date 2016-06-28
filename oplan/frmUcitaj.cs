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
    public partial class frmUcitaj : Form
    {
        public frmUcitaj()
        {
            InitializeComponent();
        }

        private void cmbNaziv_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var db = new EntitiesSettings())
            {
                var item = cmbNaziv.SelectedItem as plan;
                int id = item.id_plan;
                var upit = (from v in db.vrsta
                            where v.id_vrsta == id
                            select v.opis).FirstOrDefault();
                txtDatum.Text = " " + item.datum.ToString("dd. MM. yyyy.");
            }
        }

        /// <summary>
        /// Postavlja podatke iz baze u padajući izbornik.
        /// </summary>
        public void UcitajPodatke()
        {
            using (var db = new EntitiesSettings())
            {
                cmbNaziv.DataSource = db.plan.ToList();
                cmbNaziv.ValueMember = "id_plan";
                cmbNaziv.DisplayMember = "naziv";
            }
        }

        private void frmUcitaj_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            //taj se id onda proslijedi formi di bude plan
            this.Close();
        }
    }
}
