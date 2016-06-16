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

        static public void PrikaziPostrojbe(DataGridView dgvPostrojbe)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = from p in db.postrojba
                           join v in db.vrsta on p.id_vrsta equals v.id_vrsta
                           join t in db.tip on p.id_tip equals t.id_tip
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
                dgvPostrojbe.Columns[2].Width = 130;
                dgvPostrojbe.Columns[3].Width = 80;
                dgvPostrojbe.Columns[4].Width = 80;
            }
        }

        static public void DodajPostrojbu(DataGridView dgvPostrojbe)
        {
            frmPostrojba formaPostrojba = new frmPostrojba();
            formaPostrojba.ShowDialog();
            PrikaziPostrojbe(dgvPostrojbe);
        }

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
                                if (postrojba.ruta.Count == 0)
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

        static public bool ProvjeriPostrojbu(int idVrsta, int idTip)
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
    }
}
