using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oplan
{
    class Stavka
    {
        //Svojstvo ID postrojbe
        public int id_postrojbe { get; set; }

        //Svojstvo tekstualnog naziva vrste i tipa postrojbe
        public string tekst { get; set; }

        /// <summary>
        /// Konstruktor u kojem se stvara novi objekt klase Stavka.
        /// </summary>
        /// <param name="id">ID postrojbe</param>
        /// <param name="naziv">Naziv u tekstualnom obliku</param>
        public Stavka(int id, string naziv)
        {
            this.id_postrojbe = id;
            this.tekst = naziv;
        }
    }
}
