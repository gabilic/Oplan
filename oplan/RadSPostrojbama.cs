using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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
        /// Pomoću LINQ upita dohvaća i prikazuje popis postrojbi u glavnom prozoru.
        /// </summary>
        /// <param name="dgvPostrojbe">Naziv DataGridViewa u kojem se prikazuju podaci</param>
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
        /// <param name="dgvPostrojbe">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        static public void DodajPostrojbu(DataGridView dgvPostrojbe)
        {
            frmDodajPostrojbu formaPostrojba = new frmDodajPostrojbu();
            formaPostrojba.ShowDialog();
            PrikaziPostrojbe(dgvPostrojbe);
        }

        /// <summary>
        /// Briše označenu postrojbu ako se ona ne nalazi na ni jednom planu i nije joj dodjeljena oprema.
        /// </summary>
        /// <param name="dgvPostrojbe">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        /// <param name="currentRow">Redak u kojem je postrojba koja se želi obrisati</param>
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
                                    if (postrojba.oprema.Count == 0)
                                    {
                                        db.postrojba.Remove(postrojba);
                                        db.SaveChanges();
                                        MessageBox.Show("Uspješno ste obrisali postrojbu.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        //OPCIONALNO: pitati dal se hoće obrisati i sve dodjele opreme u arsenalu i implementirati
                                        MessageBox.Show("Nije moguće izbrisati postrojbu kojoj je dodjeljena oprema!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nije moguće izbrisati postrojbu koja je na postojećem planu!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// <param name="idVrsta">ID vrste postrojbe koja se provjerava</param>
        /// <param name="idTip">ID tipa postrojbe koja se provjerava</param>
        /// <param name="redakZaIzmjenu">Redak u kojem je postrojba koja se želi provjeriti</param>
        /// <returns>True ako se postrojba može unjeti, false ako se ne može.</returns>
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
        /// <param name="idVrsta">ID vrste kojeg postrojba ima</param>
        /// <param name="idTip">ID tipa kojeg je postrojba</param>
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
        /// <param name="dgvPostrojbe">Naziv DataGridViewa u kojem se prikazuju podaci</param>
        /// <param name="currentRow">Redak postrojbe koja se želi izmjeniti</param>
        static public void IzmijeniPostrojbu(DataGridView dgvPostrojbe, DataGridViewRow currentRow)
        {
            if (currentRow != null)
            {
                frmDodajPostrojbu formaPostrojba = new frmDodajPostrojbu(currentRow);
                formaPostrojba.ShowDialog();
                PrikaziPostrojbe(dgvPostrojbe);
            }
        }

        /// <summary>
        /// Prikazuje formu sa izvještajem ako za tu postrojbu postoji dodjeljena oprema.
        /// </summary>
        /// <param name="id_postrojbe">ID postrojbe kojoj se želi vidjeti oprema</param>
        /// <param name="naziv">Naziv postrojbe u tekstualnom obliku</param>
        static public void PrikaziOpremu(int id_postrojbe, string naziv)
        {
            if (Izvjestaji.ProvjeriOpremu(id_postrojbe))
            {
                frmNaoruzanje popisOpreme = new frmNaoruzanje(id_postrojbe, naziv);
                popisOpreme.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ovoj postrojbi nije dodjeljena niti jedna oprema.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Funkcija koja briše sve dodjele opreme određenoj postrojbi i trenutno nije aktivna.
        /*public static void IzbrisiDodjele(int id_postrojba)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.postrojba
                            from o in p.oprema
                            join s in db.oprema on o.id_oprema equals s.id_oprema
                            where p.id_postrojba == id_postrojba
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
