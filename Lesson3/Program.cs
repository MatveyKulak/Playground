using Homework1;

public class Program
{
    static void Main(string[] args)
    {
        //Console.Write("text");
        //Console.WriteLine("text");
        //var response = Console.ReadLine();
        //var number = int.Parse(response);

        //Greet();
        //GetMaxWeight();
        //GetAvgValue();
        //GetCurrentAge();
        //MethodName();
        //Pract pract = new Pract();
        //Console.WriteLine(pract.TaskName);
        //pract.Task1();
        //pract.Task2();
        //pract.Task3();
        KNB task1 = new KNB();
        task1.Run();
        Check task2 = new Check();
        task2.Run1();

    }

    //Задание 1:
    //Написать программу, которая принимает строку, и если строка
    //совпадает с вашим именем, выводить персональное приветствие.
    //Если не совпадает - стандартное.
    //Задача со звездочкой - принимать и распознавать имя в любом регистре (Аня = аНя = анЯ). 
    //Использовать метод .ToLower() или его аналог.

    //private static void Greet()
    //{
    //    Console.Write("Your name? ");
    //    string name = Console.ReadLine().ToLower();
    //    if (name == "matvey")
    //    {
    //        Console.WriteLine("Hello " + name);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}

    //Задание 2:
    //Дано 5 гирь с разным весом в случайном порядке.Найти вес самой
    //тяжелой гири.Вес гирь прописан в коде (захардкодан).
    //Задача со звездочкой - принимать вес гирь с консоли.
    //Для конвертации строки в число использовать int.Parse(строка)
    //private static void GetMaxWeight()
    //{
    //    int first = 1;
    //    int second = 6;
    //    int third = 12;
    //    int fourth = 3;
    //    int fifth = 77;
    //    int max = first;

    //    if (second > max)
    //    {
    //        max = second;
    //    }
    //    if (third > max)
    //    {
    //        max = third;
    //    }
    //    if (fourth > max)
    //    {
    //        max = fourth;
    //    }
    //    if (fifth > max)
    //    {
    //        max = fifth;
    //    }
    //    Console.WriteLine("Max weight: " + max);
    //}

    //Задание 3:
    //Создать 3 переменных и инициализировать их значениями из
    //консоли. Найти среднее значение переменных и вывести в консоль.
    //public static void GetAvgValue()
    //{
    //    Console.Write("Input number: ");
    //    var text1 = Console.ReadLine();
    //    var number1 = double.Parse(text1);
    //    Console.Write("Input number: ");
    //    var text2 = Console.ReadLine();
    //    var number2 = double.Parse(text2);
    //    Console.Write("Input number: ");
    //    var text3 = Console.ReadLine();
    //    var number3 = double.Parse(text3);

    //    double middle = (number1 + number2 + number3) / 3;

    //    Console.Write("Result: " + middle);
    //}

    //Задание 4:
    //Пользователь вводит свой год рождения.Программа должна вывести
    //его возраст на текущий год.Подсказка: используйте переменные типа
    //int для хранения года рождения и текущего года.
    //public static void GetCurrentAge()
    //{
    //    Console.Write("Input year of your birthday: ");
    //    var year = Console.ReadLine();
    //    var right_year = int.Parse(year);
    //    int current_year = 2025;
    //    int age = current_year - right_year;

    //    Console.WriteLine("Your age: " + age);
    //}

    //Задание 5:
    //Реализовать в программном виде ваш алгоритм с предыдущего урока.
    public static void MethodName()
    {
        
    }
}