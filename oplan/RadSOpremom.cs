using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class RadSOpremom
    {
        static private oprema oprema = null;

        /// <summary>
        /// Preko LINQ upita prikazuje popis opreme u glavnom prozoru.
        /// </summary>
        /// <param name="dgvOprema">Naziv DataGridViewa u kojem se prikazuju podaci</param>
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
        /// <param name="dgvOprema">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        static public void DodajOpremu(DataGridView dgvOprema)
        {
            frmDodajOpremu formaOprema = new frmDodajOpremu();
            formaOprema.ShowDialog();
            PrikaziOpremu(dgvOprema);
        }

        /// <summary>
        /// Briše označenu opremu ako nije dodjeljena ni jednoj postrojbi te prikazuje ažurirani popis opreme.
        /// </summary>
        /// <param name="dgvOprema">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        /// <param name="redak">Redak sa opremom koja se briše</param>
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
                                    //OPCIONALNO: pitati dal se hoće maknuti ta oprema iz svih postrojbi i implementirati
                                    MessageBox.Show("Nije moguće izbrisati opremu koja pripada nekoj od postrojbi!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    PrikaziOpremu(dgvOprema);
                }
            }
        }

        /// <summary>
        /// Provjerava je li oprema bila mijenjana tijekom izmjene te je li istovremeno takva prisutna u bazi.
        /// </summary>
        /// <param name="idTipOpreme">ID tipa opreme koji se provjerava</param>
        /// <param name="idZemlja">ID zemlje porijekla koja se provjerava</param>
        /// <param name="model">Naziv modela opreme u tekstualnom obliku</param>
        /// <param name="redakZaIzmjenu">Redak koji sadrži opremu koja se mijenja</param>
        /// <returns>True ako se oprema može dodati, false ako se ne može.</returns>
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

        /// <summary>
        /// Provjerava postoji li već takav zapis u bazi podataka na temelju naziva, zemlje i tipa opreme.
        /// </summary>
        /// <param name="idTipOpreme">ID tipa opreme koji se provjerava</param>
        /// <param name="idZemlja">ID zemlje porijekla koja se provjerava</param>
        /// <param name="model">Naziv modela opreme u tekstualnom obliku</param>
        /// <returns>True ako ne postoji takva oprema, false ako postoji.</returns>
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

        /// <summary>
        /// Prikazuje formu za izmjenu opreme te prikazuje ažuriranu opremu po završetku.
        /// </summary>
        /// <param name="dgvOprema">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        /// <param name="redak">Redak koji sadrži opremu koja se mijenja</param>
        static public void IzmijeniOpremu(DataGridView dgvOprema, DataGridViewRow redak)
        {
            if (redak != null)
            {
                frmDodajOpremu formaOprema = new frmDodajOpremu(redak);
                formaOprema.ShowDialog();
                PrikaziOpremu(dgvOprema);
            }
        }

        //Funkcija koja briše svu opremu iz arsenala za sve postrojbe koje ju posjeduju i trenutno je neaktivna.
        /*public static void IzbrisiDodjele(int id_opreme)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.postrojba
                            from o in p.oprema
                            join s in db.oprema on o.id_oprema equals s.id_oprema
                            where s.id_oprema == id_opreme
                            select new
                            {
                                IDP = p.id_postrojba,
                                IDO = s.id_oprema,
                            }).ToList();

                foreach (var item in upit)
                {
                    RadSArsenalom.ObrisiArsenal(item.IDP, item.IDO);
                }
            }
        }*/
    }
}
