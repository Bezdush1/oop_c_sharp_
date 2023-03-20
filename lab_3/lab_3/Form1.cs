using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myStack.objectCreated += NewObjectCrated;
            myStack.objectDelete += NewObjectDelete;
        }

        public static void NewObjectDelete(object sender, EventArgs e)
        {
            MessageBox.Show("вы удали обьект");
        }

        public static void NewObjectCrated(object sender, EventArgs e)
        {
            MessageBox.Show("вы создали обьект");
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            string name = NewName.Text;
            string secondName = SecondName.Text;
            string country = Country.Text;
            int age = (int)Age.Value;
            int height = (int)Height.Value;
            int numberOfChildren = (int)NumberOfChildren.Value;
            double weight = (double)Weight.Value;
            if (exeminationString(name)&&exeminationString(secondName)&&exeminationString(country))
            {
            myStack.Push(new Human(age, weight, name, secondName, numberOfChildren, country, height));
            ChangeComboBox1();
                NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;
            }
            else
            {
                Exception.MessageBox(0, "Введите корректные значения.Имя, фамилия и город должны быть символами Кириллицы!",
                       "Ошибка!", 0);
            }
        }

        private void CloseProject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeComboBox1()
        {
            if (myStack.Count() == 0)
            {
                comboBox1.Items.Clear();
                NumberOfObjects.Text = " ";
                comboBox1.Text = " ";
            }
            else
            {
                int selected = comboBox1.SelectedIndex;
                comboBox1.Items.Clear();
                foreach (var number in myStack.humanStack())
                    comboBox1.Items.Add(number.Name);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(selected);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem as string;
            if (selected == null) return;
            else if (exeminationString(NewName.Text) && exeminationString(SecondName.Text) && exeminationString(Country.Text))
            {
                Human human = myStack.FirstOrDefault(selected);
                human.Name = NewName.Text;
                human.SecondName = SecondName.Text;
                human.Country = Country.Text;
                human.Age = (int)Age.Value;
                human.Height = (int)Height.Value;
                human.NumberOfChildren = (int)NumberOfChildren.Value;
                human.Weight = (double)Weight.Value;
                label8.Text = (human).ToString();
                ChangeComboBox1();
            }
            else
            {
                Exception.MessageBox(0, "Недопустимое значение имени, фамилии или города.", "Ошибка!", 0);
                return;
            }
        }

        private void CreateException_Click(object sender, EventArgs e)
        {
            try
            {
                OutOfMemoryException();
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OutOfMemoryException()
        {
            throw new StackOverflowException("Ты вызвал OutOfMemoryException");
        }

        private void SeeObject_Click(object sender, EventArgs e)
        {
            string selectedObject = comboBox1.SelectedItem as string;
            if (selectedObject != null)
            {
                Human human = myStack.FirstOrDefault(selectedObject);
                label8.Text=(human).ToString();
            }
        }

        private bool isString(string input)
        {
            string pattern = @"^[A-Za-zА-Яа-я]+$";
            Match match = Regex.Match(input, pattern);
            return match.Success;
        }

        bool exeminationString(string newString)
        {
            bool flag = true;
            if (!(newString == ""))
            {
                if (!(isString(newString)))
                {
                    flag = false;
                    Exception.MessageBox(0, "Введено некорректное поле.", "Ошибка!", 0);
                }
            }
            return flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            string selectedObject = comboBox1.SelectedItem as string;
            if (selectedObject != null)
            {
                myStack.Pop(selectedObject);
                ChangeComboBox1();
                NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;
                comboBox1.Text = "";
            }
        }

        private void PrintAll_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void ShowTime_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            //ListViewItem lv2 = new ListViewItem();
            lv1.Text = "Последовательная";
           // lv2.Text = "Случайная";
           
                //listView1.Items[1] = lv1;
              
            const int N = 100000;
            Human[] array = new Human [N];

            for (int i = 0; i < N; i++)
            {
                myStack.Push(new Human());
                array[i] = new Human();
            }

            Stopwatch TimeArray = new Stopwatch();
            Stopwatch TimeStack = new Stopwatch();

            TimeStack.Start();
           foreach (Human human in myStack.humanStack()) { }
            TimeStack.Stop();

            TimeArray.Start();
            foreach (Human human in array) { }
            TimeArray.Stop();

            lv1.SubItems.Add(TimeArray.ElapsedTicks.ToString());
            listView1.Items[0] = lv1;
        }
    }
}
