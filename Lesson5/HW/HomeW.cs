namespace Lesson5
{
    public class HomeW
    {
        public void NumberN()
        {
            Console.Write("Введите количество чисел (n): ");
            int n = int.Parse(Console.ReadLine());

            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                double number = double.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine($"Окончательные результаты: Положительные: {positiveCount}, Отрицательные: {negativeCount}, Нули: {zeroCount}");
        }
        public void FirstLetter()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.Write("Первая буква каждого слова: ");

            foreach (string word in words)
            {
                char firstLetter = word[0];
                Console.Write(firstLetter + " ");
            }
        }
        public void Mass()
        {
            int[] sixNumbers = new int[6];
            Console.WriteLine("Введите каждый элемент массива: ");
            for (int i = 0; i < sixNumbers.Length; i++)
            {
                sixNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sixNumbers);
            Array.Reverse(sixNumbers);

            Console.WriteLine("Отсортированный массив по убыванию:");
            Console.Write("[ ");
            foreach (int number in sixNumbers)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
        }
    }
}
