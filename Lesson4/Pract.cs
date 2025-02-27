namespace Lesson4
{
    //Игра угадай число:
//○ Программа загадывает случайное число от 1 до 100.
//○ Пользователь пытается его угадать, вводя числа.
//○ Программа подсказывает: "Меньше", "Больше" или "Поздравляю, вы угадали!".
    public class Pract
    {
        public void Random()
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            int myNumber;

            do
            {
                Console.Write("Угадайте число от 1 до 100: ");
                myNumber = int.Parse(Console.ReadLine());
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
            } while (myNumber != secretNumber);
        }
        //Дан цикл:
        //Сколько раз выполнится строка j = j - 1?
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
        //Создать массив элементов произвольного типа. С помощью цикла
        //(любого) перебрать все элементы этого массива и вывести их на консоль.
        public void Mass()
        {
            int[] numbers = [-1, 1322, 44 * 443, 1 - 4, 12];
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        //С помощью цикла с итератором вывести на экран в одну строку все
        //двузначные числа, кратные 5.
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
        //С помощью цикла с постусловием вывести на экран в столбик
        //последовательность чисел : -20, -40, ...,-1000.
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
        //Ввести с клавиатуры символ. Определить, необходимо ли нам
        //переместить фигуру вверх, вниз, вправо, влево в зависимости от
        //введенного символа(W, S, A, D).
        //Вывести результат решения на экран.В случае отсутствия необходимости
        //перемещения вывести соответствующее сообщение(нажата любая
        //другая клавиша).
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
