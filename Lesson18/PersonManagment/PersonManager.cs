namespace Lesson18.PersonManagment
{
    public class PersonManager<T> : IPersonManagement<T> where T : Person
    {
        private List<T> people = [];

        public void Add(T person)
        {
            people.Add(person);
            Console.WriteLine($"{person.Name} добавлен в систему.");
        }

        public void DisplayAll()
        {
            Console.WriteLine("Список людей:");

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public void Remove(int id)
        {
            var person = people.Find(person => person.Id == id);

            if (person != null)
            {
                people.Remove(person);
                Console.WriteLine($"{person.Name} удалён из системы.");
            }
            else
            {
                Console.WriteLine($"Человек с {id} не найден.");
            }
        }
    }
}