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
    public partial class frmDodajOpremu : Form
    {
        private DataGridViewRow redakZaIzmjenu;

        public frmDodajOpremu()
        {
            InitializeComponent();
        }

        public frmDodajOpremu(DataGridViewRow redak)
        {
            InitializeComponent();
            redakZaIzmjenu = redak;
            this.Text = "Izmjena opreme";
        }

        private void frmDodajOpremu_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            if (redakZaIzmjenu != null)
            {
                using (var db = new EntitiesSettings())
                {
                    List<oprema> listaOpreme = new List<oprema>(db.oprema.ToList());
                    foreach (var oprema in listaOpreme)
                    {
                        if (oprema.id_oprema == (int)redakZaIzmjenu.Cells[0].Value)
                        {
                            foreach (var item in cmbTipOpreme.Items)
                            {
                                if ((item as tip_opreme).id_tip_oprema == oprema.id_tip_oprema)
                                {
                                    cmbTipOpreme.SelectedItem = item;
                                }
                            }
                            foreach (var item in cmbZemlja.Items)
                            {
                                if ((item as zemlja).id_zemlja == oprema.id_zemlja)
                                {
                                    cmbZemlja.SelectedItem = item;
                                }
                            }

                            txtModel.Text = oprema.model;
                            txtOpis.Text = oprema.opis;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Učitava podatke iz baze u padajuće izbornike.
        /// </summary>
        public void UcitajPodatke()
        {
            using (var db = new EntitiesSettings())
            {
                cmbTipOpreme.DataSource = db.tip_opreme.ToList();
                cmbTipOpreme.ValueMember = "id_tip_oprema";
                cmbTipOpreme.DisplayMember = "naziv";
                cmbZemlja.DataSource = db.zemlja.ToList();
                cmbZemlja.ValueMember = "id_zemlja";
                cmbZemlja.DisplayMember = "naziv";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var itemTipOpreme = cmbTipOpreme.SelectedItem as tip_opreme;
            int idTipOpreme = itemTipOpreme.id_tip_oprema;
            var itemZemlja = cmbZemlja.SelectedItem as zemlja;
            int idZemlja = itemZemlja.id_zemlja;
            string model = txtModel.Text;

            if (PoslovnaLogika.ProvjeriOpremu(idTipOpreme, idZemlja, model, redakZaIzmjenu))
            {
                if (redakZaIzmjenu == null)
                {
                    oprema oprema = new oprema
                    {
                        model = txtModel.Text,
                        opis = txtOpis.Text,
                        id_tip_oprema = idTipOpreme,
                        id_zemlja = idZemlja
                    };
                    using (var db = new EntitiesSettings())
                    {
                        db.oprema.Add(oprema);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ste dodali opremu.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    using (var db = new EntitiesSettings())
                    {
                        List<oprema> listaOpreme = new List<oprema>(db.oprema.ToList());
                        foreach (var oprema in listaOpreme)
                        {
                            if (oprema.id_oprema == (int)redakZaIzmjenu.Cells[0].Value)
                            {
                                oprema.model = txtModel.Text;
                                oprema.opis = txtOpis.Text;
                                oprema.id_tip_oprema = idTipOpreme;
                                oprema.id_zemlja = idZemlja;

                                db.SaveChanges();
                            }
                        }
                    }
                    MessageBox.Show("Uspješno ste izmijenili opremu.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Takva oprema već postoji u bazi podataka!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
