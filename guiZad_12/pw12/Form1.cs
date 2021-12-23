using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw12
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
                if (Int32.TryParse(textBox1.Text, out x) && Int32.TryParse(textBox2.Text, out y))
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                richTextBox1.Text += "\n";
                if (Int32.TryParse(textBox8.Text, out i))
                {
                    richTextBox1.Text += $"Индекс соответствует полю: {p[i]}\n";
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\nТочка++\n";
                p++;
                p.pointShow(richTextBox1);
                richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\nТочка--\n";
                p--;
                p.pointShow(richTextBox1);
                richTextBox1.Text += $"\nДлина от начала координат:\nd = {Math.Round(p.distance(), 2)}\n";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (p)
                {
                    MessageBox.Show("x и y совпадают");
                }
                else
                {
                    MessageBox.Show("x и y не совпадают");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                richTextBox1.Text += "\nПрибавление\n";
                if (Int32.TryParse(textBox9.Text, out n))
                {
                    p = p + n;
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

        string str;
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\nПреобразование в String\n";
                str = (string)p;
                richTextBox1.Text += $"{str}\n";                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "\nПреобразование в Point\n";
                p = (Point)str;
                p.pointShow(richTextBox1);
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

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("Ошибка");
            }
        }

        public static Point operator ++(Point p)
        {
            p.x = p.x + 1;
            p.y = p.y + 1;

            return p;
        }

        public static Point operator --(Point p)
        {
            p.x = p.x - 1;
            p.y = p.y - 1;

            return p;
        }

        public static bool operator true(Point p)
        {
            if (p.x == p.y) return true;
            else return false;
        }

        public static bool operator false(Point p)
        {
            if (p.x != p.y) return false;
            else return true;
        }

        public static Point operator +(Point p, int n)
        {
            p.x = p.x + n;
            p.y = p.y + n;
            return p;
        }

        public static explicit operator Point(string str)
        {
            string[] buf = str.Split(';');
            if (buf.Length == 2)
            {
                int x1 = int.Parse(buf[0]);
                int y1 = int.Parse(buf[1]);
                Point p = new Point(x1, y1);
                return p;
            }
            else throw new Exception("Неверный формат ввода");
        }

        public static explicit operator string(Point p)
        {
            string str = $"{p.x};{p.y}";
            return str;
        }
    }
}
