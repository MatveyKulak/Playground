﻿namespace Lesson16
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
                Console.WriteLine("1. Действия с массивом:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Practice.TransformTwoDimensionalArray();
                        break;
                    case "2":
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