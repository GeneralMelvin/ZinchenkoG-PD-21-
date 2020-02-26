using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Щютка
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
