using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZad_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task1 t = new Task1(int.Parse(tbN.Text));
                labArr.Text = $"Числа:\n{t.Show(1)}\n";
                labRes.Text = $"Результат:\n{t.Show(2)}\n";
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
    class Task1
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\task1.bin";
        double[] arr, arr2;
        public Task1(int N)
        {
            Random random = new Random();
            arr = new double[N];
            arr2 = new double[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-5, 5) + random.NextDouble();
            }
            Write();
            Read();
        }
        void Write()
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (double a in arr)
                {
                    binaryWriter.Write(a);
                }
                binaryWriter.Close();
            }
        }
        void Read()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = reader.ReadDouble();
                }
                reader.Close();
            }
        }
        public string Show(int i)
        {
            string str = "";
            switch (i)
            {
                case 1:
                    foreach (double a in arr)
                    {
                        str += $"{a} ";
                    }
                    break;
                case 2:
                    foreach (double a in arr2)
                    {
                        if (a >= 0)
                        {
                            str += $"{a} ";
                        }
                    }
                    break;
            }
            return str != "" ? str : "Нет таких чисел";
        }
    }

}
