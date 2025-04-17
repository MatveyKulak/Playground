namespace Lesson17
{
    public class Program
    {
        public static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Выберите тему для отображения информации:");
                Console.WriteLine("1.Вторая задача ");
                Console.WriteLine("2.Реверс строки ");
                Console.WriteLine("3.Формат даты ");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Test.SecondTaskMas();
                        break;
                    case "2":
                        MyString chars = new MyString('c', 'a');
                        chars.ReverseMas();
                        break;
                    case "3":
                        DateTime today = DateTime.Now;
                        Console.WriteLine(today.DayMonthYear());
                        break;
                    case "10":
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }
    }
}
