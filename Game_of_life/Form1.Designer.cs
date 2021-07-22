namespace Game_of_life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.randomize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.width_bar = new System.Windows.Forms.TrackBar();
            this.height_bar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lines_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.width_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_bar)).BeginInit();
            this.Settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.simulation_loop);
            // 
            // randomize
            // 
            this.randomize.Location = new System.Drawing.Point(755, 196);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(89, 29);
            this.randomize.TabIndex = 2;
            this.randomize.Text = "RANDOM";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width:";
            this.label1.Click += new System.EventHandler(this.simulation_loop);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Interval:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            // 
            // width_bar
            // 
            this.width_bar.LargeChange = 4;
            this.width_bar.Location = new System.Drawing.Point(6, 41);
            this.width_bar.Maximum = 60;
            this.width_bar.Minimum = 14;
            this.width_bar.Name = "width_bar";
            this.width_bar.Size = new System.Drawing.Size(176, 45);
            this.width_bar.SmallChange = 4;
            this.width_bar.TabIndex = 14;
            this.width_bar.TickFrequency = 4;
            this.width_bar.Value = 30;
            this.width_bar.Scroll += new System.EventHandler(this.width_bar_Scroll);
            // 
            // height_bar
            // 
            this.height_bar.LargeChange = 4;
            this.height_bar.Location = new System.Drawing.Point(6, 89);
            this.height_bar.Maximum = 43;
            this.height_bar.Minimum = 10;
            this.height_bar.Name = "height_bar";
            this.height_bar.Size = new System.Drawing.Size(176, 45);
            this.height_bar.SmallChange = 4;
            this.height_bar.TabIndex = 4;
            this.height_bar.TickFrequency = 4;
            this.height_bar.Value = 22;
            this.height_bar.Scroll += new System.EventHandler(this.height_bar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(160, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(160, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "22";
            // 
            // lines_button
            // 
            this.lines_button.Location = new System.Drawing.Point(657, 196);
            this.lines_button.Name = "lines_button";
            this.lines_button.Size = new System.Drawing.Size(89, 29);
            this.lines_button.TabIndex = 17;
            this.lines_button.Text = "NEW";
            this.lines_button.UseVisualStyleBackColor = true;
            this.lines_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(95, 15);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(82, 34);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(11, 15);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(78, 34);
            this.open_button.TabIndex = 19;
            this.open_button.Text = "LOAD";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.width_bar);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.textBox3);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.height_bar);
            this.Settings.Location = new System.Drawing.Point(657, 21);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(187, 167);
            this.Settings.TabIndex = 20;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.open_button);
            this.groupBox2.Controls.Add(this.save_button);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(657, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 59);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(668, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 55);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.lines_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Game_of_life";
            ((System.ComponentModel.ISupportInitialize)(this.width_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_bar)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar width_bar;
        private System.Windows.Forms.TrackBar height_bar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button lines_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

