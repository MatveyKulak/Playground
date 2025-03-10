namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
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

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите текст:");
                        string input1 = Console.ReadLine();
                        Practice.ReverseWords(input1);
                        break;
                    case "2":
                        Console.WriteLine("Введите текст:");
                        string input2 = Console.ReadLine();
                        Practice.RemoveNonAlphanumeric(input2);
                        break;
                    case "3":
                        Console.WriteLine("Введите текст:");
                        string input3 = Console.ReadLine();
                        Practice.CountWords(input3);
                        break;
                    case "4":
                        Console.WriteLine("Введите текст:");
                        string input4 = Console.ReadLine();
                        Practice.FindLongestWord(input4);
                        break;
                    case "5":
                        Console.WriteLine("Введите текст:");
                        string input5 = Console.ReadLine();
                        Practice.CountCharacters(input5);
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
