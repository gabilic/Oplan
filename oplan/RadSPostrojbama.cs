using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class RadSPostrojbama
    {
        static private postrojba postrojba = null;

        /// <summary>
        /// Prikazuje popis postrojbi u glavnom prozoru.
        /// </summary>
        static public void PrikaziPostrojbe(DataGridView dgvPostrojbe)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = from p in db.postrojba
                           join v in db.vrsta on p.id_vrsta equals v.id_vrsta
                           join t in db.tip_postrojbe on p.id_tip equals t.id_tip
                           select new
                           {
                               ID = p.id_postrojba,
                               Vrsta = v.naziv,
                               Tip = t.naziv,
                               Izdrzljivost = p.izdrzljivost,
                               Brzina = p.brzina
                           };
                dgvPostrojbe.DataSource = upit.ToList();
                dgvPostrojbe.Columns[0].HeaderText = "ID postrojbe";
                dgvPostrojbe.Columns[3].HeaderText = "Izdržljivost";

                dgvPostrojbe.Columns[2].Width = 140;
            }
        }

        /// <summary>
        /// Otvara novu formu za dodavanje nove postrojbe te prikazuje ažurirane postrojbe po završetku.
        /// </summary>
        static public void DodajPostrojbu(DataGridView dgvPostrojbe)
        {
            frmDodajPostrojbu formaPostrojba = new frmDodajPostrojbu();
            formaPostrojba.ShowDialog();
            PrikaziPostrojbe(dgvPostrojbe);
        }

        /// <summary>
        /// Briše označenu postrojbu ako se ona ne kreće po niti jednoj ruti te prikazuje ažurirani popis postrojbi.
        /// </summary>
        static public void IzbrisiPostrojbu(DataGridView dgvPostrojbe, DataGridViewRow currentRow)
        {
            if (currentRow != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu postrojbu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EntitiesSettings())
                    {
                        List<postrojba> listaPostrojbi = new List<postrojba>(db.postrojba.ToList());
                        foreach (var postrojba in listaPostrojbi)
                        {
                            if (postrojba.id_postrojba == (int)currentRow.Cells[0].Value)
                            {
                                if (postrojba.tocka.Count == 0)
                                {
                                    db.postrojba.Remove(postrojba);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Nije moguće izbrisati postrojbu koja se kreće po postojećoj ruti!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    PrikaziPostrojbe(dgvPostrojbe);
                }
            }
        }

        /// <summary>
        /// Provjerava je li postrojba bila mijenjana tijekom izmjene te postoji li takva u bazi podataka.
        /// </summary>
        /// <returns>True ako se postrojba može mijenjati, false ako se ne može.</returns>
        static public bool ProvjeriPostrojbu(int idVrsta, int idTip, DataGridViewRow redakZaIzmjenu)
        {
            bool promjena = false;

            if (redakZaIzmjenu == null)
            {
                promjena = ProvjeriPostojanjePostrojbe(idVrsta, idTip);
            }
            else
            {
                using (var db = new EntitiesSettings())
                {
                    var itemVrsta = (from v in db.vrsta
                                     where v.id_vrsta == idVrsta
                                     select v.naziv).FirstOrDefault();
                    var itemTip = (from t in db.tip_postrojbe
                                   where t.id_tip == idTip
                                   select t.naziv).FirstOrDefault();
                    if (itemVrsta == redakZaIzmjenu.Cells[1].Value.ToString() && itemTip == redakZaIzmjenu.Cells[2].Value.ToString())
                    {
                        promjena = true;
                    }
                    else
                    {
                        promjena = ProvjeriPostojanjePostrojbe(idVrsta, idTip);
                    }
                }
            }
            return promjena;
        }

        /// <summary>
        /// Pomoću upita sa ključem vrste i tipa provjerava postoji li takva postrojba u bazi.
        /// </summary>
        /// <returns>True ako postrojba ne postoji, false ako postrojba postoji.</returns>
        static public bool ProvjeriPostojanjePostrojbe(int idVrsta, int idTip)
        {
            using (var db = new EntitiesSettings())
            {
                postrojba = (from p in db.postrojba
                             where p.id_vrsta == idVrsta && p.id_tip == idTip
                             select p).FirstOrDefault<postrojba>();
                if (postrojba == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Prikazuje formu za izmjenu postrojbe te prikazuje ažurirane postrojbe po završetku.
        /// </summary>
        static public void IzmijeniPostrojbu(DataGridView dgvPostrojbe, DataGridViewRow currentRow)
        {
            if (currentRow != null)
            {
                frmDodajPostrojbu formaPostrojba = new frmDodajPostrojbu(currentRow);
                formaPostrojba.ShowDialog();
                PrikaziPostrojbe(dgvPostrojbe);
            }
        }
    }
}
