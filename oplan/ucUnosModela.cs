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
    public partial class ucUnosModela : UserControl
    {
        public event EventHandler PromjenaTeksta;

        public override string Text
        {
            get
            {
                return txtModel.Text;
            }
            set
            {
                txtModel.Text = value;
            }
        }

        public ucUnosModela()
        {
            InitializeComponent();
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
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
