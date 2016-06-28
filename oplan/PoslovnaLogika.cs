using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class PoslovnaLogika
    {
        static private oprema oprema = null;

        /// <summary>
        /// Prikazuje popis opreme u glavnom prozoru.
        /// </summary>
        /// <param name="dgvOprema"></param>
        static public void PrikaziOpremu(DataGridView dgvOprema)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = from o in db.oprema
                           join t in db.tip_opreme on o.id_tip_oprema equals t.id_tip_oprema
                           join z in db.zemlja on o.id_zemlja equals z.id_zemlja
                           select new
                           {
                               ID = o.id_oprema,
                               Tip = t.naziv,
                               Model = o.model,
                               Zemlja = z.naziv,
                               Opis = o.opis
                           };
                dgvOprema.DataSource = upit.ToList();
                dgvOprema.Columns[0].HeaderText = "ID opreme";
                dgvOprema.Columns[1].HeaderText = "Tip opreme";
                dgvOprema.Columns[3].HeaderText = "Zemlja porijekla";
                dgvOprema.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOprema.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvOprema.Columns[3].Width = 120;
                dgvOprema.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        /// <summary>
        /// Otvara novu formu za dodavanje nove opreme te na kraju osvježava prikaz opreme.
        /// </summary>
        /// <param name="dgvOprema"></param>
        static public void DodajOpremu(DataGridView dgvOprema)
        {
            frmDodajOpremu formaOprema = new frmDodajOpremu();
            formaOprema.ShowDialog();
            PrikaziOpremu(dgvOprema);
        }

        /// <summary>
        /// Briše označenu opremu ako ona ne pripada nijednoj postrojbi te prikazuje ažurirani popis opreme.
        /// </summary>
        /// <param name="dgvOprema"></param>
        /// <param name="redak"></param>
        static public void IzbrisiOpremu(DataGridView dgvOprema, DataGridViewRow redak)
        {
            if (redak != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu opremu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new EntitiesSettings())
                    {
                        List<oprema> listaOpreme = new List<oprema>(db.oprema.ToList());
                        foreach (var oprema in listaOpreme)
                        {
                            if (oprema.id_oprema == (int)redak.Cells[0].Value)
                            {
                                if (oprema.postrojba.Count == 0)
                                {
                                    db.oprema.Remove(oprema);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Nije moguće izbrisati opremu koja pripada nekoj od postrojbi!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    PrikaziOpremu(dgvOprema);
                }
            }
        }

        static public bool ProvjeriOpremu(int idTipOpreme, int idZemlja, string model, DataGridViewRow redakZaIzmjenu)
        {
            bool promjena = false;

            if (redakZaIzmjenu == null)
            {
                promjena = ProvjeriPostojanjeOpreme(idTipOpreme, idZemlja, model);
            }
            else
            {
                using (var db = new EntitiesSettings())
                {
                    var itemTipOpreme = (from t in db.tip_opreme
                                         where t.id_tip_oprema == idTipOpreme
                                         select t.naziv).FirstOrDefault();
                    var itemZemlja = (from z in db.zemlja
                                      where z.id_zemlja == idZemlja
                                      select z.naziv).FirstOrDefault();
                    if (itemTipOpreme == redakZaIzmjenu.Cells[1].Value.ToString() && model == redakZaIzmjenu.Cells[2].Value.ToString() && itemZemlja == redakZaIzmjenu.Cells[3].Value.ToString())
                    {
                        promjena = true;
                    }
                    else
                    {
                        promjena = ProvjeriPostojanjeOpreme(idTipOpreme, idZemlja, model);
                    }
                }
            }
            return promjena;
        }

        static public bool ProvjeriPostojanjeOpreme(int idTipOpreme, int idZemlja, string model)
        {
            using (var db = new EntitiesSettings())
            {
                oprema = (from o in db.oprema
                          where o.id_tip_oprema == idTipOpreme && o.model == model && o.id_zemlja == idZemlja
                          select o).FirstOrDefault<oprema>();
                if (oprema == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static public void IzmijeniOpremu(DataGridView dgvOprema, DataGridViewRow redak)
        {
            if (redak != null)
            {
                frmDodajOpremu formaOprema = new frmDodajOpremu(redak);
                formaOprema.ShowDialog();
                PrikaziOpremu(dgvOprema);
            }
        }
    }
}
