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
        int idOdPlana;
        string nazivPlana;
        private void cmbNaziv_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var db = new EntitiesSettings())
            {
                var item = cmbNaziv.SelectedItem as plan;
                idOdPlana = item.id_plan;
                nazivPlana = item.naziv;
                var upit = (from v in db.vrsta
                            where v.id_vrsta == idOdPlana
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
            List<tocka> sveTocke = new List<tocka>();
            List<tocka> filtriraneTocke = new List<tocka>();
            using (var db = new EntitiesSettings())
            {
                sveTocke = db.tocka.ToList();
                for (int i = 0; i < sveTocke.Count; i++)
                {
                    if (sveTocke[i].id_plan == idOdPlana)
                    {
                        filtriraneTocke.Add(sveTocke[i]);

                    }

                }
            }
            /*Form1 loadajPlan = new Form1(1, filtriraneTocke);

            loadajPlan.Text = nazivPlana;
            loadajPlan.WindowState = FormWindowState.Maximized;
            loadajPlan.Show();*/
            this.Close();
        }
    }
}
