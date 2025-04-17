namespace Lesson16
{
    public class Practice
    {
        public static void TransformTwoDimensionalArray()
        {
            int[,] mas =
            {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, 8, -9 }
            };

            int countPositive = 0;
            int minValue = int.MaxValue;
            int minI = -1, minJ = -1;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > 0) countPositive++;

                    if (mas[i, j] < minValue)
                    {
                        minValue = mas[i, j];
                        minI = i;
                        minJ = j;
                    }

                    if (mas[i, j] < 0) mas[i, j] = 0;
                }
            }

            Console.WriteLine($"Число положительных элементов: " + countPositive);
            Console.WriteLine($"Минимальное значение: {minValue}, его индексы: [{minI}, {minJ}]");

            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
