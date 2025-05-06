namespace Lesson18.Generics
{
    public class DataStoreService
    {
        public static void Run ()
        {
            var peopleStore = new DataStore<Person>();

            peopleStore.Add(new Person { Name = "Аня", Age = 25 });
            peopleStore.Add(new Person { Name = "Борис", Age = 32 });
            peopleStore.Add(new Person { Name = "Сергей", Age = 17 });

            Console.WriteLine("\nВсе люди:");

            foreach (var person in peopleStore.GetAll())
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nСовершеннолетние:");
            var adults = peopleStore.Filter(p => p.Age >= 18);

            foreach (var person in adults)
            {
                Console.WriteLine(person);
            }

            peopleStore.RemoveWhere(p => p.Age < 18);

            Console.WriteLine($"\nОсталось в хранилище: {peopleStore.Count} чел.");
        }
    }

    internal class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }

        public override string ToString () => $"{Name}, {Age} лет";
    }
}
