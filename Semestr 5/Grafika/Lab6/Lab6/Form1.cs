using System.Drawing.Drawing2D;

namespace Lab6
{
    public partial class Form1 : Form
    {
        int k = 0;
        PointF p = new PointF(0, 0);
        Matrix matr = new Matrix();

        Point ps = new Point(100, 150);

        public Form1()
        {
            InitializeComponent();
            hScrollBar1.Maximum = pictureBox1.Width;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            k = e.NewValue;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = ps.X + k;
            int y = (int)(Math.Sin((double)x / 50) * pictureBox1.Height / 4 + pictureBox1.Height / 2);

            matr.Reset();
            matr.Translate(x + k, y);
            matr.RotateAt(2 * k, p);

            e.Graphics.Transform = matr;
            e.Graphics.DrawPolygon(Pens.Black, szesc(6));

            matr.Reset();
            matr.Translate(x + k, y);
            matr.RotateAt(2 * k, p);
            matr.Translate(-50, 50);
            matr.RotateAt(-k * 4, p);

            e.Graphics.Transform = matr;
            e.Graphics.DrawPolygon(Pens.Red, szesc(6));

            matr.Reset();
            matr.Translate(x + k, y);
            matr.RotateAt(2 * k, p);
            matr.Translate(50, -50);
            matr.RotateAt(-k * 4, p);

            e.Graphics.Transform = matr;
            e.Graphics.DrawPolygon(Pens.Green, szesc(6));

            matr.Reset();
            matr.Translate(x + k, y);
            matr.RotateAt(2 * k, p);
            matr.Translate(50, 50);
            matr.RotateAt(-k * 4, p);

            e.Graphics.Transform = matr;
            e.Graphics.DrawPolygon(Pens.YellowGreen, szesc(6));

            matr.Reset();
            matr.Translate(x + k, y);
            matr.RotateAt(2 * k, p);
            matr.Translate(-50, -50);
            matr.RotateAt(-k * 4, p);

            e.Graphics.Transform = matr;
            e.Graphics.DrawPolygon(Pens.RosyBrown, szesc(6));
        }

        PointF[] szesc(int il)
        {
            int r = 30;
            PointF[] pkty = new PointF[il];
            for (int i = 0; i < il; i++)
                pkty[i] = new PointF((float)(r * Math.Sin(i * 2 * Math.PI / il)), (float)(r * Math.Cos(i * 2 * Math.PI / il)));
            return pkty;

        }

    }

}