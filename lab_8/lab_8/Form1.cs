using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCurrentTime();
        }

        private async void GetCurrentTime()
        {
            while (true)
            {
                DateTime date = DateTime.Now;
                textBoxTime.Text = date.ToString("HH:mm:ss");
                await Task.Delay(1000 - date.Millisecond);
            }
        }

        async private void ButtonSearchMin_Click(object sender, EventArgs e)
        {
            int size = (int)numericSearchMin.Value;
            textBoxMin.Clear();
            int result = await SearchMin(size);
            textBoxMin.Text = result.ToString();
        }

        static async Task<int> SearchMin(int size)
        {
            var list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(0,size));
            }
            int min = await FindMinAsync(list);
            return min;
        }

        static async Task<int> FindMinAsync(List<int> list)
        {
            int min = list[0];

            await Task.Run(() =>
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < min)
                    {
                        min = list[i];
                    }
                }
            });

            return min;
        }

        async private void ButtonBubleSort_Click(object sender, EventArgs e)
        {
            textBoxTimeBuble.Clear();
            int result = await BubbleSortAsync((int)numericSizeBubleSort.Value);
            textBoxTimeBuble.Text = result.ToString();
        }

        private int BubbleSort(int size)
        {
            long[] array = new long[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size);
            }

            int startTime = Environment.TickCount;
            long temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            return Environment.TickCount - startTime;
        }

        private async Task<int> BubbleSortAsync(int size)
        {
            return await Task.Run(() => BubbleSort(size));
        }
    }
}
