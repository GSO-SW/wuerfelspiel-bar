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
        int[] wuerfe = new int[5];
        int summe = 0;

        Rectangle rec;
        Rectangle[,] kreise1;
        Rectangle[,] kreise2;
        int width = 950;
        int height = 600;

        public FrmWuerfelspiel()
        {
            InitializeComponent();
        }

        private void FrmWuerfelspiel_Load(object sender, EventArgs e)
        {
            Size dimension = new Size(width, height);
            this.ClientSize = dimension;
        }

        private void tbxSumme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            Refresh();
            summe = 0;
            for (int i = 0; i < 5; i++)
            {
                int wurf = w.Wuerfeln();
                summe += wurf;
                wuerfe[i] = wurf;
            }

            tbxSumme.Text = summe.ToString();

            tbxWuerfelEins.Text = wuerfe[0].ToString();
            tbxWuerfelZwei.Text = wuerfe[1].ToString();
            tbxWuerfelDrei.Text = wuerfe[2].ToString();
            tbxWuerfelVier.Text = wuerfe[3].ToString();
            tbxWuerfelFuenf.Text = wuerfe[4].ToString();

            this.Invalidate();
        }

        private void FrmWuerfelspiel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.Black);

            int anzahlKreiseProReihe = 3;
            kreise1 = new Rectangle[anzahlKreiseProReihe, anzahlKreiseProReihe];
            kreise2 = new Rectangle[anzahlKreiseProReihe, anzahlKreiseProReihe];

            for (int i = 0; i < 5; i++)
            {
                rec.X = i * 200;
                rec.Y = 0;
                rec.Width = 150;
                rec.Height = 150;
                g.DrawRectangle(pen, rec);
            }

            #region Kreise für Würfel 1
            for (int j = 0; j < anzahlKreiseProReihe; j++)
            {
                for (int i = 0; i < anzahlKreiseProReihe; i++)
                {
                    //g.DrawEllipse(pen, i * 50, j * 50, 50, 50);
                    //g.FillEllipse(brush, i * 50, j * 50, 50, 50);
                    kreise1[j, i] = new Rectangle(i * 50, j * 50, 50, 50);
                }
            }
