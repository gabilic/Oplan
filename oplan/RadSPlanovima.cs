using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oplan
{
    public class RadSPlanovima
    {
        ///<summary>
        ///Provjerava postoji li takav naziv plana u bazi podataka.
        ///</summary>
        ///<returns>True ako naziv postoji, false ako ne postoji.</returns>
        static public bool ProvjeriPlan(string naziv)
        {
            using (var db = new EntitiesSettings())
            {
                var plan = (from p in db.plan
                            where p.naziv == naziv
                            select p).FirstOrDefault<plan>();
                if (plan == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        static public void PromijeniNaziv(string stariNaziv, string NoviNaziv)
        {
            using (var db = new EntitiesSettings())
            {
                var plan = (from p in db.plan
                            where p.naziv == stariNaziv
                            select p).FirstOrDefault<plan>();

                plan.naziv = NoviNaziv;
                db.SaveChanges();
            }
        }

        static public void SpremiPlan(int prijavljeniKorisnik, string nazivPlana)
        {
            using(var db = new EntitiesSettings())
            {
                plan noviPlan = new plan();
                noviPlan.naziv = nazivPlana;
                noviPlan.datum = DateTime.Now;
               
                db.plan.Add(noviPlan);
                db.SaveChanges();

                int id = (from p in db.plan
                            orderby p.id_plan descending
                            select p.id_plan).FirstOrDefault();

                promjena novaPromjena = new promjena();
                novaPromjena.id_korisnik = prijavljeniKorisnik;
                novaPromjena.id_plan = id;
                novaPromjena.datum = DateTime.Now;
                novaPromjena.radnja = Promjene.spremioPlan;
               
                db.promjena.Add(novaPromjena);
                db.SaveChanges();


            }
        }

       static public int najdiZadnjiId()
        {
   
            using (var db = new EntitiesSettings())
            {

                int ZadnjiIdTocke = (from t in db.tocka
                               orderby t.id_tocka descending
                               select t.id_tocka).FirstOrDefault();

                return ZadnjiIdTocke;
            }
            

        }

        /*static public void SpremListuTocke(List<Tocka> tocke)
        {


            using (var db = new EntitiesSettings())
            {

                int idPlan = (from p in db.plan
                              orderby p.id_plan descending
                              select p.id_plan).FirstOrDefault();
                
                for (int i=0;i<tocke.Count;i++)
                {
                    tocka t = new tocka();
                    t.id_plan = idPlan;
                    t.koord_x = (decimal)tocke[i].koord_x;
                    t.koord_y = (decimal)tocke[i].koord_y;
                    if (tocke[i].marker == "yes") {
                    t.marker = "Da";
                    }
                    else
                    {
                        t.marker = "Ne";
                    }
                    t.id_postrojba = int.Parse(tocke[i].postrojba);
                    if(tocke[i].pripadnost== "enemy")
                    {
                        t.id_pripadnost = 2;

                    }
                    else
                    {
                        t.id_pripadnost = 1;
                    }
                    if (tocke[i].zavrsna != 0) {
                        t.zavrsna = 2;
                    }

                    else
                    {
                        t.zavrsna = null;
                    }


                    db.tocka.Add(t);
                    db.SaveChanges();

                }
                





            }

        }*/


        public static void PopuniPostrojbama(System.Windows.Forms.ComboBox nazivKontrole)
        {
            using (var db = new EntitiesSettings())
            {
                List<Stavka> listaStavki = new List<Stavka>();
                var prikazaniTekst = (from p in db.postrojba
                                      join v in db.vrsta on p.id_vrsta equals v.id_vrsta
                                      join t in db.tip_postrojbe on p.id_tip equals t.id_tip
                                      select new
                                      {
                                          id_postrojbe = p.id_postrojba,
                                          tekst = v.naziv + " - " + t.naziv
                                      }).ToList();


                foreach (var item in prikazaniTekst)
                {
                    listaStavki.Add(new Stavka(item.id_postrojbe, item.tekst));
                }

                nazivKontrole.DataSource = listaStavki;
                nazivKontrole.ValueMember = "id_postrojbe";
                nazivKontrole.DisplayMember = "tekst";
            }
        }


        public static postrojba NadjiPostrojbu(int idPostrojbe)
        {
            using (var db = new EntitiesSettings())
            {
                postrojba OdabranaPostrojba = new postrojba();
               var OdPostrojba = (from p in db.postrojba
                                      where p.id_postrojba == idPostrojbe
                                      select p).FirstOrDefault<postrojba>();

                OdabranaPostrojba = OdPostrojba;
                return OdabranaPostrojba;
            }

        }
    }
}
