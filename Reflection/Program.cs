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
                var attributes = property.GetCustomAttributes();
                string attributesInfo = attributes.Any()
                    ? string.Join(", ", attributes.Select(a => a.GetType().Name))
                    : "Нет атрибутов";

                Console.WriteLine($"  {property.Name} ({property.PropertyType.Name}): {attributesInfo}");
            }

            Console.WriteLine("Методы:");
            foreach (var method in type.GetMethods())
            {
                string parameters = string.Join(", ", method.GetParameters()
                .Select(p => $"{p.ParameterType.Name} {p.Name}"));
                Console.WriteLine($"  {method.ReturnType.Name} {method.Name}({parameters})");
            }

            Console.WriteLine("Поля:");
            foreach (var field in type.GetFields())
            {
                Console.WriteLine($"  {field.Name} ({field.FieldType.Name})");
            }
        }
    }
}
