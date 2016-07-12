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
        /// <summary>
        /// Provjerava postoje li zapisi u dnevniku rada za odabranog korisnika.
        /// </summary>
        /// <param name="id_korisnik">ID korisnika koji se provjerava</param>
        /// <returns>False ako ne postoji zapis, true ako postoji barem jedan.</returns>
        static public bool ProvjeriIzvjestaj(int id_korisnik)
        {
            using (var db = new EntitiesSettings())
            {
                var promjena = (from p in db.promjena
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
        /// Na temelju LINQ upita pronalazi i proslijeđuje podatke izvještaju za odabranog korisnika.
        /// </summary>
        /// <param name="odabraniKorisnik">Korisnik odabran za ispis izvješća</param>
        /// <param name="rtvDnevnik">Pregledavač izvještaja na formi</param>
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
        /// Na temelju LINQ upita pronalazi i proslijeđuje podatke izvještaju za odabranu postrojbu.
        /// </summary>
        /// <param name="odabranaPostrojba">Postrojba odabrana za ispis popisa opreme</param>
        /// <param name="rpvNaoruzanje">Pregledavač izvještaja na formi</param>
        static public void PrikaziPopis(int odabranaPostrojba, ReportViewer rpvNaoruzanje)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.postrojba
                            from o in p.oprema
                            join s in db.oprema on o.id_oprema equals s.id_oprema
                            join v in db.vrsta on p.id_vrsta equals v.id_vrsta
                            join t in db.tip_postrojbe on p.id_tip equals t.id_tip
                            join z in db.zemlja on s.id_zemlja equals z.id_zemlja
                            join m in db.tip_opreme on s.id_tip_oprema equals m.id_tip_oprema
                            where p.id_postrojba == odabranaPostrojba
                            select new
                            {
                                Postrojba = v.naziv + " - " + t.naziv,
                                Tip = m.naziv,
                                Model = s.model,
                                Zemlja = z.naziv
                            }).ToList();

                rpvNaoruzanje.LocalReport.DataSources.Clear();
                ReportDataSource izvorPodataka = new ReportDataSource("dsNaoruzanje", upit);
                rpvNaoruzanje.LocalReport.DataSources.Add(izvorPodataka);
                rpvNaoruzanje.LocalReport.ReportEmbeddedResource = "oplan.rptNaoruzanje.rdlc";
                rpvNaoruzanje.RefreshReport();
            }
        }

        /// <summary>
        /// Briše sve zapise u dnevniku rada za odabranog korisnika.
        /// </summary>
        /// <param name="id_korisnik">ID korisnika kojem se briše izvještaj</param>
        static public void IzbrisiIzvjestaj(int id_korisnik)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.promjena
                            where p.id_korisnik == id_korisnik
                            select p).ToList<promjena>();

                foreach (var promjena in upit)
                {
                    db.promjena.Remove(promjena);
                }
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Provjerava ima li postrojba dodjeljenu opremu u arsenalu.
        /// </summary>
        /// <param name="id_postrojba">ID postrojbe kojoj se provjerava arsenal</param>
        /// <returns>True ako postrojba ima dodjeljenu opremu, false ako nema.</returns>
        static public bool ProvjeriOpremu(int id_postrojba)
        {
            using (var db = new EntitiesSettings())
            {
                var upit = (from p in db.postrojba
                            where p.id_postrojba == id_postrojba
                            select p).FirstOrDefault<postrojba>();
                if (upit.oprema.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
