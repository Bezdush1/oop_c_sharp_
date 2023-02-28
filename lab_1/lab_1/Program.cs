using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Лабораторная работа №1" + "\n" + "Бобков и Жигалов - бригада №13" + "\n" +
            "Вариант задания: Человек" + "\n" + "Задание:Реализовать класс, содержащий не менее 7 полей с различными \n" +
            "типами данных:" + " •\tcтрока,•\tцелое, •\tвещественное.\n ");

                Human people = new Human(17, 78.6, "dsdf", "sdsa", 3, "sadasd", 0.9);
                Console.WriteLine(people);

                people.PrintInHex("age");
                people.TryChangeProperty("name", "bigBoy");
                people.PrintProperty("name");

                people.TryChangeProperty("height", 1);
                Console.WriteLine(people);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
