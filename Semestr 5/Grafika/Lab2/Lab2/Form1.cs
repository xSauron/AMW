namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "R = " + hScrollBar1.Value;
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "G = " + hScrollBar2.Value;
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = "G = " + hScrollBar3.Value;
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var r = hScrollBar1.Value;
            var g = hScrollBar2.Value;
            var b = hScrollBar3.Value;
            e.Graphics.Clear(Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value));


            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var r = hScrollBar1.Value;
            var g = hScrollBar2.Value;
            var b = hScrollBar3.Value;

            
            var c = 255 - r;
            var m = 255 - g;
            var y = 255 - b;
            e.Graphics.Clear(Color.FromArgb(c, m, y));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            var r = hScrollBar1.Value;
            var g = hScrollBar2.Value;
            var b = hScrollBar3.Value;
            var gray = (r + g + b) / 3;
            e.Graphics.Clear(Color.FromArgb(gray,gray,gray));
        }
    }
}