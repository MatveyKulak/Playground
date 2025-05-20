namespace Lesson23
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
                Console.WriteLine("1.Изменение массива");
                Console.WriteLine("2.Изменение строки ");
                Console.WriteLine("3.LINQ ");
                Console.WriteLine("4.Вызов 10 методов");
                Console.WriteLine("5.Математика ");
                Console.WriteLine("6.ООП ");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Arrays.CreateArray();
                        break;
                    case "2":
                        string str = "a1b2";
                        Console.WriteLine(str.RebuildString());
                        break;
                    case "3":
                        Linq.BaseSortList();
                        break;
                    case "4":
                        MyClass obj1 = new MyClass();
                        MyClass obj2 = new MyClass();

                        for (int i = 0; i < 5; i++)
                        {
                            obj1.MyMethod();
                            obj2.MyMethod();
                        }
                        Console.WriteLine("Событие: метод был вызван 10 раз во всех экземплярах!");
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Введите число для вычисления факториала:");
                            int number = int.Parse(Console.ReadLine());
                            int result = Math.Factorial(number);
                            Console.WriteLine($"Факториал {number} = {result}");
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }

                        try
                        {
                            Console.WriteLine("Введите основание и степень для возведения в степень:");
                            string[] nums = Console.ReadLine().Split();
                            int value = int.Parse(nums[0]);
                            int power = int.Parse(nums[1]);
                            int result1 = Math.Power(value, power);
                            Console.WriteLine($"{value} в степени {power} = {result1}");
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        break;
                    case "6":
                        
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
