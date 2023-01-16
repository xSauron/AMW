namespace Lab7
{
    public partial class Form1 : Form
    {
        List<PointF> lista = new List<PointF>();
        float xp, xk, dx, skalax, skalay, min, max, transx, transy;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (lista.Count >= 2)
            {
                e.Graphics.DrawLines(Pens.Red, TabP());
            }
        }

        int il;

        public Form1()
        {
            InitializeComponent();
        }

        float f(float x)
        {
            return x*x + 3*x + 4;
        }

        PointF[] TabP()
        {
            PointF[] pom = new PointF[lista.Count];
            int i = 0;
            foreach (PointF el in lista)
            {
                pom[i++] = new PointF((el.X - xp) * skalax + transx, pictureBox1.Height - el.Y * skalay + transy);
            }
            return pom;
        }

        void UtwListe()
        {
            for (float i = xp; i <= xk; i += dx)
            {
                lista.Add(new PointF(i, f(i)));
            }
        }

        void MinMax()
        {
            max = float.MinValue;
            min = float.MaxValue;

            foreach (PointF el in lista)
            {
                max = el.Y > max ? el.Y : max;
                min = el.Y < min ? el.Y : min;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xp = float.Parse(textBox1.Text);
            xk = float.Parse(textBox2.Text);
            il = (int)numericUpDown1.Value; 
            dx = (xk - xp) / il;
            
            lista.Clear();
            UtwListe();
            MinMax();

            skalax = pictureBox1.Width / (xk - xp);
            skalay = pictureBox1.Height / (max - min);

            transx = (pictureBox1.Width - (xk - xp) * skalax) / 2;
            transy = (pictureBox1.Height - (max - min) * skalay) / 2;

            pictureBox1.Invalidate();
        }

    }
}