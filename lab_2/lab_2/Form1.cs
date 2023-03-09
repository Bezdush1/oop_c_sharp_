using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        static List<Human> humans = new List<Human>();

        public Form1()
        {
            InitializeComponent();
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
            humans.Add(new Human(age,weight,name,secondName,numberOfChildren,country,height));
            ChangeComboBox1();
            NumberOfObjects.Text = "Добавлено обьектов: " + Human.NewObjectsCount;
        }

        private void CloseProject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeComboBox1()
        {
            if (humans.Count == 0)
                NumberOfObjects.Text = "";
            else
            {
                int selected = comboBox1.SelectedIndex;
                comboBox1.Items.Clear();
                foreach (var number in humans)
                    comboBox1.Items.Add(number.Name);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(selected);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            if (selected == -1) return;
            humans[selected].Name = NewName.Text;
            humans[selected].SecondName = SecondName.Text;
            humans[selected].Country = Country.Text;
            humans[selected].Age = (int)Age.Value;
            humans[selected].Height = (int)Height.Value;
            humans[selected].NumberOfChildren = (int)NumberOfChildren.Value;
            humans[selected].Weight = (double)Weight.Value;
            label8.Text = humans[selected].ToString();
            ChangeComboBox1();
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
            int selected = comboBox1.SelectedIndex;
            if (selected == -1) return;
            label8.Text = humans[selected].ToString();
            ChangeComboBox1();
        }
    }
}
