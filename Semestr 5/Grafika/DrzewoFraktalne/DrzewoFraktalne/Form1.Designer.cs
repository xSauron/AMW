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
            this.trackBarCrown = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarLeavesB = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarLeavesG = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarLeavesR = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarWoodB = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarWoodG = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarWoodR = new System.Windows.Forms.TrackBar();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.trackBarDensity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).BeginInit();
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
            this.canvas.Location = new System.Drawing.Point(14, 14);
            this.canvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(700, 692);
            this.canvas.StencilBits = ((byte)(0));
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // trackBarCrown
            // 
            this.trackBarCrown.Location = new System.Drawing.Point(234, 36);
            this.trackBarCrown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarCrown.Maximum = 90;
            this.trackBarCrown.Name = "trackBarCrown";
            this.trackBarCrown.Size = new System.Drawing.Size(121, 45);
            this.trackBarCrown.SmallChange = 5;
            this.trackBarCrown.TabIndex = 1;
            this.trackBarCrown.Value = 45;
            this.trackBarCrown.Scroll += new System.EventHandler(this.trackBarCrown_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.trackBarSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(733, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(363, 500);
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
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(335, 172);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kolor liści";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Niebieski";
            // 
            // trackBarLeavesB
            // 
            this.trackBarLeavesB.LargeChange = 1;
            this.trackBarLeavesB.Location = new System.Drawing.Point(214, 117);
            this.trackBarLeavesB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarLeavesB.Maximum = 100;
            this.trackBarLeavesB.Name = "trackBarLeavesB";
            this.trackBarLeavesB.Size = new System.Drawing.Size(114, 45);
            this.trackBarLeavesB.TabIndex = 16;
            this.trackBarLeavesB.Value = 41;
            this.trackBarLeavesB.Scroll += new System.EventHandler(this.trackBarLeavesB_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zielony";
            // 
            // trackBarLeavesG
            // 
            this.trackBarLeavesG.LargeChange = 1;
            this.trackBarLeavesG.Location = new System.Drawing.Point(214, 76);
            this.trackBarLeavesG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarLeavesG.Maximum = 100;
            this.trackBarLeavesG.Name = "trackBarLeavesG";
            this.trackBarLeavesG.Size = new System.Drawing.Size(114, 45);
            this.trackBarLeavesG.TabIndex = 14;
            this.trackBarLeavesG.Value = 65;
            this.trackBarLeavesG.Scroll += new System.EventHandler(this.trackBarLeavesG_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Czerwony";
            // 
            // trackBarLeavesR
            // 
            this.trackBarLeavesR.LargeChange = 1;
            this.trackBarLeavesR.Location = new System.Drawing.Point(214, 36);
            this.trackBarLeavesR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarLeavesR.Maximum = 100;
            this.trackBarLeavesR.Name = "trackBarLeavesR";
            this.trackBarLeavesR.Size = new System.Drawing.Size(114, 45);
            this.trackBarLeavesR.TabIndex = 12;
            this.trackBarLeavesR.Scroll += new System.EventHandler(this.trackBarLeavesR_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trackBarWoodB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.trackBarWoodG);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.trackBarWoodR);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(335, 173);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor gałęzi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Niebieskie";
            // 
            // trackBarWoodB
            // 
            this.trackBarWoodB.LargeChange = 1;
            this.trackBarWoodB.Location = new System.Drawing.Point(214, 117);
            this.trackBarWoodB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarWoodB.Maximum = 100;
            this.trackBarWoodB.Name = "trackBarWoodB";
            this.trackBarWoodB.Size = new System.Drawing.Size(114, 45);
            this.trackBarWoodB.TabIndex = 16;
            this.trackBarWoodB.Scroll += new System.EventHandler(this.trackBarWoodB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zielony";
            // 
            // trackBarWoodG
            // 
            this.trackBarWoodG.LargeChange = 1;
            this.trackBarWoodG.Location = new System.Drawing.Point(214, 76);
            this.trackBarWoodG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarWoodG.Maximum = 100;
            this.trackBarWoodG.Name = "trackBarWoodG";
            this.trackBarWoodG.Size = new System.Drawing.Size(114, 45);
            this.trackBarWoodG.TabIndex = 14;
            this.trackBarWoodG.Value = 29;
            this.trackBarWoodG.Scroll += new System.EventHandler(this.trackBarWoodG_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Czerwony";
            // 
            // trackBarWoodR
            // 
            this.trackBarWoodR.LargeChange = 1;
            this.trackBarWoodR.Location = new System.Drawing.Point(214, 36);
            this.trackBarWoodR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarWoodR.Maximum = 100;
            this.trackBarWoodR.Name = "trackBarWoodR";
            this.trackBarWoodR.Size = new System.Drawing.Size(114, 45);
            this.trackBarWoodR.TabIndex = 12;
            this.trackBarWoodR.Value = 58;
            this.trackBarWoodR.Scroll += new System.EventHandler(this.trackBarWoodR_Scroll);
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(225, 51);
            this.trackBarSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarSize.Maximum = 100;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(121, 45);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.Value = 25;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość gałęzi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRandom);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.trackBarDensity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarCrown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(733, 520);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(363, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nowe drzewo";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRandom.Location = new System.Drawing.Point(202, 140);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(154, 38);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Losowe parametry";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(7, 140);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(154, 38);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Narysuj drzewo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // trackBarDensity
            // 
            this.trackBarDensity.LargeChange = 1;
            this.trackBarDensity.Location = new System.Drawing.Point(234, 85);
            this.trackBarDensity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBarDensity.Maximum = 8;
            this.trackBarDensity.Minimum = 1;
            this.trackBarDensity.Name = "trackBarDensity";
            this.trackBarDensity.Size = new System.Drawing.Size(121, 45);
            this.trackBarDensity.TabIndex = 4;
            this.trackBarDensity.Value = 8;
            this.trackBarDensity.Scroll += new System.EventHandler(this.trackBarDensity_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gęstość korony";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(749, 757);
            this.Name = "Form1";
            this.Text = "Drzewa Fraktalne";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).EndInit();
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