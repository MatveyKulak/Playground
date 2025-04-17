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
                Console.WriteLine("4.Студенты(вывода нет) ");
                Console.WriteLine("5.ООП ");
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
                    case "4":
                        Students studs = new Students();

                        studs.OrderByLow();
                        studs.MoreThan70();
                        studs.OnlyNames();
                        studs.MiddlePoints();
                        studs.Counting();
                        break;
                    case "5":
                        OOP myOOP = new OOP("Обычное число", 100);
                        myOOP.Print();
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
