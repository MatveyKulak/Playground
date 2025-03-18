namespace Lesson7
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1. Реверс слов");
                Console.WriteLine("2. Удаление не алфавитно-цифровых символов");
                Console.WriteLine("3. Подсчет слов");
                Console.WriteLine("4. Поиск самого длинного слова");
                Console.WriteLine("5. Подсчет символов");
                Console.WriteLine("6. Форматирование проблем");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();
                string input = string.Empty;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите текст:");
                        Practice.ReverseWords(input);
                        break;
                    case "2":
                        Console.WriteLine("Введите текст:");
                        Practice.RemoveNonAlphanumeric(input);
                        break;
                    case "3":
                        Console.WriteLine("Введите текст:");
                        Practice.CountWords(input);
                        break;
                    case "4":
                        Console.WriteLine("Введите текст:");
                        Practice.FindLongestWord(input);
                        break;
                    case "5":
                        Console.WriteLine("Введите текст:");
                        Practice.CountCharacters(input);
                        break;
                    case "6":
                        Practice.FormatProblems();
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