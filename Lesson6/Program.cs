namespace Lesson6
{
    public class Program
    {
        public static void Main()
        {
            Practice practice = new Practice();

            while (true)
            {
                Console.WriteLine("\nВыберите задачу:");
                Console.WriteLine("1. Сортировка и реверс");
                Console.WriteLine("2. Умножение элементов массива");
                Console.WriteLine("3. Подсчет положительной суммы");
                Console.WriteLine("4. Подсчет вхождений");
                Console.WriteLine("5. Обмен соседних элементов");
                Console.WriteLine("6. Перемещение нулей в конец");
                Console.WriteLine("7. Разделение и реверс");
                Console.WriteLine("8. Удаление дубликатов");
                Console.WriteLine("9. Поиск самой длинной последовательности");
                Console.WriteLine("10. Конвертация массива булевых значений в строку");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        practice.SortAndReverse();
                        break;
                    case "2":
                        practice.MultiplyArrayElements();
                        break;
                    case "3":
                        practice.CalculatePositiveSum();
                        break;
                    case "4":
                        practice.CountOccurrences();
                        break;
                    case "5":
                        practice.SwapAdjacentElements();
                        break;
                    case "6":
                        practice.MoveZerosToEnd();
                        break;
                    case "7":
                        practice.SplitAndReverse();
                        break;
                    case "8":
                        practice.RemoveDuplicates();
                        break;
                    case "9":
                        practice.FindLongestSequence();
                        break;
                    case "10":
                        practice.ConvertBoolArrayToString();
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
