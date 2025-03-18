using System;
using System.Linq;

namespace Lesson10
{
    public static class Practice
    {
        private static List<int> numbers = new List<int> {1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 43, 537, 468, 324};
        private static Dictionary<string, int> people = new Dictionary<string, int>
        { {"Mary", 18}, {"John", 30},
          {"Yura", 10}, {"Kevin", 15},
          {"Roma", 56}, {"Olga", 60} };
        private static List<string> input = new List<string> { "class", "iron", "right mark", "digit is one" };
      
        public static void EvenNumbers()
        {
            var result = numbers.Where(n => n % 2 == 0 || n % 3 == 0);

            foreach (var even in result)
            {
                Console.Write(even + " ");
            }
        }
        public static void Maximum()
        {
            var result = numbers.Max();

            Console.Write($"Максимальное число: {result}");
        }
        public static void MultiplesOfThree()
        {
            var result = numbers.Where(n => n % 3 == 0).Sum();

            Console.Write($"Сумма кратных трём: {result}");
        }
        public static void Set()
        {
            var result = numbers.Distinct().ToList();

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }
        public static void MoreThan18()
        {
            var result = people.Where(p => p.Value >= 18).Count();

            Console.WriteLine($"Количество старших: {result}");
        }

        public static void SortingName()
        {
            var result = people.OrderBy(p => p.Key).Select(p => p.Key).ToList();

            foreach (var p in result)
            {
                Console.Write(p + " ");
            }
        }
        public static void CountStrings()
        {
            var result = input.Count(s => s.Split(" ").Length >= 2);

            Console.WriteLine($"Строки у которых больше 2 слов: {result}");
        }

        public static void CountNumbers()
        {
            var result = numbers.Where(n => n >= 10 && n <= 50 );

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
        public static void SortByLength()
        {
            var result = input.OrderByDescending(s => s.Length).ToList();

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
        public static void EvenGroup()
        {
            var result = numbers.GroupBy(n => (n % 2 == 0) ? "Even" : "Odd").ToList();

            foreach (var group in result)
            {
                Console.Write(group.Key + " ");

                foreach (var number in group)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}