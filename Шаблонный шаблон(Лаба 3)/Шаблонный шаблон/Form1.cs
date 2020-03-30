using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шаблонный_шаблон
{
    public partial class Form1 : Form
    {
        ProgressBar progress = new ProgressBar();
        Label label = new Label();
        List<int> order = new List<int>();
        List<Button> Arr = new List<Button>();
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            
            int startX = 200;
            int startY = 20;

            int nextX = startX;
            int nextY = startY;

            for (int i = 0; i < 16; i++)
            {
                Arr.Add(new Button()); 
                Arr[i].Visible = true;
                order.Add(i + 1);
                Arr[i].Size = new Size(40, 25);
                tabControl1.TabPages[1].Controls.Add(Arr[i]);
                Arr[i].Click += Button_Click;   
            }
            Randomise(order);
            for (int i = 0; i < 16; i ++)
            {
                Arr[i].Location = new Point(nextX, nextY);
                Arr[i].Text = order[i].ToString();
                nextX = nextX + Arr[i].Size.Width + 17;
                if (i % 4 == 3)
                {
                    nextY = nextY + Arr[i].Size.Height + 10;
                    nextX = startX;
                }
            }
            progress.Visible = true;
            progress.Size = new Size(211, 30);
            progress.Location = new Point(nextX, nextY);
            progress.Minimum = 1;
            progress.Maximum = 17;
            progress.Value = 1;
            progress.Step = 1;
            tabControl1.TabPages[1].Controls.Add(progress);
            label.Visible = true;
            label.Size = new Size(211, 30);
            label.Location = new Point(nextX, nextY + 40);
            label.Text ="";
            label.TextAlign = ContentAlignment.MiddleCenter;
            tabControl1.TabPages[1].Controls.Add(label);
        }

        private void Randomise(List<int> order)
        {
            Random random = new Random();
            for (int a = order.Count - 1; a >= 0; a--)
            {
                int b = random.Next(a);
                int c = order[a];
                order[a] = order[b];
                order[b] = c;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == i.ToString())
            {
                ((Button)sender).Visible = false;
                progress.PerformStep();
                order.Remove(int.Parse(((Button)sender).Text));
                Randomise(order);
                for (int j = 0, k = 0; j < Arr.Count; j++)
                {
                    if (Arr[j].Visible == true)
                    {
                        Arr[j].Text = order[k].ToString();
                        k++;
                    }
                }
                i++;
            } else
            {
                order = new List<int>();
                for (int j = 1; j <= 16; j++)
                {
                    order.Add(j);
                }
                Randomise(order);
                for (int j = 0, k = 0; j < Arr.Count; j++)
                {
                    Arr[j].Visible = true;
                    Arr[j].Text = order[k].ToString();
                    k++;
                }
                progress.Value = 1;
                i = 1;
            }
            if (progress.Value == 17)
            {
                label.Text = label.Text + "CONGRATULATIONS, COMRAD!";
            }
        }

    }


}
