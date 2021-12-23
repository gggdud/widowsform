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
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task2 t = new Task2(textBox1.Text);
                labRes.Text = $"Сумма элементов между максимумом и минимумом: {t.Sum}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
    class Task2
    {
        double[] arr;
        double Max, Min, Amount;
        int MaxIndex, MinIndex;
        public Task2(string str)
        {
            string[] str2 = str.Split(' ');
            arr = new double[str2.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                arr[i] = Double.Parse(str2[i]);
            }
            Maximum();
            Minimum();
            Amount = Summ();
        }
        public double Sum
        {
            get
            {
                return Amount;
            }
        }
        void Maximum()
        {
            Max = arr[0];
            MaxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                    MaxIndex = i;
                }
            }
        }
        void Minimum()
        {
            Min = arr[0];
            MinIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                    MinIndex = i;
                }
            }
        }
        double Summ()
        {
            if (MaxIndex > MinIndex)
            {
                throw new Exception("Максимальный элемент встречается позже минимального");
            }
            double sum = 0;
            for (int i = MaxIndex + 1; i < MinIndex; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
