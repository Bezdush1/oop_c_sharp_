using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UI.bannerInfo();

                //Human people = new Human(17, 78.6, "Александр", "Щипанов", 3, "Москва", 0.9);
                //Console.WriteLine(people);

                //people.PrintInHex("age");
                //people.TryChangeProperty("name", "Руслан");
                //people.PrintProperty("name");
                //people.TryChangeProperty("age", 25);
                //people.TryChangeProperty("height", 2);
                //people.TryChangeProperty("weight", -2);
                //people.TryChangeProperty("secondName", "Хабибулин");
                //people.TryChangeProperty("numberOfChildren", -2);
                //people.TryChangeProperty("country", "Пенза");
                //Console.WriteLine(people);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
