namespace Lesson5
{
    public class Program
    {
        public static void Main()
        {
            Practice practice = new Practice();
            HomeW Hw = new HomeW();
            while (true)
            {
                Console.WriteLine("\nВыберите задачу:");
                Console.WriteLine("1. Обратные числа");
                Console.WriteLine("2. Проверка типа дня");
                Console.WriteLine("3. Подсчет гласных");
                Console.WriteLine("4. Получение лайков");
                Console.WriteLine("5. Математика для дня рождения");
                Console.WriteLine("6. Статистика чисел");
                Console.WriteLine("7. Первые буквы");
                Console.WriteLine("8. Таблица умножения");
                Console.WriteLine("9. Задачи из домашней работы");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        practice.GetNumbersReverse();
                        break;
                    case "2":
                        practice.CheckDayType();
                        break;
                    case "3":
                        practice.CountVowels();
                        break;
                    case "4":
                        practice.GetLikes();
                        break;
                    case "5":
                        practice.BirthdayMath();
                        break;
                    case "6":
                        practice.NumbersStats();
                        break;
                    case "7":
                        practice.GetFirstLetters();
                        break;
                    case "8":
                        practice.MultiplicationTable();
                        break;
                    case "9":
                        ShowHomeworkMenu(Hw);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте снова.");
                        break;
                }

                static void ShowHomeworkMenu(HomeW Hw)
                {
                    Console.WriteLine("Выберите задачу из домашней работы:");
                    Console.WriteLine("1. Задача NumberN");
                    Console.WriteLine("2. Задача FirstLetter");
                    Console.WriteLine("3. Задача Mass");
                    Console.WriteLine("0. Назад");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Hw.NumberN();
                            break;
                        case "2":
                            Hw.FirstLetter();
                            break;
                        case "3":
                            Hw.Mass();
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте снова.");
                            break;
                    }
                }
            }
        }
    }
}