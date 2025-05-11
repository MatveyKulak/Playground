using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type type = Type.GetType("Reflection.Contact");
            if (type == null)
            {
                Console.WriteLine("Класс не найден.");
                return;
            }

            Console.WriteLine($"Имя класса: {type.Name}");

            Console.WriteLine("Свойства:");
            foreach (var property in type.GetProperties())
            {

            }

            Console.WriteLine("Методы:");
            foreach (var method in type.GetMethods())
            {
                
            }

            Console.WriteLine("Поля:");
            foreach (var field in type.GetFields())
            {

            }
        }
    }
}
