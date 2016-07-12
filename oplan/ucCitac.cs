using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    public partial class ucCitac : UserControl
    {
        private List<string> fontovi = new List<string>();
        private List<int> velicine = new List<int>();
        private int trenutnaVelicina = 12;

        //Property koje sadrži tekst u bogatom uređivaču teksta.
        public string Opis
        {
            set
            {
                rtbOpis.Text = value;
            }
        }

        /// <summary>
        /// Konstruktor u kojem se kontroli u obliku lista dodaju fontovi i veličine.
        /// </summary>
        public ucCitac()
        {
            InitializeComponent();

            fontovi.Add("Arial");
            fontovi.Add("Calibri");
            fontovi.Add("Franklin Gothic Book");
            fontovi.Add("Georgia");
            fontovi.Add("Microsoft Sans Serif");
            fontovi.Add("Times New Roman");
            fontovi.Add("Verdana");

            velicine.Add(8);
            velicine.Add(9);
            velicine.Add(10);
            velicine.Add(11);
            velicine.Add(12);
            velicine.Add(14);
            velicine.Add(16);
        }

        private void ucCitac_Load(object sender, EventArgs e)
        {
            cmbFont.DataSource = fontovi;
            cmbVelicina.DataSource = velicine;

            cmbFont.SelectedItem = "Microsoft Sans Serif" as string;
            cmbVelicina.SelectedItem = 12;

            rtbOpis.Font = new Font(cmbFont.SelectedItem.ToString(), (int)cmbVelicina.SelectedItem, FontStyle.Regular);
        }

        private void cmbFont_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbVelicina.SelectedItem != null && cmbFont.SelectedItem != null)
            {
                try
                {
                    rtbOpis.Font = new Font(cmbFont.SelectedItem.ToString(), (int)cmbVelicina.SelectedItem, FontStyle.Regular);
                    trenutnaVelicina = (int)cmbVelicina.SelectedItem;
                }
                catch(System.ArgumentException)
                {
                    MessageBox.Show("Font ne može biti prikazan.", "Neispravni font", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbFont.SelectedItem = "Times New Roman" as string;
                }
            }   
        }

        private void cmbVelicina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbVelicina.SelectedItem != null && cmbFont.SelectedItem != null)
            {
                rtbOpis.Font = new Font(cmbFont.SelectedItem.ToString(), (int)cmbVelicina.SelectedItem, FontStyle.Regular);
                trenutnaVelicina = (int)cmbVelicina.SelectedItem;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {  
            if (trenutnaVelicina < 16)
            {
                trenutnaVelicina++;
                if (cmbVelicina.SelectedItem != null && cmbFont.SelectedItem != null)
                {
                    rtbOpis.Font = new Font(cmbFont.SelectedItem.ToString(), trenutnaVelicina, FontStyle.Regular);
                } 
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (trenutnaVelicina > 8)
            {
                trenutnaVelicina--;
                if (cmbVelicina.SelectedItem != null && cmbFont.SelectedItem != null)
                {
                    rtbOpis.Font = new Font(cmbFont.SelectedItem.ToString(), trenutnaVelicina, FontStyle.Regular);
                }
            }
        }
    }
}
