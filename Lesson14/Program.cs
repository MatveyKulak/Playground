using Lesson14.Abstraction;
using Lesson14.General;
using Lesson14.Inheritance;

namespace Lesson14
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
                Console.Write("Введите номер: ");
                Console.WriteLine("1. Кот и собака:");
                Console.WriteLine("2. Компания:");
                Console.WriteLine("3. Магазин:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Animal dog = new Dog("Max");
                        Animal cat = new Cat("Whiskors");

                        dog.MakeSound();
                        cat.MakeSound();
                        break;
                    case "2":
                        Employee employee = new("John Doe");
                        Manager manager = new Manager("John Doe", 10);
                        Director director = new Director("Nasa", "John Doe Sr", 1000);

                        employee.Work();
                        manager.Work();
                        director.Work();

                        employee.TakeBreak();
                        manager.TakeBreak();
                        director.TakeBreak();
                        break;
                    case "3":
                        Store store = new Store();
                        Admin admin = new Admin("John Doe");
                        var phone = new Electronics{ Name = "IPhone", Price = 3000, Brand = "Apple" };
                        var jeans = new Clothing{ Name = "Aloha", Price = 100, Size = 40, Material = "Cotton" };

                        admin.AddProduct(phone, store);
                        admin.AddProduct(jeans, store);

                        store.DisplayProducts();

                        Customer customer = new Customer("Alex");
                        customer.ViewProduct(phone);

                        Cart cart = new Cart();
                        cart.AddProductToCart(phone);
                        cart.AddProductToCart(jeans);
                        cart.DisplayCart();

                        Order order = new Order() { Cart = cart, OrderDate = DateTime.Now };
                        order.PlaceOrder();
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
