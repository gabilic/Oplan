using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oplan
{
    class RadSPlanovima
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

        static public void PromjeniNaziv(string stariNaziv, string NoviNaziv)
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
    }
}
