namespace Lesson16
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
                Console.WriteLine("1. Действия с массивом:");
                Console.Write("Введите номер: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Practice.TransformTwoDimensionalArray();
                        break;
                    case "2":
                        PaymentMethod cardPayment = new CardPayment();
                        cardPayment.Describe();
                        cardPayment.IsAvailable(5000);
                        cardPayment.ProcessPayment(5000);

                        var payments = new List<(PaymentMethod method, decimal amount)>
                        {
                            (new CardPayment(), 5000),
                            (new InvoicePayment(), 800),
                            (new InvoicePayment(), 3000),
                            (new MobilePayment(), 2000),
                            (new MobilePayment(), 500),
                        };

                        foreach (var (method, amount) in payments)
                        {
                            method.Describe();

                            if (method.IsAvailable(amount))
                            {
                                method.ProcessPayment(amount);
                            }
                            else
                            {
                                Console.WriteLine($"Метод {method.Name} недоступен для суммы {amount}");
                            }
                        }
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