using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirosKekKorongok
{
    public partial class Form1 : Form
    {
        Graphics g;
        //Pen pen;
        Bitmap bitmap;
        Állapot aktAllapot = new Állapot();

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(501, 501);
            pictureBox1.Image = bitmap;
            //   g = pictureBox1.CreateGraphics();
            g = Graphics.FromImage(bitmap);
            DrawAllapot(aktAllapot);
        }

        private void DrawAllapot(Állapot a)
        {
            g.Clear(pictureBox1.BackColor);
            Pen p = new Pen(Color.Black, 1);
            int meret = Állapot.tablaMeret * 100;
            for (int i = 0; i <= meret; i += 100)
            {
                g.DrawLine(p, 0, i, meret, i);
                g.DrawLine(p, i, 0, i, meret);
            }
            Brush b;
            for (int i = 0; i < Állapot.tablaMeret; i++)
                for (int j = 0; j < Állapot.tablaMeret; j++)
                {
                    if (a.Tabla[i, j] == Cella.Kek) b = new SolidBrush(Color.Blue);
                    else if (a.Tabla[i, j] == Cella.Piros) b = new SolidBrush(Color.Red);
                    else b = new SolidBrush(Color.Transparent);
                    g.FillEllipse(b, j * 100, i * 100, 100, 100);
                }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            byte j = (byte)(e.X / 100);
            byte i = (byte)(e.Y / 100);
            if (aktAllapot.opLep((sbyte)(aktAllapot.UresX - i), (sbyte)(aktAllapot.UresY - j)) ||
                aktAllapot.opUgrik((sbyte)(aktAllapot.UresX - i), (sbyte)(aktAllapot.UresY - j)))
            {
               
                DrawAllapot(aktAllapot);
               
            }
        }

        private void buttonBacktrack_Click(object sender, EventArgs e)
        {
            BacktrackKereso kereso = new BacktrackKereso((int)nudMelysegKorlat.Value);

            if (!kereso.Kereses())
                MessageBox.Show("Nincs megoldás!");
            else
                MessageBox.Show("Van megoldás!");
        }

        private void Keres(GrafKereso kereso)
        {
            index = 0;
            megoldas = kereso.Kereses();

            btn_bal.Enabled = false;

            if (megoldas == null)
            {
                MessageBox.Show("Nincs megoldás!");
                btn_jobb.Enabled = false;
            }
            else
                MessageBox.Show("Van megoldás!");
        }

        private void btnSzelessegi_Click(object sender, EventArgs e)
        {
            Keres(new SzelessegiKereso(cbxKorfigyeles.Checked));
        }

        private void btnMelysegi_Click(object sender, EventArgs e)
        {
            Keres(new MelysegiKereso(cbxKorfigyeles.Checked));
        }

        private void btnAAlg_Click(object sender, EventArgs e)
        {
            Keres(new AAlgoritmus(cbxKorfigyeles.Checked));
        }

        List<Csucs> megoldas = null;
        int index;

        private void btn_bal_Click(object sender, EventArgs e)
        {
            index--;
            DrawAllapot((Állapot)megoldas[index].Allapot);

            if (index == 0)
                btn_bal.Enabled = false;
            btn_jobb.Enabled = true;
        }

        private void btn_jobb_Click(object sender, EventArgs e)
        {
            index++;
            DrawAllapot((Állapot)megoldas[index].Allapot);

            if (index == megoldas.Count - 1)
                btn_jobb.Enabled = false;
            btn_bal.Enabled = true;
        }


    }
}
