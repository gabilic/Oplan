using Microsoft.Reporting.WinForms;
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
    public partial class frmNaoruzanje : Form
    {
        private int odabranaPostrojba;

        /// <summary>
        /// Konstruktor klase kojem se proslijeđuje ID postrojbe za odabrani popis opreme.
        /// </summary>
        /// <param name="id_postrojbe">ID postrojbe za koju se želi vidjeti oprema</param>
        /// <param name="naziv">Naziv postrojbe u tekstualnom obliku</param>
        public frmNaoruzanje(int id_postrojbe, string naziv)
        {
            InitializeComponent();
            odabranaPostrojba = id_postrojbe;
            this.Text = naziv;
        }

        private void frmNaoruzanje_Load(object sender, EventArgs e)
        {
            Izvjestaji.PrikaziPopis(odabranaPostrojba, rpvNaoruzanje);
            this.rpvNaoruzanje.SetDisplayMode(DisplayMode.PrintLayout);
            this.rpvNaoruzanje.ZoomMode = ZoomMode.Percent;
            this.rpvNaoruzanje.ZoomPercent = 100;
            this.rpvNaoruzanje.RefreshReport();
        }
    }
}
