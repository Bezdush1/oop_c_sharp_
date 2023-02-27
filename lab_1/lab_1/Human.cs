using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace lab_1
{
    /// <summary>
    /// Класс, реализующий интерфейс человека
    /// </summary>
    class Human
    {
        public int Age { get; set; } //возраст   
        public double Weight { get; set; }  //вес
        public string Name { get; set; }  //имя
        public string SecondName { get; set; }  //фамилия
        public int NumberOfChildren { get; set; }  //год рождения
        public string Country { get; set; }  //город проживания
        public double Height { get; set; }  //рост

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Human()
        {
            Console.WriteLine("Очень красивый человек");
        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="age">Возраст человека</param>
        /// <param name="weight">Вес человека</param>
        /// <param name="name">Имя человека</param>
        /// <param name="secondName">Фамилия человека</param>
        /// <param name="numberOfChildren">Количество детей у человека</param>
        /// <param name="country">Место жительства человека</param>
        /// <param name="height">Рост человека</param>
        public Human(int age, double weight, string name, string secondName, int numberOfChildren, string country, double height)
        {
            if (age < 1 || age > 100)
                throw new Exception(" Неверный возраст человека \n Допустимый возраст лежит в диапозоне от 1 до 100");
            else
            Age = age;

            if (weight < 1 || weight > 200)
                throw new Exception(" Неверный вес человека \n Допустимый вес лежит в диапозоне от 1 до 200");
            else
                Weight = weight;

            Name = name;
            SecondName = secondName;

            if (numberOfChildren < 0)
                throw new Exception(" Неверно указано количество детей \n Допустимое значение должно быть не отрицательным");
            else
            NumberOfChildren = numberOfChildren;

            Country = country;

            if (height < 0.09 || height > 3)
                throw new Exception(" Неверный рост человека \n Допустимый рост лежит в диапозоне от 0.1 м до 3 м");
            else
            Height = height;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        public Human(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Конструктор с двумя параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        /// /// <param name="secondName">Имя человека</param>
        public Human(string name,string secondName)
        {
            Name = name;
            SecondName = secondName;
        }

        public void Print()
        {
            Console.WriteLine();
            string s = null;
            s = Convert.ToString(Age, 16);
            Console.WriteLine("вывод в 16-системе: " + s);
        }

        public override string ToString()
        {
           return ($" Возраст: {Age} \n Вес: {Weight}  кг\n Имя: {Name} \n Фамилия: {SecondName} \n Количество детей: {NumberOfChildren}\n " +
                $"Страна проживания: {Country}\n Рост {Height} м");
        }

        /// <summary>
        /// Меняет значение свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства для замены</param>
        /// <param name="value">Новое значение свойства</param>
        /// <returns>Возвращает true, если замена произошла успешно, иначе false</returns>
        public bool TryChangeProperty(string propertyName, object value)
        {
            var property = typeof(Human).GetProperty(propertyName);
            if (property == null)
            {
                return false;
            }
            try
            {
                property.SetValue(this, value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Выводит в консоль значение указанного свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства для вывода</param>
        public void PrintProperty(string propertyName)
        {
            var property = typeof(Human).GetProperty(propertyName);
            if (property != null)
            {
                Console.WriteLine($"{propertyName}: {property.GetValue(this)}");
            }
            else
            {
                Console.WriteLine("Свойство не найдено");
            }
        }

        /// <summary>
        /// Выводит в консоль значение численного свойства в шестнадцатиричном формате
        /// </summary>
        /// <param name="propertyName">Имя свойства для вывода</param>
        public void PrintInHex(string propertyName)
        {
            var property = typeof(Human).GetProperty(propertyName);
            if (property == null)
            {
                Console.WriteLine("Свойство не найдено");
                return;
            }
            try
            {
                ulong value = Convert.ToUInt64(property.GetValue(this));
                Console.WriteLine(value.ToString("X"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Данное поле не является числом");
            }
        }
    }
}
