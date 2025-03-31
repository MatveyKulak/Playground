namespace Lesson10
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
                Console.WriteLine("1.Чётные числа:");
                Console.WriteLine("2.Максимальное число:");
                Console.WriteLine("3.Сумма чисел кратных 3:");
                Console.WriteLine("4.Уникальные числа:");
                Console.WriteLine("5.Количество взрослых:");
                Console.WriteLine("6.Сортировка по имени:");
                Console.WriteLine("7.Поиск строк у которых больше двух слов:");
                Console.WriteLine("8.Вывод цифр между 10 и 50:");
                Console.WriteLine("9.Вывод сортированных слов:");
                Console.WriteLine("10.Группировка цифр по чётности:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Practice.EvenNumbers();
                        break;
                    case "2":
                        Practice.Maximum();
                        break;
                    case "3":
                        Practice.MultiplesOfThree();
                        break;
                    case "4":
                        Practice.Set();
                        break;
                    case "5":
                        Practice.MoreThan18();
                        break;
                    case "6":
                        Practice.SortingName();
                        break;
                    case "7":
                        Practice.CountStrings();
                        break;
                    case "8":
                        Practice.CountNumbers();
                        break;
                    case "9":
                        Practice.SortByLength();
                        break;
                    case "10":
                        Practice.EvenGroup();
                        break;
                    case "13":
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