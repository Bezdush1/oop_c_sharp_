using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banner.PrintInfo();
                //Human max1 = new Human("maximus");
                //Console.WriteLine(max1);

                //Human max2 = new Human("maximus","razmaximus");
                //Console.WriteLine(max2);

                //Human max = new Human();
                //Console.WriteLine(max);

                Human people = new Human(17, 78.6, "dsdf", "sdsa", 3, "sadasd", 0.9);
                Console.WriteLine(people);
                people.Print();

                people.PrintInHex("Name");
                people.TryChangeProperty("Name", "bigBoy");
                people.PrintProperty("Name");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
