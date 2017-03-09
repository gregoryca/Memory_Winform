using System;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApplication1.Properties;
using System.ComponentModel;

namespace WindowsFormApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox16 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();

            Restart = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            spelbordenToolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem1 = new ToolStripMenuItem();
            veldX2ToolStripMenuItem = new ToolStripMenuItem();
            veldX4ToolStripMenuItem = new ToolStripMenuItem();
            veldX6ToolStripMenuItem = new ToolStripMenuItem();
            veldX8ToolStripMenuItem = new ToolStripMenuItem();
            veldX12ToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)(pictureBox16)).BeginInit();
            ((ISupportInitialize)(pictureBox15)).BeginInit();
            ((ISupportInitialize)(pictureBox14)).BeginInit();
            ((ISupportInitialize)(pictureBox13)).BeginInit();
            ((ISupportInitialize)(pictureBox12)).BeginInit();
            ((ISupportInitialize)(pictureBox11)).BeginInit();
            ((ISupportInitialize)(pictureBox10)).BeginInit();
            ((ISupportInitialize)(pictureBox9)).BeginInit();
            ((ISupportInitialize)(pictureBox8)).BeginInit();
            ((ISupportInitialize)(pictureBox7)).BeginInit();
            ((ISupportInitialize)(pictureBox6)).BeginInit();
            ((ISupportInitialize)(pictureBox1)).BeginInit();
            ((ISupportInitialize)(pictureBox2)).BeginInit();
            ((ISupportInitialize)(pictureBox3)).BeginInit();
            ((ISupportInitialize)(pictureBox4)).BeginInit();
            ((ISupportInitialize)(pictureBox5)).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Controls.Add(pictureBox16, 4, 4);
            tableLayoutPanel1.Controls.Add(pictureBox15, 3, 4);
            tableLayoutPanel1.Controls.Add(pictureBox14, 2, 4);
            tableLayoutPanel1.Controls.Add(pictureBox13, 1, 4);
            tableLayoutPanel1.Controls.Add(pictureBox12, 4, 3);
            tableLayoutPanel1.Controls.Add(pictureBox11, 3, 3);
            tableLayoutPanel1.Controls.Add(pictureBox10, 2, 3);
            tableLayoutPanel1.Controls.Add(pictureBox9, 1, 3);
            tableLayoutPanel1.Controls.Add(pictureBox8, 4, 2);
            tableLayoutPanel1.Controls.Add(pictureBox7, 3, 2);
            tableLayoutPanel1.Controls.Add(pictureBox6, 2, 2);
            tableLayoutPanel1.Controls.Add(Restart, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 4, 1);
            tableLayoutPanel1.Controls.Add(pictureBox5, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new Size(1032, 574);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += new PaintEventHandler(tableLayoutPanel1_Paint);
            // 
            // pictureBox16
            // 
            pictureBox16.Dock = DockStyle.Fill;
            pictureBox16.Image = Resources.pic0;
            pictureBox16.Location = new Point(687, 384);
            pictureBox16.Margin = new Padding(3, 4, 3, 4);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(165, 87);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 28;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "15";
            pictureBox16.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox15
            // 
            pictureBox15.Dock = DockStyle.Fill;
            pictureBox15.Image = Resources.pic0;
            pictureBox15.Location = new Point(516, 384);
            pictureBox15.Margin = new Padding(3, 4, 3, 4);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(165, 87);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 27;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "14";
            pictureBox15.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox14
            // 
            pictureBox14.Dock = DockStyle.Fill;
            pictureBox14.Image = Resources.pic0;
            pictureBox14.Location = new Point(345, 384);
            pictureBox14.Margin = new Padding(3, 4, 3, 4);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(165, 87);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 26;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "13";
            pictureBox14.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox13
            // 
            pictureBox13.Dock = DockStyle.Fill;
            pictureBox13.Image = Resources.pic0;
            pictureBox13.Location = new Point(174, 384);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(165, 87);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 25;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "12";
            pictureBox13.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox12
            // 
            pictureBox12.Dock = DockStyle.Fill;
            pictureBox12.Image = Resources.pic0;
            pictureBox12.Location = new Point(687, 289);
            pictureBox12.Margin = new Padding(3, 4, 3, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(165, 87);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "11";
            pictureBox12.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox11
            // 
            pictureBox11.Dock = DockStyle.Fill;
            pictureBox11.Image = Resources.pic0;
            pictureBox11.Location = new Point(516, 289);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(165, 87);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 21;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "10";
            pictureBox11.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox10
            // 
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Image = Resources.pic0;
            pictureBox10.Location = new Point(345, 289);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(165, 87);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "9";
            pictureBox10.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.Image = Resources.pic0;
            pictureBox9.Location = new Point(174, 289);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(165, 87);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 19;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "8";
            pictureBox9.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Image = Resources.pic0;
            pictureBox8.Location = new Point(687, 194);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(165, 87);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "7";
            pictureBox8.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Image = Resources.pic0;
            pictureBox7.Location = new Point(516, 194);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(165, 87);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "6";
            pictureBox7.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Resources.pic0;
            pictureBox6.Location = new Point(345, 194);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(165, 87);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "5";
            pictureBox6.Click += new EventHandler(Figuur_Click);
            // 
            // Restart
            // 
            Restart.Dock = DockStyle.Fill;
            Restart.Location = new Point(3, 4);
            Restart.Margin = new Padding(3, 4, 3, 4);
            Restart.Name = "Restart";
            Restart.Size = new Size(165, 87);
            Restart.TabIndex = 0;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += new EventHandler(Herstart_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.pic0;
            pictureBox1.Location = new Point(174, 99);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "0";
            pictureBox1.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Resources.pic0;
            pictureBox2.Location = new Point(345, 99);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "1";
            pictureBox2.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Resources.pic0;
            pictureBox3.Location = new Point(516, 99);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "2";
            pictureBox3.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Resources.pic0;
            pictureBox4.Location = new Point(687, 99);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(165, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "3";
            pictureBox4.Click += new EventHandler(Figuur_Click);
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Resources.pic0;
            pictureBox5.Location = new Point(174, 194);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(165, 87);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "4";
            pictureBox5.Click += new EventHandler(Figuur_Click);
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Location = new Point(345, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 26);
            textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            spelbordenToolStripMenuItem,
            bestandenToolStripMenuItem,
            bestandenToolStripMenuItem1});
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1032, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(menuStrip1_ItemClicked);
            // 
            // spelbordenToolStripMenuItem
            // 
            spelbordenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            veldX2ToolStripMenuItem,
            veldX4ToolStripMenuItem,
            veldX6ToolStripMenuItem,
            veldX8ToolStripMenuItem,
            veldX12ToolStripMenuItem});
            spelbordenToolStripMenuItem.Name = "spelbordenToolStripMenuItem";
            spelbordenToolStripMenuItem.Size = new Size(90, 28);
            spelbordenToolStripMenuItem.Text = "Spelborden";
            spelbordenToolStripMenuItem.Click += new EventHandler(spelbordenToolStripMenuItem_Click);
            // 
            // bestandenToolStripMenuItem
            // 
            bestandenToolStripMenuItem.Name = "bestandenToolStripMenuItem";
            bestandenToolStripMenuItem.Size = new Size(12, 23);
            // 
            // bestandenToolStripMenuItem1
            // 
            bestandenToolStripMenuItem1.BackColor = SystemColors.ControlDarkDark;
            bestandenToolStripMenuItem1.Name = "bestandenToolStripMenuItem1";
            bestandenToolStripMenuItem1.Size = new Size(85, 23);
            bestandenToolStripMenuItem1.Text = "Bestanden";
            bestandenToolStripMenuItem1.Click += new EventHandler(bestandenToolStripMenuItem1_Click);
            // 
            // veldX2ToolStripMenuItem
            // 
            veldX2ToolStripMenuItem.Name = "veldX2ToolStripMenuItem";
            veldX2ToolStripMenuItem.Size = new Size(211, 30);
            veldX2ToolStripMenuItem.Text = "Veld x 2";
            veldX2ToolStripMenuItem.Click += new EventHandler(veldX2ToolStripMenuItem_Click);
            // 
            // veldX4ToolStripMenuItem
            // 
            veldX4ToolStripMenuItem.Name = "veldX4ToolStripMenuItem";
            veldX4ToolStripMenuItem.Size = new Size(211, 30);
            veldX4ToolStripMenuItem.Text = "Veld x 4";
            // 
            // veldX6ToolStripMenuItem
            // 
            veldX6ToolStripMenuItem.Name = "veldX6ToolStripMenuItem";
            veldX6ToolStripMenuItem.Size = new Size(211, 30);
            veldX6ToolStripMenuItem.Text = "veld x 6";
            // 
            // veldX8ToolStripMenuItem
            // 
            veldX8ToolStripMenuItem.Name = "veldX8ToolStripMenuItem";
            veldX8ToolStripMenuItem.Size = new Size(211, 30);
            veldX8ToolStripMenuItem.Text = "veld x 8";
            // 
            // veldX12ToolStripMenuItem
            // 
            veldX12ToolStripMenuItem.Name = "veldX12ToolStripMenuItem";
            veldX12ToolStripMenuItem.Size = new Size(211, 30);
            veldX12ToolStripMenuItem.Text = "veld x 12";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 606);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Memory_V1";
            Load += new EventHandler(Form1_Load);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)(pictureBox16)).EndInit();
            ((ISupportInitialize)(pictureBox15)).EndInit();
            ((ISupportInitialize)(pictureBox14)).EndInit();
            ((ISupportInitialize)(pictureBox13)).EndInit();
            ((ISupportInitialize)(pictureBox12)).EndInit();
            ((ISupportInitialize)(pictureBox11)).EndInit();
            ((ISupportInitialize)(pictureBox10)).EndInit();
            ((ISupportInitialize)(pictureBox9)).EndInit();
            ((ISupportInitialize)(pictureBox8)).EndInit();
            ((ISupportInitialize)(pictureBox7)).EndInit();
            ((ISupportInitialize)(pictureBox6)).EndInit();
            ((ISupportInitialize)(pictureBox1)).EndInit();
            ((ISupportInitialize)(pictureBox2)).EndInit();
            ((ISupportInitialize)(pictureBox3)).EndInit();
            ((ISupportInitialize)(pictureBox4)).EndInit();
            ((ISupportInitialize)(pictureBox5)).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void veldX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void spelbordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bestandenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Restart;
        private PictureBox pictureBox1;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem spelbordenToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem1;
        private TextBox textBox1;
        private ToolStripMenuItem veldX2ToolStripMenuItem;
        private ToolStripMenuItem veldX4ToolStripMenuItem;
        private ToolStripMenuItem veldX6ToolStripMenuItem;
        private ToolStripMenuItem veldX8ToolStripMenuItem;
        private ToolStripMenuItem veldX12ToolStripMenuItem;
    }
}