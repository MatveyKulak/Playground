namespace Lesson4
{
    public class Pract
    {
        public void Random()
        {
            Console.Write("Угадайте число от 1 до 100: ");
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            var myNumber = int.Parse(Console.ReadLine());

            if (myNumber > secretNumber)
            {
                Console.WriteLine("Меньше");
            }
            else if (myNumber < secretNumber)
            {
                Console.WriteLine("Больше");
            }
            else
            {
                Console.WriteLine("Поздравляю, вы угадали!");
            }
        }

        public void For()
        {
            int j = 2;
            int count = 0;

            for (int i = 1; i < 100; i = i + 2)
            {
                j = j - 1;

                while (j < 15)
                {
                    j = j + 5;
                }

                count++;
            }
            Console.WriteLine(count);
        }
        public void Mass()
        {
            int[] numbers = [-1, 1322, 44 * 443, 1 - 4, 12];
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        public void For100()
        {
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void WhileDo()
        {
            int i = -20;
            do
            {
                Console.WriteLine(i);
                i-=20;
            }
            while (i >= -1000);
        }
        public void Char()
        {
            Console.WriteLine("Введите W, S, A или D для перемещения фигуры:");

            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();

            switch (key)
            {
                case ConsoleKey.W:
                    Console.WriteLine("Перемещение фигуры вверх.");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("Перемещение фигуры вниз.");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("Перемещение фигуры влево.");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("Перемещение фигуры вправо.");
                    break;
                default:
                    Console.WriteLine("Нажата другая клавиша.");
                    break;
            }

        }
    }
}
