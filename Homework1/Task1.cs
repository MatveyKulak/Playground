using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1;
public class Task1
{
    public static void Main(string[] args)
    {
        //Task_first();
        Task2 task = new Task2();
        task.Main2();
    }
    private static void Task_first()
    {
        Console.WriteLine("Игра КНБ, выберите камень, ножницы или бумагу");
        Console.Write("Первый игрок, ваш выбор: ");
        string player1 = Console.ReadLine();
        Console.Write("Второй игрок, ваш выбор: ");
        string player2 = Console.ReadLine();

        if (player1 == player2)
        {
            Console.WriteLine("Ничья!");
        }
        else if ((player1 == "камень" && player2 == "ножницы") ||
                 (player1 == "бумага" && player2 == "камень") ||
                 (player1 == "ножницы" && player2 == "бумага"))
        {
            Console.WriteLine("Игрок 1 выиграл!");
        }
        else
        {
            Console.WriteLine("Игрок 2 выиграл!");
        }
    }
}