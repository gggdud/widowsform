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
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task1 t = new Task1(int.Parse(tbN.Text));
                labArr.Text = $"Одномерный массив:\n{t.ShowArr()}";
                labRes.Text = $"Сумма квадратов четных элементов в одномерном массиве: {t.ArrSquareSum}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Task1 t = new Task1(int.Parse(tb2N.Text), int.Parse(tb2M.Text));
                lab2Arr.Text = $"Двумерный массив:\n{t.Show2mArr()}";
                labRes2.Text = $"Сумма квадратов четных элементов в двумерном массиве: {t.Arr2SquareSum}";
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
    class Task1
    {
        int[] arr;
        int[,] arr2;
        long SquareSum1, SquareSum2;
        public Task1(int N, int n, int k)
        {
            Random r = new Random();
            arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = r.Next(-20, 20);
            }
            arr2 = new int[n, k];
            SquareSum1 = ArrF();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    arr2[i, j] = r.Next(-20, 20);
                }
            }
            SquareSum2 = Arr2F();
        }
        public Task1(int N)
        {
            Random r = new Random();
            arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = r.Next(-20, 20);
            }
            SquareSum1 = ArrF();
        }
        public Task1(int n, int m)
        {
            Random r = new Random();
            arr2 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[i, j] = r.Next(-20, 20);
                }
            }
            SquareSum2 = Arr2F();
        }
        public string ShowArr()
        {
            string str = "";
            foreach (int a in arr)
            {
                str += a + " ";
            }
            return str;
        }
        public string Show2mArr()
        {
            string str = "";
            for (int i = 0; i < arr2.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr2.GetUpperBound(1) + 1; j++)
                {
                    str += arr2[i, j] + " ";
                }
                str += '\n';
            }
            return str;
        }
        public long ArrSquareSum
        {
            get
            {
                return SquareSum1;
            }
        }
        public long Arr2SquareSum
        {
            get
            {
                return SquareSum2;
            }
        }
        long ArrF()
        {
            long SquareSum = 0;
            foreach (int a in arr)
            {
                if (a % 2 == 0)
                {
                    SquareSum += a * a;
                }

            }
            return SquareSum;
        }
        long Arr2F()
        {
            long SquareSum = 0;
            foreach (int a in arr2)
            {
                if (a % 2 == 0)
                {
                    SquareSum += a * a;
                }
            }
            return SquareSum;
        }
    }
}
