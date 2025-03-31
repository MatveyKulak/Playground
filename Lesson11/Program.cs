using Lesson11.Practice;

namespace Lesson11
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
                Console.WriteLine("1.Выбор книги по автору:");
                Console.WriteLine("2.Количество книг:");
                Console.WriteLine("3.Максимально страниц(книга):");
                Console.WriteLine("4.Книги после 2000:");
                Console.WriteLine("5.Средняя сила магов в школах:");
                Console.WriteLine("6.Сильнейший маг:");
                Console.WriteLine("7.Процент учеников в школах:");
                Console.WriteLine("8.Сумма сил магов в школах:");
                Console.WriteLine("9.Самая сильная школа:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Library.BooksByAuthor();
                        break;
                    case "2":
                        Library.BookCount();
                        break;
                    case "3":
                        Library.FindMaxPages();
                        break;
                    case "4":
                        Library.BooksByYear();
                        break;
                    case "5":
                        MagicSchool.AvgSchoolPower();
                        break;
                    case "6":
                        MagicSchool.StrongestWizard();
                        break;
                    case "7":
                        MagicSchool.PercentInSchool();
                        break;
                    case "8":
                        MagicSchool.SumPowerBySchool();
                        break;
                    case "9":
                        MagicSchool.MaxPowerSchool();
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