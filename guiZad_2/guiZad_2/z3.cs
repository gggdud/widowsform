using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZad_2
{
    public partial class z3 : Form
    {
        public z3()
        {
            InitializeComponent();
        }
        string f(int a, int b)
        {
            string str = "";
            int count = 0;
            for (int i = 1; i <= b; i++)
            {
                if (count == 5)
                {
                    count = 0;
                    str += '\n';
                }
                if ((i % 10) % 2 == 0)
                {
                    str += $"{i} ";
                    count++;
                }
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Введите а: ");
                int a = int.Parse(tbA.Text);
                Console.WriteLine("Введите b: ");
                int b = int.Parse(tbB.Text);
                if (a > b)
                {
                    throw new Exception("A должно быть меньше либо равно B");
                }
                labRes.Text = $"Результат:\n{f(a, b)}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
