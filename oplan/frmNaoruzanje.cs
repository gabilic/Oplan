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
