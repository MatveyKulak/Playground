namespace Lesson23
{
    public class Linq
    {
        public static void BaseSortList() {
            List<int> nums = new List<int>() { 7, 2, 5, 9, 1, 6, 3 };

            Console.WriteLine("Исходная коллекция");
            Console.WriteLine(string.Join(", ", nums));

            var sort = nums.OrderBy(n => n).ToList();

            Console.WriteLine("Отсортированная коллекция");
            Console.WriteLine(string.Join(", ", sort));

            var square = sort
                .Skip(sort.Count / 2 + 1)
                .Select(n => n * n).ToList();

            Console.WriteLine("Результат");
            Console.WriteLine(string.Join(", ", square));
        }
    }
}
