namespace Lab8
{
    public partial class Form1 : Form
    {
        int k, v;
        List<PointF> points = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            k = e.NewValue;

            label1.Text = "k = " + k.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            v = e.NewValue;

            label2.Text = "v = " + v.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(k > 0 && v > 0)
            {
                DrawBall(k, v, checkBox1.Checked);
            }

        }

        void DrawBall(double angle, double velocity, bool showTrajectory)
        {
            pictureBox1.Refresh();
            points.Clear();

            // Okre�l grawitacj�
            double gravity = 9.81;

            // Oblicz sk�adowe pr�dko�ci pi�ki
            double vx = velocity * Math.Cos(Math.PI * angle / 180.0);
            double vy = velocity * Math.Sin(Math.PI * angle / 180.0);

            // Ustaw po�o�enie pocz�tkowe pi�ki
            double x = 0;
            double y = pictureBox1.Height;

            points.Add(new PointF((float)x, (float)y));

            // P�tla animacji
            while (true)
            {
                // Oblicz nowe po�o�enie pi�ki
                x += vx;
                y -= vy;
                vy -= gravity;


                points.Add(new PointF((float)x, (float)y));

                // Wyczy�� obszar rysowania
                pictureBox1.Refresh();

                // Narysuj pi�k� w nowym po�o�eniu
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    if (showTrajectory)
                    {
                        // Narysuj trajektori� pi�ki
                        if(points.Count > 2)
                        {
                            g.DrawLines(Pens.Red, points.ToArray());
                        }
                    }
                    g.FillEllipse(Brushes.Blue, (float)x, (float)y, 10, 10);
                }

                // Sprawd�, czy pi�ka wylecia�a poza obszar rysowania
                if (x < 0 || x > pictureBox1.Width || y > pictureBox1.Height)
                {
                    break;
                }

                // Zatrzymaj p�tl� na chwil�, aby animacja by�a widoczna
                System.Threading.Thread.Sleep(50);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}