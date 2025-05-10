namespace DebugDemo
{
    class Program
    {
        private static bool invalidFlag;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов:");

            string input = Console.ReadLine();
            int size = int.Parse(input);

            int[] data = GetData(size);

            int sum = SumRecursive(data, 0);

            double average = sum / size;

            PrintResult(sum, average);
        }

        private static void PrintResult(int sum, double average)
        {
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее значение: {average}");
        }

        static int[] GetData(int size)
        {
            int[] values = new int[size];

            Console.WriteLine("Введите элементы:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"[{i}] = ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (invalidFlag)
            {
                Console.WriteLine("Это никогда не сработает");
            }

            return values;
        }

        static int SumRecursive(int[] array, int index)
        {
            if (index >= array.Length)
                return 0;

            return array[index] + SumRecursive(array, index + 1);
        }
    }
}
