using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;
//Написать консольную программу, в которую пользователь вводит с
//клавиатуры число.Если число одновременно больше 5 и меньше 10,
//то программа выводит "Число больше 5 и меньше 10". Иначе
//программа выводит сообщение "Неизвестное число". (Не
//использовать тернарную операцию!)
public class Pract
{
    public string TaskName = "First task";

    public void Task1()
    {
        //Console.WriteLine("Введите число: ");
        //var number = int.Parse(Console.ReadLine());

        //if ( number > 5 && number < 10)
        //{
        //    Console.WriteLine("Число больше 5 и меньше 10");
        //}
        //else
        //{
        //    Console.WriteLine("Неизвестное число");
        //}
    }
    public void Task2()
    {
        //Console.WriteLine("Введите число: ");
        //var number = int.Parse(Console.ReadLine());

        //Console.WriteLine(number % 2 == 1 ? "Нечётное" : "Чётное");
    }

    public void Task3()
    {
        Console.WriteLine("Игра КНБ, выбирай к,н или б: ");
        Console.Write("Первый игрок: ");
        string first = Console.ReadLine();
        Console.Write("Второй игрок: ");
        string second = Console.ReadLine();
        if (first == second)
        {
            Console.Write("Ничья!");
        }
        else if (first == "к")

    }
}
