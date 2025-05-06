namespace Lesson18.Generics
{
    internal class Warehouse
    {
        public static void Run ()
        {
            var intBox = new Box<int>(42);
            Console.WriteLine(intBox); // Box содержит: 42

            intBox.Set(100);
            Console.WriteLine($"Новое значение: {intBox.Get()}"); // 100

            var stringBox = new Box<string>("Привет");
            Console.WriteLine(stringBox); // Box содержит: Привет
        }
    }
}
