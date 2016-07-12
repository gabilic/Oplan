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
    public partial class frmDodajArsenal : Form
    {
        private int id_postrojba = 0;
        private int id_oprema = 0;

        public frmDodajArsenal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor kojem se proslijeđuje ID postrojbe i ID opreme.
        /// </summary>
        /// <param name="postrojba">ID opreme koja se mijenja</param>
        /// <param name="oprema">ID opreme koja se mijenja</param>
        public frmDodajArsenal(int postrojba, int oprema)
        {
            InitializeComponent();
            id_postrojba = postrojba;
            id_oprema = oprema;
        }

        private void frmDodajArsenal_Load(object sender, EventArgs e)
        {
            RadSArsenalom.PopuniPostrojbama(cmbPostrojba);
            RadSArsenalom.PopuniOpremom(cmbOprema);

            if (id_oprema == 0 && id_oprema == 0)
            {
                this.Text = "Dodjela opreme";
            }
            else
            {
                this.Text = "Izmjena dodjele";

                foreach (var item in cmbPostrojba.Items)
                {
                    if ((item as Stavka).id_postrojbe == id_postrojba)
                    {
                        cmbPostrojba.SelectedItem = item;
                    }
                }

                foreach (var item in cmbOprema.Items)
                {
                    if ((item as oprema).id_oprema == id_oprema)
                    {
                        cmbOprema.SelectedItem = item;
                    }
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var itemPostrojba = cmbPostrojba.SelectedItem as Stavka;
            var itemOprema = cmbOprema.SelectedItem as oprema;

            if (id_oprema == 0 && id_oprema == 0)
            {
                if (RadSArsenalom.DodajArsenal(itemPostrojba.id_postrojbe, itemOprema.id_oprema))
                {
                    MessageBox.Show("Uspješno ste dodali postrojbu.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                RadSArsenalom.IzmjeniArsenal(id_postrojba, id_oprema, itemPostrojba.id_postrojbe, itemOprema.id_oprema);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOprema_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbOprema.SelectedItem != null)
            {
                using (var db = new EntitiesSettings())
                {
                    var item = cmbOprema.SelectedItem as oprema;
                    var upit = (from o in db.oprema
                                join z in db.zemlja on o.id_zemlja equals z.id_zemlja
                                join t in db.tip_opreme on o.id_tip_oprema equals t.id_tip_oprema
                                where o.id_oprema == item.id_oprema
                                select t.naziv + ", " + z.naziv
                                ).FirstOrDefault().ToString();

                    tltOprema.SetToolTip(lblTooltip, upit);
                }
            }
        }
    }
}
