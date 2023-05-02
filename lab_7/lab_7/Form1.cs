using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        static List<Train> trains = new List<Train>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreateObject_Click(object sender, EventArgs e)
        {
            if (IsString(textBoxToilet.Text)&&
                IsString(textBoxBuffet.Text)&&
                IsString(textBoxCargoComponents.Text))
            {
                bool flagToilet = TrueOrFalse(textBoxToilet.Text);
                bool flagBuffet = TrueOrFalse(textBoxBuffet.Text);
                bool flagCargoComponent = TrueOrFalse(textBoxCargoComponents.Text);

                var expressions = new List<IExpression>
                {
                    new PassengerTrainExpression(),
                    new CargoTrainExpression(),
                };

                var stationInterpreter = new TrainStationInterpreter(expressions);

                var newTrain = new Train((int)numericNumberTrain.Value,
                    new TrainType((int)numericNumberTrain.Value, flagToilet,flagBuffet,flagCargoComponent));

                trains.Add(newTrain);

                var trainType = stationInterpreter.GetTrainType(newTrain);
                dataGridView1.Rows.Add(newTrain.Number,trainType);
            }
            else
            {
                Exception.MessageBox(0, "неверно введенное значение", "ошибка", 0);
            }            
        }

        private bool IsString(string input)
        {
            string pattern = @"^(да|нет|Да|Нет)$";
            Match match = Regex.Match(input, pattern);
            return match.Success;
        }

        private bool TrueOrFalse(string input)
        {
            if (input == "нет" || input == "Нет") return false;
            else return true;
        }

        private void ButtonClearDataGridView_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
