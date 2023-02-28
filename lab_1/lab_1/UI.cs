using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1
{
    class UI
    {
        static List<Human> humans = new List<Human>();
        public static void bannerInfo()
        {
            Console.WriteLine("Лабораторная работа №1" + "\n" + "Бобков и Жигалов - бригада №13" + "\n" +
             "Вариант задания: Человек" + "\n" + "Задание:Реализовать класс, содержащий не менее 7 полей с различными \n" +
             "типами данных:" + " •\tcтрока,•\tцелое, •\tвещественное.\n ");

            mainMenu();
        }

        public static void mainMenu()
        {
            Console.WriteLine("Введите: \n 1 - Создать обьект\n 2 - Изменить обьект\n 3 - Просмотреть список обьектов\n 4 - Вывести всю информацию об обьекте\n" +
                " 5 - Вывести одно поле обьекта\n6 - Завершить работу");
            string? option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    createNewObject();
                    break;
                case "2":
                    changeObject();
                    break;
                case "3":
                    showList(humans);
                    break;
                case "4":
                    showAllFieldId(humans);
                    break;
                case "5":
                    printOneField(humans);
                    break;
                case "6":
                    Console.WriteLine("Завершение работ. Повторно нажмите enter");
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    mainMenu();
                    break;
            }
        }

        public static void createNewObject() 
        {
            Human human = null;
            Console.WriteLine("Выберите что хотите создать:");
            Console.WriteLine("Введите: \n" +
                "1 - Создать пустой обьект\n" +
                "2 - создать обьект с именем\n" +
                "3 - создать обьект с именем и фамилией\n" +
                "4 - создать обьект со всеми параметрами\n"+
                "5 - отменить создание и выйти в начальное меню выбора");
            string? optionCreate = Console.ReadLine();
            switch (optionCreate)
            {
                case "1":
                    human = new Human();
                    humans.Add(human);
                    Console.WriteLine($"Добавлен пустой обьект 'человек' ID:{human.humanID} ");
                    mainMenu();
                    break;

                case "2":
                    Console.WriteLine("Введите имя");
                    string nameHuman = Console.ReadLine();
                    human = new Human(nameHuman);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен обьект человек с именем:{human.name} и ID:{human.humanID}");
                    mainMenu();
                    break;

                case "3":
                    Console.WriteLine("Введите имя и фамилию");
                    string firstName = Console.ReadLine();
                    string secondName = Console.ReadLine();
                    human = new Human(firstName, secondName);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен обьект человек с именем и фамилией:{human.name} , {human.secondName} и ID:{human.humanID}");
                    mainMenu();
                    break;

                case "4":
                    Console.WriteLine("Введите следующие значение:");
                    bool flagAge = true;
                    int newAge=0;
                    while (flagAge)
                    {
                        Console.Write("Необходимо указать возраст человека (полное количество лет): ");
                        object newAgeHuman = Console.ReadLine();
                        try
                        {
                            newAge = Convert.ToInt32(newAgeHuman);
                            if (newAge<1 || newAge > 150)
                            {
                                Console.WriteLine("Введите корректный возраст (от 1 до 150)");
                            }
                            else
                            {
                                flagAge = false;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }

                    bool flagWeight = true;
                    double newWeight = 0;
                    while (flagWeight)
                    {
                        Console.Write("Необходимо указать вес человека (кг.гр): ");
                        object newWeightHuman = Console.ReadLine();
                        try
                        {
                            newWeight = Convert.ToDouble(newWeightHuman);
                            if (newWeight < 1 || newWeight > 200)
                            {
                                Console.WriteLine("Введите корректный вес (от 1 до 200)");
                            }
                            else
                            {
                                flagWeight = false;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }

                    Console.Write("Необходимо указать имя человека: ");
                    string newName = Console.ReadLine();

                    Console.Write("Необходимо указать фамилию человека: ");
                    string newSecondName = Console.ReadLine();

                    bool flagNumberOfChildren = true;
                    int newNumberOfChildren = 0;
                    while (flagNumberOfChildren)
                    {
                        Console.Write("Необходимо указать количество детей (шт): ");
                        object newNumberOfChildrenHuman = Console.ReadLine();
                        try
                        {
                            newNumberOfChildren = Convert.ToInt32(newNumberOfChildrenHuman);
                            if (newNumberOfChildren < 0)
                            {
                                Console.WriteLine("Введите корректное число (не может быть отрицательным)");
                            }
                            else
                            {
                                flagNumberOfChildren = false;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }

                    Console.Write("Необходимо указать город : ");
                    string city = Console.ReadLine();

                    bool flagHeight = true;
                    int newHeight = 0;
                    while (flagHeight)
                    {
                        Console.Write("Необходимо указать рост человека (см): ");
                        object newHeightHuman = Console.ReadLine();
                        try
                        {
                            newHeight = Convert.ToInt32(newHeightHuman);
                            if (newHeight < 1 || newHeight>260)
                            {
                                Console.WriteLine("Введите корректное число (от 1 до 260 см)");
                            }
                            else
                            {
                                flagHeight = false;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }

                    human = new Human(newAge,newWeight,newName,newSecondName,newNumberOfChildren,city,newHeight);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен человек со всеми параметрами и ID:{human.humanID} ");
                    Console.WriteLine(human);
                    mainMenu();
                    break;
                case "5":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    createNewObject();
                    break;
            }
        }

        public static void changeObject()
        {
            Console.WriteLine("Введите ID:");
            string thisId = Console.ReadLine();
            bool isFindID = false;
            foreach (Human human in humans)
            {
                if (human.humanID == thisId)
                {
                    isFindID = true;
                    changeObjectField(human);
                    break;
                }
            }
            if (!isFindID)
            {
                Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                changeObject();
            }
        }
        public static void changeObjectField(Human human) { 
            Console.WriteLine("Выберите что хотите изменить:");
            Console.WriteLine("Введите: \n" +
                "1 - Возраст\n" +
                "2 - Вес\n" +
                "3 - Имя\n" +
                "4 - Фамилию\n" +
                "5 - Количество детей\n" +
                "6 - Место жительства\n" +
                "7 - Рост\n" +
                "8 - Вернуться на главную\n");
            string? variant = Console.ReadLine();
            switch (variant)
            {
                case "1":
                    bool flagAge = true;
                    int newAge = 0;
                    while (flagAge)
                    {
                        Console.Write("Необходимо указать возраст человека (полное количество лет): ");
                        object newAgeHuman = Console.ReadLine();
                        try
                        {
                            newAge = Convert.ToInt32(newAgeHuman);
                            if (newAge < 1 || newAge > 150)
                            {
                                Console.WriteLine("Введите корректный возраст (от 1 до 150)");
                            }
                            else
                            {
                                flagAge = false;
                                human.age = newAge;
                                Console.WriteLine("Изменение успешно произведено");
                                Console.WriteLine(human);
                                changeObjectField(human);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }
                    break;

                case "2":
                    bool flagWeight = true;
                    double newWeight = 0;
                    while (flagWeight)
                    {
                        Console.Write("Необходимо указать вес человека (кг.гр): ");
                        object newWeightHuman = Console.ReadLine();
                        try
                        {
                            newWeight = Convert.ToDouble(newWeightHuman);
                            if (newWeight < 1 || newWeight > 200)
                            {
                                Console.WriteLine("Введите корректный вес (от 1 до 200)");
                            }
                            else
                            {
                                flagWeight = false;
                                human.weight = newWeight;
                                Console.WriteLine("Изменение успешно произведено");
                                Console.WriteLine(human);
                                changeObjectField(human);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }
                    break;

                case "3":
                    Console.Write($"Введите новое имя: ");
                    string firstName = Console.ReadLine();
                    human.name = firstName;
                    Console.WriteLine("Имя изменено!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "4": 
                    Console.Write($"Введите новую фамилию: ");
                    string secondName = Console.ReadLine();
                    human.secondName = secondName;
                    Console.WriteLine("Фамилия изменена!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "5": 
                    Console.Write($"Введите новое количество детей: ");
                    bool flagNumberOfChildren = true;
                    int newNumberOfChildren = 0;
                    while (flagNumberOfChildren)
                    {
                        Console.Write("Необходимо указать количество детей (шт): ");
                        object newNumberOfChildrenHuman = Console.ReadLine();
                        try
                        {
                            newNumberOfChildren = Convert.ToInt32(newNumberOfChildrenHuman);
                            if (newNumberOfChildren < 0)
                            {
                                Console.WriteLine("Введите корректное число (не может быть отрицательным)");
                            }
                            else
                            {
                                flagNumberOfChildren = false;
                                human.numberOfChildren = newNumberOfChildren;
                                Console.WriteLine("Изменение успешно произведено");
                                Console.WriteLine(human);
                                changeObjectField(human);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }
                    Console.WriteLine("количество детей изменено!");
                    break;

                case "6": 
                    Console.Write($"Введите новое место жительства: ");
                    string city = Console.ReadLine();
                    human.country = city;
                    Console.WriteLine("Место жительства изменено!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "7":
                    Console.Write($"Введите новый рост: ");
                    bool flagHeight = true;
                    int newHeight = 0;
                    while (flagHeight)
                    {
                        Console.Write("Необходимо указать рост человека (см): ");
                        object newHeightHuman = Console.ReadLine();
                        try
                        {
                            newHeight = Convert.ToInt32(newHeightHuman);
                            if (newHeight < 1 || newHeight > 260)
                            {
                                Console.WriteLine("Введите корректное число (от 1 до 260 см)");
                            }
                            else
                            {
                                flagHeight = false;
                                human.height = newHeight;
                                Console.WriteLine("Место жительства изменено!");
                                Console.WriteLine(human);
                                changeObjectField(human);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("неверно введенное значение");
                        }
                    }
                    break;
                case "8":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    return;
            }
        }

        public static void showList(List<Human> humans)
        {
            if (humans.Count==0)
            {
                Console.WriteLine("Пустой список обьектов");
                mainMenu();
            }
            else
            {
                foreach (Human item in humans)
                {
                    Console.WriteLine($"id {item.humanID} , имя {item.name}");
                }
            }
        }

        public static void showAllFieldId(List<Human> humans)
        {
            Console.WriteLine("У вас есть ID?");
            Console.WriteLine("1 - да\n2 - нет");
            string firstKey = Console.ReadLine();
            switch (firstKey)
            {
                case "1":
                    Console.WriteLine("Введите ID:");
                    string thisId = Console.ReadLine();
                    bool isFindID = false;
                    foreach (Human human in humans)
                    {
                        if (human.humanID == thisId)
                        {
                            isFindID = true;
                            Console.WriteLine(human);
                            mainMenu();
                            break;
                        }
                    }
                    if (!isFindID)
                    {
                        Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                        showAllFieldId(humans);
                    }
                    break;
                case "2":
                    Console.WriteLine("Создайте обьект");
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    return;
            }
        }

        public static void printOneField(List<Human> humans)
        {
            Console.WriteLine("У вас есть ID?");
            Console.WriteLine("1 - да\n2 - нет");
            string firstKey = Console.ReadLine();
            switch (firstKey)
            {
                case "1":
                    Console.WriteLine("Введите ID:");
                    string thisId = Console.ReadLine();
                    bool isFindID = false;
                    foreach (Human human in humans)
                    {
                        if (human.humanID == thisId)
                        {
                            isFindID = true;
                            chooseOneField(human);
                            break;
                        }
                    }
                    if (!isFindID)
                    {
                        Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                        showAllFieldId(humans);
                    }
                    break;
                case "2":
                    Console.WriteLine("Создайте обьект");
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    return;
            }
        }
        public static void chooseOneField(Human human) 
        { 
            Console.WriteLine("Выберите что хотите посмотреть:");
            Console.WriteLine("Введите: \n" +
                "1 - Возраст\n" +
                "2 - Вес\n" +
                "3 - Имя\n" +
                "4 - Фамилию\n" +
                "5 - Количество детей\n" +
                "6 - Место жительства\n" +
                "7 - Рост\n" +
                "8 - Id\n"+
                "9 - Вернуться на главную\n");
            string ? variant = Console.ReadLine();
            switch (variant)
            {
                case "1":
                    Console.WriteLine(human.age);
                    break;
                case "2":
                    Console.WriteLine(human.weight);
                    break;
                case "3":
                    Console.WriteLine(human.name);
                    break;
                case "4":
                    Console.WriteLine(human.secondName);
                    break;
                case "5":
                    Console.WriteLine(human.numberOfChildren);
                    break;
                case "6":
                    Console.WriteLine(human.country);
                    break;
                case "7":
                    Console.WriteLine(human.height);
                    break;
                case "8":
                    Console.WriteLine(human.humanID);
                    break;
                case "9":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    return;
            }    
        }
    }
}
