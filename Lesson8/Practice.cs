namespace Lesson8
{
    public class Practice
    {
        public static void CountWords()
        {
            List<string> words = new List<string>() { "Anna", "Irina", "Ivan", "Anna", "Anna", "Ivan" };
            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"Word {kvp.Key} count {kvp.Value}");
            }
        }

        public static void FirstUnique()
        {
            List<int> numbers = new List<int>() { 1, 2, 2, 3, 5, 5, 1, 7 };
            var result = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result[number] = 1;
                }
            }

            foreach (var kvp in result)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine($"Unique number: {kvp.Key}");
                    break;
                }
            }
        }
        public static void GroupString()
        {
            List<string> words = new List<string> { "apple", "banana", "cat", "dog" };
            Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word.Length))
                {
                    result[word.Length] = new List<string>();
                }

                result[word.Length].Add(word);
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"Строки длинной {kvp.Key}: {string.Join(" ", kvp.Value)}");
            }
        }
    }
}
