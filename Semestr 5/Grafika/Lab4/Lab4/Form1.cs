namespace Lab4
{
    public partial class Form1 : Form
    {
        Bitmap pom;
        int xp, yp, xk, yk, r;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(14, 377);
            panel1.Visible = true;
            panel2.Location = new Point(14, 318);
            panel2.Visible = false;
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(14, 318);
            panel1.Visible = false;
            panel2.Location = new Point(14, 377);
            panel2.Visible = true;

        }

        public Form1()
        {
            InitializeComponent();
            pom = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = pom;

            //Set max to avoid reaching points outside pickturbox
            numericUpDown1.Maximum = pictureBox1.Width - 1;
            numericUpDown2.Maximum = pictureBox1.Height - 1;
            numericUpDown3.Maximum = pictureBox1.Width - 1;
            numericUpDown4.Maximum = pictureBox1.Height - 1;
            numericUpDown5.Maximum = pictureBox1.Width - 1;
            numericUpDown6.Maximum = pictureBox1.Height - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                xp = (int)numericUpDown1.Value;
                yp = (int)numericUpDown2.Value;
                xk = (int)numericUpDown3.Value;
                yk = (int)numericUpDown4.Value;

                int x;
                float dx, dy, y, m;
                dx = xk - xp;
                dy = yk - yp;
                m = dy / dx;
                y = yp;
                for (x = xp; x <= xk; x++)
                {
                    pom.SetPixel(x, (int)Math.Floor(y + 0.5), Color.Red);
                    y += m;
                }
                
            }
            else
            {
                //Rysowanie ko³a bez wykorzystania sym8
                r = (int)numericUpDown8.Value;
                xp = (int)numericUpDown5.Value;
                yp = (int)numericUpDown6.Value;

                //Ustaw œrodek ko³a
                pom.SetPixel(xp, yp, Color.Black);
                int x, y, t, x2, y2;
                

                x = xp - r;
                y = yp;

                if (x > 0) {
                    pom.SetPixel(x, y, Color.Green);
                }
                if (xp + r < pom.Width)
                {
                    pom.SetPixel(xp + r, y, Color.Green);
                }
                while(x < xp + r)
                {
                    t = (int)Math.Floor(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - xp, 2)));

                    y = yp + t;

                    if(y > 0 && x > 0 && y < pom.Height && x < pom.Width)
                    pom.SetPixel(x, y, Color.Green);
                    
                    y = yp - t;
                    if (y > 0 && x > 0 && y < pom.Height && x < pom.Width)
                    pom.SetPixel(x, y, Color.Green);

                    x++;
                }
            }
            pictureBox1.Invalidate();

        }        
        
        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                xp = (int)numericUpDown1.Value;
                yp = (int)numericUpDown2.Value;
                xk = (int)numericUpDown3.Value;
                yk = (int)numericUpDown4.Value;

                int dx, dy, incrE, incrNE, d, x, y;
                dx = xk - xp;
                dy = yk - yp;
                d = 2 * (dy - dx);
                incrE = dy * 2;
                incrNE = (dy - dx) * 2;
                x = xp;
                y = yp;
                pom.SetPixel(x, y, Color.Blue);
                while (x < xk)
                {
                    if (d <= 0)
                    {
                        d += incrE;
                        x++;
                    }
                    else
                    {
                        d += incrNE;
                        x++;
                        y++;
                    }
                    pom.SetPixel(x, y, Color.Blue);
                }
            }
            else
            {
                r = (int)numericUpDown8.Value;
                xp = (int)numericUpDown5.Value;
                yp = (int)numericUpDown6.Value;

                int x = 0;
                int y = r;
                int d = 3 - 2 * r;
                sym8(xp, yp, x, y, Color.Yellow);
                while (y >= x)
                {
                    x++;
                    if (d > 0)
                    {
                        y--;
                        d = d + 4 * (x - y) + 10;
                    }
                    else
                    {
                        d = d + 4 * x + 6;
                    }
                    sym8(xp, yp, x, y, Color.Yellow);
                }
            }



            pictureBox1.Invalidate();
        }
        private void sym8(int xc, int yc, int x, int y, Color kolor)
        {
            pom.SetPixel(xc + x, yc + y, kolor);
            pom.SetPixel(xc - x, yc + y, kolor);
            pom.SetPixel(xc + x, yc - y, kolor);
            pom.SetPixel(xc - x, yc - y, kolor);
            pom.SetPixel(xc + y, yc + x, kolor);
            pom.SetPixel(xc - y, yc + x, kolor);
            pom.SetPixel(xc + y, yc - x, kolor);
            pom.SetPixel(xc - y, yc - x, kolor);
        }
    }
}