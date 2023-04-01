using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI
{
    /// <summary>
    /// Класс, реализующий библиотеку
    /// </summary>
    public class Library : IComparable<Library>
    {
        /// <summary>
        /// Свойство названия библиотеки
        /// </summary>
        public string Name { get; set; } = "Безымянная";
        /// <summary>
        /// Свойство описания библиотеки
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Свойство количества книг в библиотеке
        /// </summary>
        public long BooksNumber { get; set; } = 10;
        /// <summary>
        /// Свойство количества читальных залов в библиотеке
        /// </summary>
        public int ReadingRoomsCount { get; set; } = 1;
        /// <summary>
        /// Свойство типа библиотеки
        /// </summary>
        public string Type { get; set; } = "Обычная";
        /// <summary>
        /// Свойство наличия WiFi в библиотеке
        /// </summary>
        public bool WithWiFi { get; set; } = false;
        /// <summary>
        /// Свойство рейтинга библиотеки
        /// </summary>
        public decimal Rating { get; set; } = 0.0m;
        /// <summary>
        /// Статическое поле числа созданных объектов
        /// </summary>
        private static int _objectsCount;
        /// <summary>
        /// Статическое свойство числа созданных объектов
        /// </summary>
        public static int ObjectsCount => _objectsCount;
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Library()
        {
            _objectsCount++;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        public Library(string name) : base()
        {
            Name = name;
        }

        /// <summary>
        /// Конструктор с двумя праметрами
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="type">Тип библиотеки</param>
        public Library(string name, string type) : base()
        {
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="description">Описание библиотеки</param>
        /// <param name="booksNumber">Количество книг в библиотеке</param>
        /// <param name="readingRoomsCount">Количество читальных залов в библиотеке</param>
        /// <param name="type">Тип библиотеки</param>
        /// <param name="withWiFi">Наличие WiFi</param>
        /// <param name="rating">Рейтинг библиотеки</param>
        public Library(string name, string description, long booksNumber, int readingRoomsCount, string type, bool withWiFi, decimal rating) : base()
        {
            Name = name;
            Description = description;
            BooksNumber = booksNumber;
            ReadingRoomsCount = readingRoomsCount;
            Type = type;
            WithWiFi = withWiFi;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Library. Name: {Name}, Description: {Description}, BooksNumber: {BooksNumber}, ReadingRoomsCount: {ReadingRoomsCount}, Type: {Type}, " +
                $"WithWiFi: {WithWiFi}, Rating: {Rating}";
        }

        /// <summary>
        /// Меняет значение свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства для замены</param>
        /// <param name="value">Новое значение свойства</param>
        public void TryChangeProperty(string propertyName, object value)
        {
            var property = typeof(Library).GetProperty(propertyName);
            if (property == null)
            {
                throw new InvalidPropertyManipulationException("Ошибка: указанное свойство не найдено");
            }
            try
            {
                if (property.PropertyType.Equals(typeof(int)))
                {
                    if (int.TryParse(value.ToString(), out int number))
                    {
                        property.SetValue(this, number);
                    }
                    else
                    {
                        throw new InvalidPropertyManipulationException("Ошибка: свойство и указанное значение - несоотносимые типы данных");
                    }
                }
                else if (property.PropertyType.Equals(typeof(long)))
                {
                    if (long.TryParse(value.ToString(), out long number))
                    {
                        property.SetValue(this, number);
                    }
                    else
                    {
                        throw new InvalidPropertyManipulationException("Ошибка: свойство и указанное значение - несоотносимые типы данных");
                    }
                }
                else if (property.PropertyType.Equals(typeof(bool)))
                {
                    property.SetValue(this, Convert.ToBoolean(value));
                }
                else if (property.PropertyType.Equals(typeof(decimal)))
                {
                    property.SetValue(this, Convert.ToDecimal(value));
                }
                else
                {
                    property.SetValue(this, value);
                }
            }
            catch (Exception)
            {
                throw new InvalidPropertyManipulationException("Ошибка: свойство и указанное значение - несоотносимые типы данных");
            }
        }

        /// <summary>
        /// Возвращает строку значение указанного свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства для вывода</param>
        public string GetPropertyMessage(string propertyName)
        {
            var property = typeof(Library).GetProperty(propertyName);
            if (property != null)
            {
                return $"{propertyName}: {property.GetValue(this)}";
            }
            else
            {
                throw new InvalidPropertyManipulationException("Свойство не найдено");
            }
        }

        /// <summary>
        /// Возвращает числовое свойство в виде строки в шестнадцатиричном представлении
        /// </summary>
        /// <param name="propertyName">Имя свойства для вывода</param>
        public string GetPropertyInHexMessage(string propertyName)
        {
            var property = typeof(Library).GetProperty(propertyName);
            if (property == null)
            {
                throw new InvalidPropertyManipulationException("Свойство не найдено");
            }
            try
            {
                ulong value = Convert.ToUInt64(property.GetValue(this));
                return value.ToString("X");
            }
            catch (FormatException)
            {
                throw new InvalidPropertyManipulationException("Данное поле не является числом");
            }
        }

        /// <summary>
        /// Возвращает информацию о членах класса в формате "Тип, Имя" и имя класса
        /// </summary>
        /// <returns>Возвращает массив строк-записей всех членов класса</returns>
        public static string[] GetClassInfo()
        {
            var membersInfo = typeof(Library).GetMembers();
            string[] info = new string[membersInfo.Length + 1];
            info[0] = $"1) Класс: {typeof(Library)}";
            for (int i = 0; i < membersInfo.Length; i++)
            {
                info[i + 1] = $"{i + 2}) Тип {membersInfo[i].MemberType}, Название {membersInfo[i].Name}";
            }
            return info;
        }

        public int CompareTo(Library? library)
        {
            if (library is null) throw new ArgumentException("Некорректное значение параметра");
            return Name.CompareTo(library.Name);
        }
    }
}
