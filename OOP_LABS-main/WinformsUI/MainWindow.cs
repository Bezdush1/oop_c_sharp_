using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinformsUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getClassInfoButton_Click(object sender, EventArgs e)
        {
            Utils.FillOutputLog(Library.GetClassInfo(), outputLog);
        }

        private void getInheritedExceptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetStackOverflowException();
            }
            catch(StackOverflowException ex)
            {
                Utils.MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }
        
        private void GetStackOverflowException()
        {
            throw new StackOverflowException("Ты вызвал бесконечную рекурсию, пользователь");
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            outputLog.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openObjsWindow_Click(object sender, EventArgs e)
        {
            ObjectsManipulatorWindow objsWindow = new ObjectsManipulatorWindow();
            objsWindow.Show();
        }

        private void makeCollectionsTestButton_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();

            PerformanceTests performanceTests = new PerformanceTests();
            var timer = new Stopwatch();

            timer.Start();
            performanceTests.CreateDictionary();
            timer.Stop();
            ListViewItem item1 = new ListViewItem($"Создание и заполнение: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            timer.Start();
            performanceTests.CreateArray();
            timer.Stop();
            item1.SubItems.Add($"Создание и заполнение: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            listView.Items.Add(item1);  

            timer.Start();
            performanceTests.TakeFromDictionaryInOrder();
            timer.Stop();
            ListViewItem item2 = new ListViewItem($"Выборка по порядку: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            timer.Start();
            performanceTests.TakeFromArrayInOrder();
            timer.Stop();
            item2.SubItems.Add($"Выборка по порядку: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            listView.Items.Add(item2);

            timer.Start();
            performanceTests.TakeFromDictionaryInRandom();
            timer.Stop();
            ListViewItem item3 = new ListViewItem($"В случайном порядке: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            timer.Start();
            performanceTests.TakeFromArrayInRandom();
            timer.Stop();
            item3.SubItems.Add($"В случайном порядке: {timer.Elapsed.ToString(@"m\:ss\.fff")}");
            listView.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LINQWindow lINQWindow = new LINQWindow();
            lINQWindow.Show();
        }
    }
}
