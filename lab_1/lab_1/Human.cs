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
        public int age { get; set; } //возраст   
        public double weight { get; set; }  //вес
        public string name { get; set; }  //имя
        public string secondName { get; set; }  //фамилия
        public int numberOfChildren { get; set; }  //год рождения
        public string country { get; set; }  //город проживания
        public double height { get; set; }  //рост

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
            this.age = age;

            if (weight < 1 || weight > 200)
                throw new Exception(" Неверный вес человека \n Допустимый вес лежит в диапозоне от 1 до 200");
            else
                this.weight = weight;

            this.name = name;
            this.secondName = secondName;

            if (numberOfChildren < 0)
                throw new Exception(" Неверно указано количество детей \n Допустимое значение должно быть не отрицательным");
            else
            this.numberOfChildren = numberOfChildren;

            this.country = country;

            if (height < 0.09 || height > 3)
                throw new Exception(" Неверный рост человека \n Допустимый рост лежит в диапозоне от 0.1 м до 3 м");
            else
            this.height = height;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        public Human(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Конструктор с двумя параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        /// /// <param name="secondName">Имя человека</param>
        public Human(string name,string secondName)
        {
            this.name = name;
            this.secondName = secondName;
        }

        public override string ToString()
        {
           return ($" Возраст: {age} \n Вес: {weight}  кг\n Имя: {name} \n Фамилия: {secondName} \n Количество детей: {numberOfChildren}\n " +
                $"Страна проживания: {country}\n Рост {height} м");
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
            Type t = value.GetType();
            if (t.Equals(typeof(int)))
            {
                if ((propertyName == "age") && (((Int32)value < 1) || ((Int32)value > 100)))
                {
                    Console.WriteLine("неверно значение возраста \n Допустимый возраст лежит в диапозоне от 1 до 100");
                    return false;
                }
                if ((propertyName == "numberOfChildren") && ((Int32)value < 0) )
                {
                    Console.WriteLine("неверно значение детей \n Допустимый значение не должно быть меньше 0");
                    return false;
                }
                if ((propertyName == "weight") && (((Int32)value < 0) || ((Int32)value > 200)))
                {
                    Console.WriteLine("неверно значение веса \n Допустимый значение лежит в диапозоне от 0.1 до 199");
                    return false;
                }
                if ((propertyName == "height") && (((Int32)value < 0) || ((Int32)value > 3)))
                {
                    Console.WriteLine("неверно значение роста \n Допустимый значение лежит в диапозоне от 0.1 до 2.9");
                    return false;
                }
            }
            else if (t.Equals(typeof(double)))
            {
                if ((propertyName == "weight") && (((Double)value < 0) || ((Double)value > 200)))
                {
                    Console.WriteLine("неверно значение веса \n Допустимый значение лежит в диапозоне от 0.1 до 199");
                    return false;
                }
                if ((propertyName == "height") && (((Double)value < 0) || ((Double)value > 3)))
                {
                    Console.WriteLine("неверно значение роста \n Допустимый значение лежит в диапозоне от 0.1 до 2.9");
                    return false;
                }
            }
            else if (t.Equals(typeof(string)))
            {
                if (propertyName == "age" || propertyName == "height" || propertyName == "weight" || propertyName == "numberOfChildren")
                {
                    Console.WriteLine("неверно указано значение");
                    return false;
                }
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
