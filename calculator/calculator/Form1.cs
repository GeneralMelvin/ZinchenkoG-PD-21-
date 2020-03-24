using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        float a = 0, b = 0;
        int act = 1;
        public Form1()
        {
            InitializeComponent();
            int startX = this.textBox1.Location.X;
            int startY = this.textBox1.Location.Y + this.textBox1.Size.Height + 10;

            int nextX = startX;
            int nextY = startY;

            for (int i = 0; i < 18; i++)
            {
                Button button = new Button();
                button.Visible = true;
                switch (i)
                {
                    case 0:
                        button.Text = ("CE").ToString();
                        button.Size = new Size(70, 30);
                        break;
                    case 1:
                        button.Text = ("C").ToString();
                        button.Size = new Size(70, 30);
                        break;
                    case 5:
                        button.Text = ("+").ToString();
                        button.Size = new Size(30, 30);
                        break;
                    case 9:
                        button.Text = ("-").ToString();
                        button.Size = new Size(30, 30);
                        break;
                    case 13:              
                        button.Text = ("*").ToString();
                        button.Size = new Size(30, 30);
                        break;
                    case 14:

                        button.Text = ("0").ToString();
                        button.Size = new Size(70, 30);
                        break;
                    case 15:
                        button.Text = (".").ToString();
                        button.Size = new Size(30, 30);
                        break;
                    case 16:
                        button.Text = ("/").ToString();
                        button.Size = new Size(30, 30);
                        break;
                    case 17:
                        button.Text = ("=").ToString();
                        button.Size = new Size(150, 30);
                        break;
                }
                if (i >= 2 && i <= 4)
                {
                    button.Text = (i - 1).ToString();
                    button.Size = new Size(30, 30);
                } else if (i >= 6 && i <= 8)
                {
                    button.Text = (i - 2).ToString();
                    button.Size = new Size(30, 30);
                }
                else if (i >= 10 && i <= 12)
                {
                    button.Text = (i - 3).ToString();
                    button.Size = new Size(30, 30);
                }
                button.Location = new Point(nextX, nextY);
                this.Controls.Add(button);
                button.Click += Button_Click;
                nextX = nextX + button.Size.Width + 10;
                if (nextX > this.textBox1.Location.X + this.textBox1.Size.Width)
                {
                    nextY = nextY + button.Size.Height + 10;
                    nextX = startX;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text) {
                case ("CE"):
                    textBox1.Clear();
                    a = 0;
                    b = 0;
                    textBox1.Text = textBox1.Text + 0;
                    label1.Text = "";
                    break;

                case ("C"):
                    int lenght = textBox1.Text.Length - 1;
                    string text = textBox1.Text;
                    textBox1.Clear();
                    for (int i = 0; i < lenght; i++)
                    {
                        textBox1.Text = textBox1.Text + text[i];
                    }
                    break;

                case ("+"):
                    if (a == 0)
                    {
                        a = float.Parse(textBox1.Text);
                        act = 1;
                        label1.Text = label1.Text + a + ((Button)sender).Text;
                        textBox1.Clear();
                    } else
                    {
                        b = float.Parse(textBox1.Text);
                        label1.Text = label1.Text + b + ((Button)sender).Text;
                        Calculate();
                        act = 1;
                        textBox1.Clear();
                    }
                    break;

                case ("-"):
                    if (a == 0)
                    {
                        a = float.Parse(textBox1.Text);
                        act = 2;
                        label1.Text = label1.Text + a + ((Button)sender).Text;
                        textBox1.Clear();
                    }
                    else
                    {
                        b = float.Parse(textBox1.Text);
                        label1.Text = label1.Text + b + ((Button)sender).Text;
                        Calculate();
                        act = 2;
                        textBox1.Clear();
                    }
                    break;

                case ("*"):
                    if (a == 0)
                    {
                        a = float.Parse(textBox1.Text);
                        act = 3;
                        label1.Text = label1.Text + a + ((Button)sender).Text;
                        textBox1.Clear();
                    }
                    else
                    {
                        b = float.Parse(textBox1.Text);
                        label1.Text = label1.Text + b + ((Button)sender).Text;
                        Calculate();
                        act = 3;
                        textBox1.Clear();
                    }
                    break;

                case ("/"):
                    if (a == 0)
                    {
                        a = float.Parse(textBox1.Text);
                        act = 4;
                        label1.Text = label1.Text + a + ((Button)sender).Text;
                        textBox1.Clear();
                    }
                    else
                    {
                        b = float.Parse(textBox1.Text);
                        label1.Text = label1.Text + b + ((Button)sender).Text;
                        Calculate();
                        act = 4;
                        textBox1.Clear();
                    }
                    break; 

                case ("="):
                    b = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = label1.Text + b + "=";
                    Calculate();
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + a;
                    break;

                case ("."):
                    textBox1.Text = textBox1.Text + ((Button)sender).Text;
                    break;

                default:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + ((Button)sender).Text;
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + ((Button)sender).Text;
                    }
                    break;
            }
        }

        private void Calculate()
        {
            switch (act)
            {
                case 1:
                    a = a + b;
                    b = 0;
                    break;
                case 2:
                    a = a - b;
                    b = 0;
                    break;
                case 3:
                    a = a * b;
                    b = 0;
                    break;
                case 4:
                    a = a / b;
                    b = 0;
                    break;
            }

        }
    }
}
