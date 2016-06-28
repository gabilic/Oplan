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
    public partial class frmDodajKorisnika : Form
    {
        private korisnik redakZaIzmjenu;

        public frmDodajKorisnika()
        {
            InitializeComponent();
            rdbNe.Checked = true;
        }

        public frmDodajKorisnika(korisnik korisnik)
        {
            InitializeComponent();
            redakZaIzmjenu = korisnik;
            this.Text = "Izmjena korisnika";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string administrator = "";
            if (rdbDa.Checked == true)
            {
                administrator = "Da";
            }
            else
            {
                administrator = "Ne";
            }

            if (string.IsNullOrEmpty(txtKorime.Text) && string.IsNullOrEmpty(txtLozinka.Text))
            {
                MessageBox.Show("Polja su prazna!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string poruka = ProvjeraUnosa.ProvjeriOblik(txtKorime.Text, txtLozinka.Text);
                if (poruka != null)
                {
                    MessageBox.Show(poruka, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (redakZaIzmjenu == null)
                    {
                        if (!ProvjeraKorisnika.ProvjeriKorisnickoIme(txtKorime.Text))
                        {
                            using (var db = new EntitiesSettings())
                            {
                                korisnik korisnik = new korisnik
                                {
                                    korisnicko_ime = txtKorime.Text,
                                    lozinka = txtLozinka.Text,
                                    administrator = administrator
                                };
                                db.korisnik.Add(korisnik);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Uspješno ste dodali korisnika.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Korisničko ime već postoji!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (ProvjeraKorisnika.ProvjeriKorisnickoIme(txtKorime.Text) && redakZaIzmjenu.korisnicko_ime != txtKorime.Text)
                        {
                            MessageBox.Show("Korisničko ime već postoji!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (var db = new EntitiesSettings())
                            {
                                db.korisnik.Attach(redakZaIzmjenu);

                                redakZaIzmjenu.korisnicko_ime = txtKorime.Text;
                                redakZaIzmjenu.lozinka = txtLozinka.Text;
                                redakZaIzmjenu.administrator = administrator;

                                db.SaveChanges();
                            }
                            MessageBox.Show("Uspješno ste izmijenili korisnika.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                    }
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKorisnik_Load(object sender, EventArgs e)
        {
            if(redakZaIzmjenu != null)
            {
                txtID.Text = redakZaIzmjenu.id_korisnik.ToString();
                txtKorime.Text = redakZaIzmjenu.korisnicko_ime;
                txtLozinka.Text = redakZaIzmjenu.lozinka;
                if(redakZaIzmjenu.administrator == "Da")
                {
                    rdbDa.Checked = true;
                }
                else
                {
                    rdbNe.Checked = true;
                }
            }
        }
    }
}
