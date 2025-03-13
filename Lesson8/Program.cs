namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Выберите тему для отображения информации:");
                Console.WriteLine("1. Подсчёт количества слов");
                Console.WriteLine("2. Нахождение первого уникального числа");
                Console.WriteLine("3. Группировка строк по длине.");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Practice.CountWords();
                        break;
                    case "2":
                        Practice.FirstUnique();
                        break;
                    case "3":
                        Practice.GroupString();
                        break;
                    case "4":
                        
                        break;
                    case "5":
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
