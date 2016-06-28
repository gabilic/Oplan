using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class Izvjestaji
    {
        static private promjena promjena = null;

        /// <summary>
        /// Provjerava postoje li zapisi u dnevniku rada za određenog korisnika.
        /// </summary>
        /// <returns>False ako ne postoji zapis, true ako postoji barem jedan.</returns>
        static public bool ProvjeriIzvjestaj(int id_korisnik)
        {
            using (var db = new EntitiesSettings())
            {
                promjena = (from p in db.promjena
                            where p.id_korisnik == id_korisnik
                            select p).FirstOrDefault<promjena>();
                if (promjena == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Pronalazi i proslijeđuje podatke izvještaju za odabranog korisnika.
        /// </summary>
        static public void PrikaziIzvjestaj(korisnik odabraniKorisnik, ReportViewer rtvDnevnik)
        {
            korisnik korisnik = odabraniKorisnik;
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.promjena
                            join k in db.korisnik on p.id_korisnik equals k.id_korisnik
                            join l in db.plan on p.id_plan equals l.id_plan
                            where p.id_korisnik == korisnik.id_korisnik
                            select new
                            {
                                Korisnik = k.korisnicko_ime,
                                Plan = l.naziv,
                                Datum = p.datum,
                                Radnja = p.radnja,
                                Administrator = k.administrator
                            }).ToList();

                rtvDnevnik.LocalReport.DataSources.Clear();
                ReportDataSource izvorPodataka = new ReportDataSource("dsIzvjestaj", upit);
                rtvDnevnik.LocalReport.DataSources.Add(izvorPodataka);
                rtvDnevnik.LocalReport.ReportEmbeddedResource = "oplan.rptDnevnik.rdlc";
                rtvDnevnik.RefreshReport();
            }
        }

        /// <summary>
        /// Briše sve zapise u dnevniku rada za određenog korisnika.
        /// </summary>
        static public void IzbrisiIzvjestaj(int id_korisnik)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = from p in db.promjena
                           where p.id_korisnik == id_korisnik
                           select p;

                foreach (var promjena in upit)
                {
                    db.promjena.Remove(promjena);
                }
                db.SaveChanges();
            }
        }
    }
}
