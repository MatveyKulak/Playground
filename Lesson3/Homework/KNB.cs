public class KNB
{
    public void Run()
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