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
    public partial class z4 : Form
    {
        public z4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task4 t = new Task4(int.Parse(tbN.Text));
                labArr.Text = $"Массив:\n{t.Show()}";
                labNew.Text = $"Новый массив с номерами: {t.ShowNewArr()}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
    class Task4
    {
        int[][] arr;
        int[] newArr;
        public Task4(int N)
        {
            Random r = new Random();
            arr = new int[N][];
            newArr = new int[N];
            for (int i = 0; i < N; i++)
            {

                arr[i] = new int[N];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = r.Next(-10, 10);
                    //arr[i][j] = 2;
                }
            }
            NewArr();
        }
        public string Show()
        {
            string str = "";
            foreach (int[] i in arr)
            {
                foreach (int a in i)
                {
                    str += a + " ";
                }
                str += '\n';
            }
            return str;
        }
        void NewArr()
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = -1;
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    if (arr[j][i] % 2 == 0)
                    {
                        newArr[i] = j + 1;
                        break;
                    }
                    if (newArr[i] == -1)
                    {
                        throw new Exception("В одном из столбцов не оказалось четного элемента");
                    }
                }
            }
        }
        public string ShowNewArr()
        {
            string str = "";
            foreach (int a in newArr)
            {
                str += a + " ";
            }
            return str;
        }

    }
}
