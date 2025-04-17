namespace Lesson17
{
    public class Test
    {
        public static void SecondTaskMas()
        {
            int[,] mas =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("Input:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("OutPut:");
            int sum = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += mas[i, j];
                        mas[i, j] = 0;
                    }
                }
            }

            Console.WriteLine($"Сумма главной диагонали {sum}");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