#endregion
            #region Kreise für Würfel 2
            for (int j = 0; j < anzahlKreiseProReihe; j++)
            {
                for (int i = 0; i < anzahlKreiseProReihe; i++)
                {
                    //g.DrawEllipse(pen, 200 + (i * 50), j * 50, 50, 50);
                    //g.FillEllipse(brush, 200 + (i * 50), j * 50, 50, 50);
                    kreise2[j, i] = new Rectangle(200 + (i * 50), j * 50, 50, 50);
                }
            }
            #endregion
            #region Switch Würfe 0
            switch (wuerfe[0])
            {
                case 1:
                    g.DrawEllipse(pen, kreise1[1, 1]);
                    g.FillEllipse(brush, kreise1[1, 1]);
                    break;
                case 2:
                    g.DrawEllipse(pen, kreise1[0, 2]);
                    g.FillEllipse(brush, kreise1[0, 2]);
                    g.DrawEllipse(pen, kreise1[2, 0]);
                    g.FillEllipse(brush, kreise1[2, 0]);
                    break;
                case 3:
                    g.DrawEllipse(pen, kreise1[0, 2]);
                    g.FillEllipse(brush, kreise1[0, 2]);
                    g.DrawEllipse(pen, kreise1[1, 1]);
                    g.FillEllipse(brush, kreise1[1, 1]);
                    g.DrawEllipse(pen, kreise1[2, 0]);
                    g.FillEllipse(brush, kreise1[2, 0]);
                    break;
                case 4:
                    g.DrawEllipse(pen, kreise1[0, 0]);
                    g.FillEllipse(brush, kreise1[0, 0]);
                    g.DrawEllipse(pen, kreise1[0, 2]);
                    g.FillEllipse(brush, kreise1[0, 2]);
                    g.DrawEllipse(pen, kreise1[2, 0]);
                    g.FillEllipse(brush, kreise1[2, 0]);
                    g.DrawEllipse(pen, kreise1[2, 2]);
                    g.FillEllipse(brush, kreise1[2, 2]);
                    break;
                case 5:
                    g.DrawEllipse(pen, kreise1[0, 0]);
                    g.FillEllipse(brush, kreise1[0, 0]);
                    g.DrawEllipse(pen, kreise1[0, 2]);
                    g.FillEllipse(brush, kreise1[0, 2]);
                    g.DrawEllipse(pen, kreise1[2, 0]);
                    g.FillEllipse(brush, kreise1[2, 0]);
                    g.DrawEllipse(pen, kreise1[2, 2]);
                    g.FillEllipse(brush, kreise1[2, 2]);
                    g.DrawEllipse(pen, kreise1[1, 1]);
                    g.FillEllipse(brush, kreise1[1, 1]);
                    break;
                case 6:
                    g.DrawEllipse(pen, kreise1[0, 0]);
                    g.FillEllipse(brush, kreise1[0, 0]);
                    g.DrawEllipse(pen, kreise1[0, 2]);
                    g.FillEllipse(brush, kreise1[0, 2]);
                    g.DrawEllipse(pen, kreise1[1, 0]);
                    g.FillEllipse(brush, kreise1[1, 0]);
                    g.DrawEllipse(pen, kreise1[1, 2]);
                    g.FillEllipse(brush, kreise1[1, 2]);
                    g.DrawEllipse(pen, kreise1[2, 0]);
                    g.FillEllipse(brush, kreise1[2, 0]);
                    g.DrawEllipse(pen, kreise1[2, 2]);
                    g.FillEllipse(brush, kreise1[2, 2]);
                    break;
            }
            #endregion
            #region Switch Würfe 1
            switch (wuerfe[1])
            {
                case 1:
                    g.DrawEllipse(pen, kreise2[1, 1]);
                    g.FillEllipse(brush, kreise2[1, 1]);
                    break;
                case 2:
                    g.DrawEllipse(pen, kreise2[0, 2]);
                    g.FillEllipse(brush, kreise2[0, 2]);
                    g.DrawEllipse(pen, kreise2[2, 0]);
                    g.FillEllipse(brush, kreise2[2, 0]);
                    break;
                case 3:
                    g.DrawEllipse(pen, kreise2[0, 2]);
                    g.FillEllipse(brush, kreise2[0, 2]);
                    g.DrawEllipse(pen, kreise2[1, 1]);
                    g.FillEllipse(brush, kreise2[1, 1]);
                    g.DrawEllipse(pen, kreise2[2, 0]);
                    g.FillEllipse(brush, kreise2[2, 0]);
                    break;
                case 4:
                    g.DrawEllipse(pen, kreise2[0, 0]);
                    g.FillEllipse(brush, kreise2[0, 0]);
                    g.DrawEllipse(pen, kreise2[0, 2]);
                    g.FillEllipse(brush, kreise2[0, 2]);
                    g.DrawEllipse(pen, kreise2[2, 0]);
                    g.FillEllipse(brush, kreise2[2, 0]);
                    g.DrawEllipse(pen, kreise2[2, 2]);
                    g.FillEllipse(brush, kreise2[2, 2]);
                    break;
                case 5:
                    g.DrawEllipse(pen, kreise2[0, 0]);
                    g.FillEllipse(brush, kreise2[0, 0]);
                    g.DrawEllipse(pen, kreise2[0, 2]);
                    g.FillEllipse(brush, kreise2[0, 2]);
                    g.DrawEllipse(pen, kreise2[2, 0]);
                    g.FillEllipse(brush, kreise2[2, 0]);
                    g.DrawEllipse(pen, kreise2[2, 2]);
                    g.FillEllipse(brush, kreise2[2, 2]);
                    g.DrawEllipse(pen, kreise2[1, 1]);
                    g.FillEllipse(brush, kreise2[1, 1]);
                    break;
                case 6:
                    g.DrawEllipse(pen, kreise2[0, 0]);
                    g.FillEllipse(brush, kreise2[0, 0]);
                    g.DrawEllipse(pen, kreise2[0, 2]);
                    g.FillEllipse(brush, kreise2[0, 2]);
                    g.DrawEllipse(pen, kreise2[1, 0]);
                    g.FillEllipse(brush, kreise2[1, 0]);
                    g.DrawEllipse(pen, kreise2[1, 2]);
                    g.FillEllipse(brush, kreise2[1, 2]);
                    g.DrawEllipse(pen, kreise2[2, 0]);
                    g.FillEllipse(brush, kreise2[2, 0]);
                    g.DrawEllipse(pen, kreise2[2, 2]);
                    g.FillEllipse(brush, kreise2[2, 2]);
                    break;
            }
            #endregion
        }
    }
}
