﻿using Lesson13.Practice;

namespace Lesson13
{
    public class Program
    {
        public static void Main()
        {

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Выберите тему для отображения информации:");
                Console.WriteLine("1. Создать обычный класс");
                Console.WriteLine("2. Создать супергероев");
                Console.WriteLine("3. Продажи");
                Console.WriteLine("4. Проверка");
                Console.WriteLine("5. Библиотека");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PlainClass plainClass = new PlainClass();
                        break;
                    case "2":
                        SuperHero thor = new SuperHero("Тор", "Молния", 80, 11);
                        SuperHero spiderman = new SuperHero("Человек паук", "Паутина", 50, 11);
                        SuperHero john = new SuperHero();

                        thor.Display();
                        spiderman.Display();
                        john.Display();

                        thor.Fight(30);
                        spiderman.Fight(20);

                        int extraStrength = 10;
                        thor.Train(ref extraStrength);

                        Console.WriteLine(thor.GetHeroStats());
                        Console.WriteLine(spiderman.GetHeroStats());

                        Console.WriteLine($"Количество героев: {SuperHero.GetHeroCount()}");
                        break;
                    case "3":
                        var notebook = new Product(1, "Notebook", 1000m);
                        var mouse = new Product(1, "Mouse", 10m);

                        var order = new Order(101, "Иван Иванов", new List<Product> { notebook });

                        order.AddItem(mouse);

                        order.DisplayOrderInfo();

                        break;
                    case "4":
                        TestCase test = new TestCase("Вход в систему", "Проверка входа в систему");
                        test.InfoTest();
                        test.RunTest();
                        test.InfoTest();
                        test.FailedTest();
                        test.InfoTest();
                        break;
                    case "5":
                        Author author1 = new Author("J.K. Rowling", 1965);
                        Author author2 = new Author("J.R.R. Tolkien", 1892);

                        Book book1 = new Book("Harry Potter and the Sorcerer's Stone", author1, 20.99);
                        Book book2 = new Book("The Hobbit", author2, 15.99);

                        Library library = new Library();
                        library.AddBook(book1);
                        library.AddBook(book2);

                        library.DisplayLibraryInfo();

                        Console.WriteLine($"Total price: {library.GetTotalPrice():F2}");
                        break;
                    case "10":
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }
    }
}
