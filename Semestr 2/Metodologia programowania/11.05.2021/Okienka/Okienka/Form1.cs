using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okienka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string lista = "";

            /*foreach (Control item in this.Controls)
            {
                if ((item is CheckBox) && ((CheckBox)item).Checked)
                    lista += item.Text + ", ";
            }*/

            if (checkBox1.Checked) lista += checkBox1.Text + " ";
            if (checkBox2.Checked) lista += checkBox2.Text + " ";
            if (checkBox3.Checked) lista += checkBox3.Text + " ";
            if (checkBox4.Checked) lista += checkBox4.Text + " ";

            MessageBox.Show(lista, "Zakupy");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) groupBox1.Visible = true;
            else groupBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) groupBox2.Visible = true;
            else groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text, "Wybrano");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        bool desc = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;



            if (progressBar2.Value < progressBar2.Maximum && desc == false)
            {
                progressBar2.Value++;

            }
            else if (desc)
            {
                progressBar2.Value--;
            }

            label2.Text = progressBar2.Value.ToString();


            if (progressBar2.Value == progressBar2.Maximum && desc == false)
            {
                desc = true;
            }
            else if(progressBar2.Value == progressBar2.Minimum && desc == true)
            {
                desc = false;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled; 

        }
    }
}
