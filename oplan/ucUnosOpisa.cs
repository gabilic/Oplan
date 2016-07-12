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
    public partial class ucUnosOpisa : UserControl
    {
        public event EventHandler PromjenaTeksta;

        public override string Text
        {
            get
            {
                return txtOpis.Text;
            }
            set
            {
                txtOpis.Text = value;
            }
        }

        public ucUnosOpisa()
        {
            InitializeComponent();
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
            if (txtOpis.Text == "")
            {
                lblPogreska.Visible = true;
            }
            else
            {
                lblPogreska.Visible = false;
            }

            if (PromjenaTeksta != null)
            {
                PromjenaTeksta(this, e);
            }
        }
    }
}
