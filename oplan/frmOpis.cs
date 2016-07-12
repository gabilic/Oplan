using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    public partial class frmOpis : Form
    {
        private string model;
        private string opis;

        public frmOpis()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor klase kojem se proslijeđuje model i opis opreme koji se prikazuje u čitaču teksta.
        /// </summary>
        /// <param name="proslijedeniModel">Model opreme u tekstualnom obliku</param>
        /// <param name="proslijedeniOpis">Opis opreme u tekstualnom obliku</param>
        public frmOpis(string proslijedeniModel, string proslijedeniOpis)
        {
            InitializeComponent();
            model = proslijedeniModel;
            opis = proslijedeniOpis;
        }

        private void frmOpis_Load(object sender, EventArgs e)
        {
            this.Text = "Detaljniji opis za " + model;
            this.ucCitac.Opis = opis;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
