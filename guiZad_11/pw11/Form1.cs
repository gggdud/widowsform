using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point p;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                richTextBox1.Text = "";
                if(Int32.TryParse(textBox1.Text, out x)&& Int32.TryParse(textBox2.Text, out y))
                {
                    p = new Point(x, y);
                    p.pointShow(richTextBox1);
                    richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
                }
                else
                {
                    MessageBox.Show("Вы ввели что-то не то");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                p = new Point();
                p.pointShow(richTextBox1);
                richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                richTextBox1.Text += "\nНовые координаты\n";
                if (Int32.TryParse(textBox5.Text, out x) && Int32.TryParse(textBox6.Text, out y))
                {
                    p.coordX = x;
                    p.coordY = y;
                    p.pointShow(richTextBox1);
                    richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
                }
                else
                {
                    MessageBox.Show("Вы ввели что-то не то");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                richTextBox1.Text += "\nПеремещение на вектор\n";
                if (Int32.TryParse(textBox3.Text, out a) && Int32.TryParse(textBox4.Text, out b))
                {
                    p.vector(a, b);
                    richTextBox1.Text += $"Координаты: {p.coordX};{p.coordY}";
                    richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
                }
                else
                {
                    MessageBox.Show("Вы ввели что-то не то");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                richTextBox1.Text += "\nУмножение\n";
                if (Int32.TryParse(textBox7.Text, out n))
                {
                    p.multiply = n;
                    p.pointShow(richTextBox1);
                    richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
                }
                else
                {
                    MessageBox.Show("Вы ввели что-то не то");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }

    class Point
    {
        int x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public void pointShow(RichTextBox r)
        {
            r.Text += "Координаты:\n";
            r.Text += $"x = {x}\n";
            r.Text += $"y = {y}\n";
        }

        public double distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }

        public void vector(int a, int b)
        {
            x = x + a;
            y = y + b;
        }

        public int coordX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int coordY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int multiply
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }
    }
}
