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
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            Statistika.PrikaziStatistiku(chStatistika);
        }

        private void frmStatistika_Resize(object sender, EventArgs e)
        {
            chStatistika.Width = this.Width - 40;
            chStatistika.Height = this.Height - 63;
        }
    }
}
