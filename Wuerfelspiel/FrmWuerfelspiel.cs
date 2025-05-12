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
        Rectangle[,] kreise;
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
        }

        private void FrmWuerfelspiel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.Black);

            int anzahlKreiseProReihe = 3;
            kreise = new Rectangle[anzahlKreiseProReihe, anzahlKreiseProReihe];

            for (int i = 0; i < 5; i++)
            {
                rec.X = i * 200;
                rec.Y = 0;
                rec.Width = 150;
                rec.Height = 150;
                g.DrawRectangle(pen, rec);
            }

            //g.DrawEllipse(pen, 0, 0, 50, 50);
            //g.FillEllipse(brush, 0, 0, 50, 50);

            //g.DrawEllipse(pen, 50, 0, 50, 50);
            //g.FillEllipse(brush, 50, 0, 50, 50);

            //g.DrawEllipse(pen, 100, 0, 50, 50);
            //g.FillEllipse(brush, 100, 0, 50, 50);

            //g.DrawEllipse(pen, 0, 50, 50, 50);
            //g.FillEllipse(brush, 0, 50, 50, 50);

            //g.DrawEllipse(pen, 0, 100, 50, 50);
            //g.FillEllipse(brush, 0, 100, 50, 50);

            for (int j = 0; j < anzahlKreiseProReihe; j++)
            {
                for (int i = 0; i < anzahlKreiseProReihe; i++)
                {
                    g.DrawEllipse(pen, i * 50, j * 50, 50, 50);
                    g.FillEllipse(brush, i * 50, j * 50, 50, 50);
                    kreise[j, i] = new Rectangle(i * 50, j * 50, 50, 50);
                }
            }
        }
    }
}
