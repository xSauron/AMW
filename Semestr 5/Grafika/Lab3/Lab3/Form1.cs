namespace Lab3
{
    public partial class Form1 : Form
    {

        Bitmap obraz, kopia;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            obraz = new Bitmap(openFileDialog1.FileName);
            kopia = new Bitmap(obraz.Width, obraz.Height);
            pictureBox1.Image = obraz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color pkt;
            for (int i = 0; i < obraz.Width; i++) { 
                for (int j = 0; j < obraz.Height; j++)
                {
                    pkt = obraz.GetPixel(i, j);

                    int r = pkt.R;
                    int g = pkt.G;
                    int b = pkt.B;

                    if (!checkBox1.Checked)
                    {
                        r = 255 - pkt.R;
                    }
                    if (!checkBox2.Checked)
                    {
                        g = 255 - pkt.G;
                    }
                    if (!checkBox3.Checked)
                    {
                        b = 255 - pkt.B;
                    }
                    kopia.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = kopia;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color pkt;
            for (int i = 0; i < obraz.Width; i++) { 
                for (int j = 0; j < obraz.Height; j++)
                {
                    pkt = obraz.GetPixel(i, j);
                    int szary = (int)(pkt.R * 0.3) + (int)(pkt.G * 0.59) + (int)(pkt.B * 0.11);
                    kopia.SetPixel(i, j, Color.FromArgb(szary, szary, szary));

                }
            }
            pictureBox2.Image = kopia;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color pkt;
            for (int i = 0; i < obraz.Width; i++)
            {
                for (int j = 0; j < obraz.Height; j++)
                {
                    pkt = obraz.GetPixel(i, j);
                    int szary = (pkt.R + pkt.G + pkt.B) / 3;
                    kopia.SetPixel(i, j, Color.FromArgb(szary, szary, szary));
                }
            }    
            pictureBox2.Image = kopia;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}