using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZad_6
{
    public partial class z3 : Form
    {
        public z3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task3 t = new Task3(int.Parse(textBox1.Text));
                labArr.Text = $"Матрица:\n{t.Show()}";
                labRes.Text = $"Норма: {t.Norm}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
    class Task3
    {
        int[,] arr;
        int norm = 0;
        public Task3(int n)
        {
            Random r = new Random();
            arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(-20, 20);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //Console.WriteLine(Max(i));
                norm += Max(i);
            }
        }
        public int Norm
        {
            get
            {
                return norm;
            }
        }
        public string Show()
        {
            string str = "";
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    str += arr[i, j] + " ";
                }
                str += '\n';
            }
            return str;
        }
        int Max(int n)
        {
            int max = arr[n, 0];
            for (int i = 1; i < arr.GetLength(1); i++)
            {
                if (arr[n, i] > max)
                {
                    max = arr[n, i];
                }
            }
            return max;
        }
    }
}
