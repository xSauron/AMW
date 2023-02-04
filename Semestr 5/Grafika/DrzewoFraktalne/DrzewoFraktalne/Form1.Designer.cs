namespace DrzewoFraktalne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarLeavesB = new System.Windows.Forms.TrackBar();
            this.trackBarLeavesG = new System.Windows.Forms.TrackBar();
            this.trackBarLeavesR = new System.Windows.Forms.TrackBar();
            this.trackBarWoodB = new System.Windows.Forms.TrackBar();
            this.trackBarWoodG = new System.Windows.Forms.TrackBar();
            this.trackBarWoodR = new System.Windows.Forms.TrackBar();
            this.trackBarCrown = new System.Windows.Forms.TrackBar();
            this.trackBarDensity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AccumBits = ((byte)(0));
            this.canvas.AutoCheckErrors = false;
            this.canvas.AutoFinish = false;
            this.canvas.AutoMakeCurrent = true;
            this.canvas.AutoSwapBuffers = true;
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.ColorBits = ((byte)(32));
            this.canvas.DepthBits = ((byte)(16));
            this.canvas.Location = new System.Drawing.Point(16, 15);
            this.canvas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 738);
            this.canvas.StencilBits = ((byte)(0));
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(257, 54);
            this.trackBarSize.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarSize.Maximum = 100;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(138, 56);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.Value = 25;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // trackBarLeavesB
            // 
            this.trackBarLeavesB.LargeChange = 1;
            this.trackBarLeavesB.Location = new System.Drawing.Point(245, 125);
            this.trackBarLeavesB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarLeavesB.Maximum = 100;
            this.trackBarLeavesB.Name = "trackBarLeavesB";
            this.trackBarLeavesB.Size = new System.Drawing.Size(130, 56);
            this.trackBarLeavesB.TabIndex = 16;
            this.trackBarLeavesB.Value = 41;
            this.trackBarLeavesB.Scroll += new System.EventHandler(this.trackBarLeavesB_Scroll);
            // 
            // trackBarLeavesG
            // 
            this.trackBarLeavesG.LargeChange = 1;
            this.trackBarLeavesG.Location = new System.Drawing.Point(245, 81);
            this.trackBarLeavesG.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarLeavesG.Maximum = 100;
            this.trackBarLeavesG.Name = "trackBarLeavesG";
            this.trackBarLeavesG.Size = new System.Drawing.Size(130, 56);
            this.trackBarLeavesG.TabIndex = 14;
            this.trackBarLeavesG.Value = 65;
            this.trackBarLeavesG.Scroll += new System.EventHandler(this.trackBarLeavesG_Scroll);
            // 
            // trackBarLeavesR
            // 
            this.trackBarLeavesR.LargeChange = 1;
            this.trackBarLeavesR.Location = new System.Drawing.Point(245, 38);
            this.trackBarLeavesR.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarLeavesR.Maximum = 100;
            this.trackBarLeavesR.Name = "trackBarLeavesR";
            this.trackBarLeavesR.Size = new System.Drawing.Size(130, 56);
            this.trackBarLeavesR.TabIndex = 12;
            this.trackBarLeavesR.Scroll += new System.EventHandler(this.trackBarLeavesR_Scroll);
            // 
            // trackBarWoodB
            // 
            this.trackBarWoodB.LargeChange = 1;
            this.trackBarWoodB.Location = new System.Drawing.Point(245, 125);
            this.trackBarWoodB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarWoodB.Maximum = 100;
            this.trackBarWoodB.Name = "trackBarWoodB";
            this.trackBarWoodB.Size = new System.Drawing.Size(130, 56);
            this.trackBarWoodB.TabIndex = 16;
            this.trackBarWoodB.Scroll += new System.EventHandler(this.trackBarWoodB_Scroll);
            // 
            // trackBarWoodG
            // 
            this.trackBarWoodG.LargeChange = 1;
            this.trackBarWoodG.Location = new System.Drawing.Point(245, 81);
            this.trackBarWoodG.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarWoodG.Maximum = 100;
            this.trackBarWoodG.Name = "trackBarWoodG";
            this.trackBarWoodG.Size = new System.Drawing.Size(130, 56);
            this.trackBarWoodG.TabIndex = 14;
            this.trackBarWoodG.Value = 29;
            this.trackBarWoodG.Scroll += new System.EventHandler(this.trackBarWoodG_Scroll);
            // 
            // trackBarWoodR
            // 
            this.trackBarWoodR.LargeChange = 1;
            this.trackBarWoodR.Location = new System.Drawing.Point(245, 38);
            this.trackBarWoodR.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarWoodR.Maximum = 100;
            this.trackBarWoodR.Name = "trackBarWoodR";
            this.trackBarWoodR.Size = new System.Drawing.Size(130, 56);
            this.trackBarWoodR.TabIndex = 12;
            this.trackBarWoodR.Value = 58;
            this.trackBarWoodR.Scroll += new System.EventHandler(this.trackBarWoodR_Scroll);
            // 
            // trackBarCrown
            // 
            this.trackBarCrown.Location = new System.Drawing.Point(267, 38);
            this.trackBarCrown.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarCrown.Maximum = 90;
            this.trackBarCrown.Name = "trackBarCrown";
            this.trackBarCrown.Size = new System.Drawing.Size(138, 56);
            this.trackBarCrown.SmallChange = 5;
            this.trackBarCrown.TabIndex = 1;
            this.trackBarCrown.Value = 45;
            this.trackBarCrown.Scroll += new System.EventHandler(this.trackBarCrown_Scroll);
            // 
            // trackBarDensity
            // 
            this.trackBarDensity.LargeChange = 1;
            this.trackBarDensity.Location = new System.Drawing.Point(267, 91);
            this.trackBarDensity.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.trackBarDensity.Maximum = 8;
            this.trackBarDensity.Minimum = 1;
            this.trackBarDensity.Name = "trackBarDensity";
            this.trackBarDensity.Size = new System.Drawing.Size(138, 56);
            this.trackBarDensity.TabIndex = 4;
            this.trackBarDensity.Value = 8;
            this.trackBarDensity.Scroll += new System.EventHandler(this.trackBarDensity_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość gałęzi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gęstość korony";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Niebieski";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Czerwony";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zielony";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(8, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Niebieskie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(8, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zielony";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(8, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Czerwony";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.trackBarSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(838, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(415, 533);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktualne drzewo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.trackBarLeavesB);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.trackBarLeavesG);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.trackBarLeavesR);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(14, 322);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox4.Size = new System.Drawing.Size(383, 183);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kolor liści";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trackBarWoodB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.trackBarWoodG);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.trackBarWoodR);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(14, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Size = new System.Drawing.Size(383, 185);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor gałęzi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRandom);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.trackBarDensity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarCrown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(838, 555);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(415, 197);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nowe drzewo";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRandom.Location = new System.Drawing.Point(231, 149);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(176, 41);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Losowe parametry";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNew.Location = new System.Drawing.Point(8, 149);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(176, 41);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Narysuj drzewo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(853, 804);
            this.Name = "Form1";
            this.Text = "Drzewa Fraktalne";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        private Tao.Platform.Windows.SimpleOpenGlControl canvas;
        private System.Windows.Forms.TrackBar trackBarCrown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarLeavesB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarLeavesG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarLeavesR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarWoodB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarWoodG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarWoodR;
        private System.Windows.Forms.Button buttonRandom;
        #endregion
    }
}