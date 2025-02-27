namespace Lesson5
{
    public class Practice
    {
        public  void GetNumbersReverse()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void CheckDayType()
        {
            Console.Write("Введите номер дня недели");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: 
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Рабочий день");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Выходной день");
                    break;
                default:
                    Console.WriteLine("Неверный день");
                    break;
            }
        }

        public void CountVowels()
        {
            string glasnie = "уеыаоэяию";
            Console.Write("Введите пару слов: ");
            string words = Console.ReadLine();
            int count = 0;

            foreach (char ch in words)
            {
                if (ch == 'a' || ch == 'e' || ch == 'u' || ch == 'i' || ch == 'o')
                {
                    count++;
                }
            }
            Console.WriteLine("Столько гласных букв в словах: " + count);
        }

        public void GetLikes()
        {
            string[] names = ["Peter", "Maria","Matvey","Sasha", "Vladimir"];

            switch (names.Length)
            {
                case 0:
                    Console.WriteLine("Нет лайков");
                    break;
                case 1:
                    Console.WriteLine("Один лайк: " + names[0]);
                    break;
                case 2:
                    Console.WriteLine("Два лайка: " + names[0] + " " + names[1]);
                    break;
                case 3:
                    Console.WriteLine("Три лайка: " + names[0] + " " + names[1] + " " + names[2]);
                    break;
                default:
                    Console.WriteLine("Лайкнуло: " +  names[0] + " " + names[1] + " и ещё " +  (names.Length - 2));
                    break;
            }

        }

        public void BirthdayMath()
        {
            int Birthday = 15;

            for (int i = 100; i < 800; i++)
            {
                if (i % Birthday == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public void NumbersStats()
        {

        }

        public void GetFirstLetters()
        {

        }

        public void MultiplicationTable()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
