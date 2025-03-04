namespace Lesson6
{
    public class Practice
    {
        private int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void SortAndReverse()
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Print(numbers);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Print(numbers);

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            Print(numbers);
        }

        public void MultiplyArrayElements()
        {
            int[] numbers = new int[4] {1, 2, 3, 4};

            int result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }
            Console.WriteLine($"Результат умножения: {result}");
        }

        public void CalculatePositiveSum()
        {
            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = 0;
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result += number;
                }
            }
            Console.WriteLine($"Результат суммирования: {result}");
        }

        public void CountOccurrences()
        {
            Console.WriteLine("Введите 10 чисел: ");
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Введите число для подсчета их кол-ва в массиве: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            foreach (var number in numbers)
            {
                if (number == target)
                {
                    count++;
                }
            }
            Console.WriteLine($"Число {target} встречается в массиве {count} раз(а).");
        }


        public void SwapAdjacentElements()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length - 1; i += 2)
            {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
            }

            Print(numbers);
        }

        public void MoveZerosToEnd()
        {
            int[] numbers = new int[7] { 1, 0, 2, 3, 0, 0, 4 };
            int[] free = new int[7];
            int j = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    free[j] = numbers[i];
                    j++;
                }
            }

            Print(free);
        }

        public void SplitAndReverse()
        {

        }
        /*Напишите метод, который удаляет все повторяющиеся элементы из
массива целых чисел, оставив только уникальные. Для решения
можно использовать дополнительный массив, или изменить
исходный массив, если это возможно.*/
        public void RemoveDuplicates()
        {
            int[] numbers = { 1, 1, 1, 2, 3, 4, 5, 3, 3, 4 };
            int[] newNumbers = new int[numbers.Length];
            int j = 0;
            foreach (int number in numbers)
            {
                if (Array.IndexOf(newNumbers, number, 0, j) == -1)
                {
                    newNumbers[j] = number;
                    j++;
                }
            }

            Print(newNumbers);
        }
        public void FindSecondLargest()
        {

        }

        public void FindSumBetweenMinAndMax()
        {
        }
        /*Дан булевый массив. Нужно найти длину самой длинной
последовательности подряд идущих одинаковых значений (true или
false).*/
        public void FindLongestSequence()
        {
            bool[] boolean = { true, false, true, true, true, true, false, false, false, false, false };

            if (boolean.Length == 0)
            {
                Console.WriteLine("0");
            }
            int maxSequence = 1;
            int nowSequence = 1;

            for (int i = 1; i < boolean.Length; i++)
            {
                if (boolean[i] == boolean[i-1])
                {
                    nowSequence++;
                }
                else
                {
                    if (nowSequence > maxSequence)
                    {
                        maxSequence = nowSequence;
                    }
                    nowSequence = 1;
                }
            }

            if (nowSequence > maxSequence)
            {
                maxSequence = nowSequence;
            }

            Console.WriteLine(maxSequence);
        }

        public void ConvertBoolArrayToString()
        {
            bool[] boolean = { true, false, true, true, true, true, false, false, false, false, false };
            string output = "";

            foreach (var item in boolean)
            {
                output += item ? 1 : 0;
            }

            Console.WriteLine(output);
        }

        public void IsPalindrome()
        {
        }

        public void AreAnagrams()
        {
        }

        public void ReverseWords()
        {
        }

        public void PrintMaxElementsOfRows()
        {
        }

        public void SumDiagonals()
        {
        }

        private void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number);
            }
        }
    }
}

