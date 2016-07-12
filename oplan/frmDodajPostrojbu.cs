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
    public partial class frmDodajPostrojbu : Form
    {
        private DataGridViewRow redakZaIzmjenu;

        public frmDodajPostrojbu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor klase koji se poziva pri promjeni postrojbe.
        /// </summary>
        /// <param name="currentRow">Redak koji se mijenja</param>
        public frmDodajPostrojbu(DataGridViewRow currentRow)
        {
            InitializeComponent();
            redakZaIzmjenu = currentRow;
            this.Text = "Izmjena postrojbe";
        }

        private void frmPostrojba_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            if (redakZaIzmjenu != null)
            {
                using (var db = new EntitiesSettings())
                {
                    List<postrojba> listaPostrojbi = new List<postrojba>(db.postrojba.ToList());
                    foreach (var postrojba in listaPostrojbi)
                    {
                        if (postrojba.id_postrojba == (int)redakZaIzmjenu.Cells[0].Value)
                        {
                            foreach (var item in cmbVrsta.Items)
                            {
                                if ((item as vrsta).id_vrsta == postrojba.id_vrsta)
                                {
                                    cmbVrsta.SelectedItem = item;
                                }
                            }
                            foreach (var item in cmbTip.Items)
                            {
                                if ((item as tip_postrojbe).id_tip == postrojba.id_tip)
                                {
                                    cmbTip.SelectedItem = item;
                                }
                            }

                            tkbIzdrzljivost.Value = (int)(postrojba.izdrzljivost * 100);
                            txtVI.Text = ((int)(postrojba.izdrzljivost * 100)).ToString();
                            tkbBrzina.Value = (int)(postrojba.brzina * 100);
                            txtVB.Text = ((int)(postrojba.brzina * 100)).ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Postavlja podatke o vrsti i tipu iz baze u padajuće izbornike.
        /// </summary>
        public void UcitajPodatke()
        {
            using (var db = new EntitiesSettings())
            {
                cmbVrsta.DataSource = db.vrsta.ToList();
                cmbVrsta.ValueMember = "id_vrsta";
                cmbVrsta.DisplayMember = "naziv";
                cmbTip.DataSource = db.tip_postrojbe.ToList();
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
                    var item = cmbTip.SelectedItem as tip_postrojbe;
                    int id = item.id_tip;
                    var upit = (from t in db.tip_postrojbe
                                where t.id_tip == id
                                select t.opis).FirstOrDefault();
                    tltTip.SetToolTip(lblTipHelp, upit);
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
            var itemTip = cmbTip.SelectedItem as tip_postrojbe;
            int idTip = itemTip.id_tip;

            if (RadSPostrojbama.ProvjeriPostrojbu(idVrsta, idTip, redakZaIzmjenu))
            {
                if (redakZaIzmjenu == null)
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
                    MessageBox.Show("Uspješno ste dodali postrojbu.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    using (var db = new EntitiesSettings())
                    {
                        List<postrojba> listaPostrojbi = new List<postrojba>(db.postrojba.ToList());
                        foreach (var postrojba in listaPostrojbi)
                        {
                            if (postrojba.id_postrojba == (int)redakZaIzmjenu.Cells[0].Value)
                            {
                                postrojba.izdrzljivost = Math.Round((double)tkbIzdrzljivost.Value / 100, 2);
                                postrojba.brzina = Math.Round((double)tkbBrzina.Value / 100, 2);
                                postrojba.id_vrsta = idVrsta;
                                postrojba.id_tip = idTip;

                                db.SaveChanges();
                            }
                        }
                    }
                    MessageBox.Show("Uspješno ste izmijenili postrojbu.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Takva postrojba već postoji u bazi podataka!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
