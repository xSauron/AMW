namespace Lab5
{
    public partial class Form1 : Form
    {
        List<Point> lista = new List<Point>();
        Bitmap pom;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            pom = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = pom;
            g = Graphics.FromImage(pom);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            g.Clear(Color.White);
            lista.Add(new Point(e.X, e.Y));

            if (lista.Count > 2)
            {
                g.DrawPolygon(Pens.Red, lista.ToArray());
            }

            pictureBox1.Invalidate();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int licznik = 0;
            Color pkt;
            Color ppkt;
            Color npkt;

            bool brzeg = false;

            for (int i = 0; i < pom.Height; i++)
            {
                licznik = 0;
                for(int j = 0; j < pom.Width-1; j++)
                {
                    pkt = pom.GetPixel(j, i);
                    npkt = pom.GetPixel(j + 1, i);

                    if (npkt.ToArgb().Equals(Color.Red.ToArgb()))
                    {
                        brzeg = true;
                    }
                    else
                    {
                        brzeg = false;
                    }

                    if (pkt.ToArgb().Equals(Color.Red.ToArgb()))
                    {
                        if(brzeg == false) licznik++;
                    }
                    else
                    {
                        brzeg = false;
                    }

                    if(licznik % 2 != 0 && !brzeg)
                    {
                        pom.SetPixel(j, i, Color.Yellow);
                        pictureBox1.Refresh();
                    }
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RysujZnak();
            Point p = SzukajZiarna();
            do
            {
                p = SzukajZiarna();
                Wypelnij(p.X, p.Y);

            } while (p.X != 0 && p.Y != 0);
        }

        void RysujZnak()
        {
            Font font = new Font("Times New Roman", 100);
            g.DrawString("AMW", font, Brushes.Black, new Point(0, 0));
            pictureBox1.Invalidate();
        }

        Point SzukajZiarna()
        {
            Color pkt;
            for(int i = 0; i < pom.Height; i++)
            {
                for(int j = 0; j < pom.Width; j++)
                {
                    pkt = pom.GetPixel(j, i);
                    if (pkt.ToArgb().Equals(Color.Black.ToArgb()))
                    {
                        return new Point(j, i);
                    }
                }
            }
            return new Point(0, 0);
        }

        void Wypelnij(int x, int y)
        {
            if ((x < 0) || (y < 0) || (x >= pom.Width) || (y >= pom.Height)) return;

            Color pkt = pom.GetPixel(x, y);

            if (!pkt.ToArgb().Equals(Color.Black.ToArgb())) return;

            pom.SetPixel(x, y, Color.Orange);
            pictureBox1.Refresh();
            Wypelnij(x - 1, y);
            Wypelnij(x + 1, y);
            Wypelnij(x, y - 1);
            Wypelnij(x, y + 1);
        }


    }
}