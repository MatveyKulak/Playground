namespace Lesson9
{
    public class GuessTheWord
    {
        private static Dictionary<string, string> words = new Dictionary<string, string>
        {
            { "Класс", "Это основной строительный блок программы" },
            { "Метод", "Это функция которая принадлежит классу" },
            { "Массив", "Cпорядоченная коллекция, которая хранит фиксированное количество элементов одного типа "},
            { "Оператор", "Cимвол, который сообщает компилятору выполнить определенные математические или логические манипуляции" },
            { "Сплит", "Метод для разделния строк" },
            { "Мэтч", "Метод для поиска первого совпаденийя в тексте" },
            { "Рандом", "Задаёт случайное число в определённом промежутке" },
            { "while", "Цикл с предусловием" },
            { "Стэк", "Область памяти для хранения переменных значимого типа" },
            { "Декремент", "Оператор для уменьшения значения переменной" },
            { "Значение", "В коллекции словарь является не уникальным" },
            { "Ключ", "В коллекции словарь является уникальным" },
        };

        public static void Play()
        {
            Random random = new Random();
            string word = words.Keys.ToList()[random.Next(words.Count)];
            string hint = words[word];
            word = word.ToLower();

            int attempts = 10;
            char[] shifr = new string('*', word.Length).ToCharArray();
            bool isOtgadan = false;

            List<char> Check = new List<char>();

            Console.WriteLine("Добро пожаловать в игру 'Угадай термин C#'!");
            Console.WriteLine($"У вас есть {attempts} попыток, чтобы угадать термин.");

            while (attempts > 0 && !isOtgadan)
            {
                Console.WriteLine($"Секретное слово: {string.Join(' ', shifr)}");
                Console.WriteLine($"Осталось попыток: {attempts}");

                if (attempts <= 2)
                {
                    Console.WriteLine($"Подсказка: {hint}");
                }

                Console.Write("Введите букву: ");
                string input = Console.ReadLine();

                if (input.Length != 1 || !char.IsLetter(input[0]) || string.IsNullOrEmpty(input))
                {
                    Console.Write("Введите одну букву!!!!!!!!!: ");
                    continue;
                }

                char letter = input[0];
                bool isFound = false;

                if (Check.Contains(letter))
                {
                    Console.WriteLine($"Буква '{letter}' уже была введена. Попробуйте другую букву.");
                    continue;
                }

                Check.Add(letter);

                for (int i = 0; i < word.Length; i++)
                {
                    if (letter == word[i])
                    {
                        shifr[i] = letter;
                        isFound = true;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine("Есть такая буква!");
                }
                else
                {
                    Console.WriteLine("Нет такой буквы!");
                    attempts--;
                }

                if (new string(shifr) == word)
                {
                    isOtgadan = true;
                    Console.WriteLine($"Поздравляем! Вы угадали слово: {word}");
                }
        }

        if (!isOtgadan)
        {
            Console.WriteLine($"К сожалению вы не угадали слово. Правильное слово: {word}");
        }

            Console.Write("Хотите сыграть еще раз? (да/нет): ");
            string playAgain = Console.ReadLine();
            if (playAgain == "да")
            {
                Play();
            }
            else
            {
                Console.WriteLine("Спасибо за игру! До свидания!");
            }
        }
    }
}