using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace oplan
{
    class Statistika
    {
        /// <summary>
        /// Prikazuje statistiku opreme po zemljama u obliku grafa.
        /// </summary>
        /// <param name="chStatistika">Graf na kojem će se prikazati statistika.</param>
        static public void PrikaziStatistiku(Chart chStatistika)
        {
            string stupac = "Količina opreme";
            Title naslov = chStatistika.Titles.Add("Statistika po zemljama");
            naslov.Font = new Font("Arial", 16, FontStyle.Bold);
            naslov.ForeColor = Color.Blue;
            chStatistika.Series.Add(stupac);
            chStatistika.Series[stupac].Color = Color.Blue;

            using (var db = new EntitiesSettings())
            {
                List<string> listaZemalja = (from z in db.zemlja
                                             select z.naziv).ToList();
                for (int i = 0; i < listaZemalja.Count; i++)
                {
                    int brojacOpreme = 0;
                    List<zemlja> zemlje = (from o in db.oprema
                                           join z in db.zemlja
                                           on o.id_zemlja equals z.id_zemlja
                                           select z).ToList();
                    for (int j = 0; j < zemlje.Count; j++)
                    {
                        if (zemlje[j].naziv == listaZemalja[i])
                        {
                            brojacOpreme++;
                        }
                    }
                    chStatistika.Series[stupac].Points.AddXY(listaZemalja[i], brojacOpreme);
                }
            }
        }
    }
}
