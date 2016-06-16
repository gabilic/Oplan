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
    public partial class frmPostrojba : Form
    {
        public frmPostrojba()
        {
            InitializeComponent();
        }

        private void frmPostrojba_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            using (var db = new EntitiesSettings())
            {
                cmbVrsta.DataSource = db.vrsta.ToList();
                cmbVrsta.ValueMember = "id_vrsta";
                cmbVrsta.DisplayMember = "naziv";
                cmbTip.DataSource = db.tip.ToList();
                cmbTip.ValueMember = "id_tip";
                cmbTip.DisplayMember = "naziv";
            }
        }

        private void cmbVrsta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbVrsta.SelectedItem != null)
            {
                using (var db = new EntitiesSettings())
                {
                    var item = cmbVrsta.SelectedItem as vrsta;
                    int id = item.id_vrsta;
                    var upit = (from v in db.vrsta
                               where v.id_vrsta == id
                               select v.opis).FirstOrDefault();
                    tltVrsta.SetToolTip(lblVrstaHelp, String.Format(upit, Environment.NewLine));
                }
            }
        }

        private void cmbTip_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem != null)
            {
                using (var db = new EntitiesSettings())
                {
                    var item = cmbTip.SelectedItem as tip;
                    int id = item.id_tip;
                    var upit = (from t in db.tip
                                where t.id_tip == id
                                select t.opis).FirstOrDefault();
                    tltTip.SetToolTip(lblTipHelp, String.Format(upit, Environment.NewLine));
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVI_TextChanged(object sender, EventArgs e)
        {
            int vrijednost = 0;
            if (int.TryParse(txtVI.Text, out vrijednost))
            {
                if (vrijednost >= 1 && vrijednost <= 100)
                {
                    tkbIzdrzljivost.Value = vrijednost;
                }
            }
        }

        private void txtVB_TextChanged(object sender, EventArgs e)
        {
            int vrijednost = 0;
            if (int.TryParse(txtVB.Text, out vrijednost))
            {
                if (vrijednost >= 1 && vrijednost <= 100)
                {
                    tkbBrzina.Value = vrijednost;
                }
            }
        }

        private void tkbIzdrzljivost_Scroll(object sender, EventArgs e)
        {
            txtVI.Text = tkbIzdrzljivost.Value.ToString();
        }

        private void tkbBrzina_Scroll(object sender, EventArgs e)
        {
            txtVB.Text = tkbBrzina.Value.ToString();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var itemVrsta = cmbVrsta.SelectedItem as vrsta;
            int idVrsta = itemVrsta.id_vrsta;
            var itemTip = cmbTip.SelectedItem as tip;
            int idTip = itemTip.id_tip;

            if (RadSPostrojbama.ProvjeriPostrojbu(idVrsta, idTip))
            {
                postrojba postrojba = new postrojba
                {
                    izdrzljivost = Math.Round((double)tkbIzdrzljivost.Value / 100, 2),
                    brzina = Math.Round((double)tkbBrzina.Value / 100, 2),
                    id_vrsta = idVrsta,
                    id_tip = idTip
                };
                using (var db = new EntitiesSettings())
                {
                    db.postrojba.Add(postrojba);
                    db.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Takva postrojba već postoji u bazi podataka!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
