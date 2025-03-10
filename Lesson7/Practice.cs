using System.Text;

namespace Lesson7
{
    public class Practice
    {
        public static void ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string result = String.Join(' ', words);
            Console.WriteLine(result);
        }

        public static void RemoveNonAlphanumeric(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result.Append(c);
                }
            }
            Console.WriteLine(result);
        }

        public static void CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Слов в строке: 0");
                return;
            }

            string[] words = input.Split(new[] {' ', ',', '.'}, StringSplitOptions.TrimEntries);
            Console.WriteLine($"Слов в строке: { words.Length}");
        }

        public static void FindLongestWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Введены некорректные символы.");
                return;
            }

            string[] words = input.Split(new[] { ' ', ',', '.' });

            int max = 1;
            string maxInput = "";

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxInput = word;
                }
            }
            Console.WriteLine(maxInput);
        }

        public static void CountCharacters(string input)
        {
            int glasn = 0, sogl = 0, cifri = 0, probel = 0;
            string glBukv = "aeiouAEIOUаеиоуюАЕИОУЫЭЁ";

            foreach (char simv in input)
            {
                if (char.IsLetter(simv))
                {
                    if (glBukv.Contains(simv))
                    {
                        glasn++;
                    }
                    else
                    {
                        sogl++;
                    }
                }

                if (char.IsDigit(simv))
                {
                    cifri++;
                }

                if (char.IsWhiteSpace(simv))
                {
                    probel++;
                }
            }
            Console.WriteLine($"Гласных: {glasn}, Согласных: {sogl}, Цифр: {cifri}, Пробелов: {probel}.");
        }
        public static void FormatProblems()
        {
            int a = 3, b = -59;

            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} + {1} = {2}\n", a, b, a + b);
            result.AppendFormat("{0} - {1} = {2}\n", a, b, a - b);
            result.AppendFormat("{0} * {1} = {2}\n", a, b, a * b);

            Console.WriteLine(result);
            result.Replace("=", "equals");
            Console.WriteLine(result.ToString());
        }

        public static void HideEmail(string input)
        {
        }

        public static void FormatPhoneNumber(string phoneNumber)
        {
        }

        public static bool ValidatePassword(string password)
        {
            return false;
        }
    }
}
