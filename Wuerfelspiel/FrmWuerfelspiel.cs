using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class FrmWuerfelspiel : Form
    {
        Wuerfel w = new Wuerfel();
        int summe = 0;
        public FrmWuerfelspiel()
        {
            InitializeComponent();
        }

        private void FrmWuerfelspiel_Load(object sender, EventArgs e)
        {

        }

        private void tbxSumme_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxErneutWuerfeln_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
            summe += w.Wuerfeln();
            }
            btnWuerfeln.Visible = false;
            tbxErneutWuerfeln.Visible = true;
            lblErneutWuerfeln.Visible = true;
        }
    }
}
