using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.button1.Location.X < e.X && this.button1.Location.Y - 25 < e.Y && this.button1.Location.Y > e.Y && this.button1.Location.X + button1.Width > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X, this.button1.Location.Y + 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.X + button1.Width < e.X && this.button1.Location.X + button1.Width + 25 > e.X && this.button1.Location.Y - 25 < e.Y && this.button1.Location.Y > e.Y)
            {
                this.button1.Location = new Point(this.button1.Location.X - 10, this.button1.Location.Y + 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.Y < e.Y && this.button1.Location.X + button1.Width < e.X && this.button1.Location.X + button1.Width + 25 > e.X && this.button1.Location.Y + button1.Height > e.Y)
            {
                this.button1.Location = new Point(this.button1.Location.X - 10, this.button1.Location.Y);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.Y + button1.Height < e.Y && this.button1.Location.Y + button1.Height + 25 > e.Y && this.button1.Location.X + button1.Width < e.X && this.button1.Location.X + button1.Width + 25 > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X - 10, this.button1.Location.Y - 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.X < e.X && this.button1.Location.Y + button1.Height + 25 > e.Y && this.button1.Location.Y + button1.Height < e.Y && this.button1.Location.X + button1.Width > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X, this.button1.Location.Y - 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.X - 25 < e.X && this.button1.Location.Y + button1.Height + 25 > e.Y && this.button1.Location.Y + button1.Height < e.Y && this.button1.Location.X > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X + 10, this.button1.Location.Y - 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.X - 25 < e.X && this.button1.Location.Y + button1.Height > e.Y && this.button1.Location.Y < e.Y && this.button1.Location.X > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X + 10, this.button1.Location.Y);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.X - 25 < e.X && this.button1.Location.Y - 25 < e.Y && this.button1.Location.Y > e.Y && this.button1.Location.X > e.X)
            {
                this.button1.Location = new Point(this.button1.Location.X + 10, this.button1.Location.Y + 10);
                this.button1.Size = new Size(this.button1.Size.Width, this.button1.Size.Height - 1);
            }
            if (this.button1.Location.Y < 0)
            {
                this.button1.Location = new Point(this.button1.Location.X, e.Y + 15);
            }
            if (this.button1.Location.X < 0)
            {
                this.button1.Location = new Point(e.X + 15, this.button1.Location.Y);
            }
            if (this.button1.Location.X + button1.Width > this.ClientRectangle.Width)
            {
                this.button1.Location = new Point(e.X - button1.Width - 15, this.button1.Location.Y);
            }
            if (this.button1.Location.Y + button1.Height > this.ClientRectangle.Height)
            {
                this.button1.Location = new Point(this.button1.Location.X, e.Y - button1.Height - 15);
            }
            if (this.button1.Size.Height == 0)
            {
                this.button1.Dispose();
                this.Text = "Ты действительно думал, что все так просто?)))";
                this.timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Location = new Point(this.button1.Location.X + 100, this.button1.Location.Y + 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Text == "Ты действительно думал, что все так просто?)))")
            {
                this.Text = "Чеши домой уроки учить, школьничек)))";
            } else
            {
                this.Text = "Ты действительно думал, что все так просто?)))";
            }
        }
    }
}
