namespace Lesson23
{
    public class Arrays
    {
        public static void CreateArray()
        {
            int n = 5;
            int[,] array = new int[n, n];
            Random random = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] = random.Next(1, 10));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Массив после обработки:");
            for (int i = 0; i < n; i++)
            {
                array[i, 0] = 0;
                array[i, n - 1] = 0;
            }
            for (int j = 0; j < n; j++)
            {
                array[0, j] = 0;
                array[n - 1, j] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
