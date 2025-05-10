namespace Lesson_19.Delegates
{
    public static class DelegateHandlerDemo
    {
        private static List<User> users = new List<User>
    {
        new() { Username = "Alice", Id = Guid.NewGuid() },
        new() { Username = "Jane", Id = Guid.NewGuid() },
        new() { Username = "John", Id = Guid.NewGuid() }
    };

        public static void HandleUsers()
        {
            var service = new UserService();

            service.SortUsers(users, (a, b) => a.Id.CompareTo(b.Id));
            Console.WriteLine("По возрасту:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username}, {user.Id}");
            }

            service.SortUsers(users, (a, b) => a.Username.Length.CompareTo(b.Username.Length));
            Console.WriteLine("\nПо длине имени:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username}, {user.Id}");
            }
        }

        public static void HandleSpeakers()
        {
            Speakers.SaySomething("Анна", Speakers.Hello);
            Speakers.SaySomething("Борис", Speakers.Bye);
        }

        public static void HandleAnonTypes()
        {
            var user = new { Name = "Анна", Age = 25 };
            Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}");

            var userSummaries = users.Select(u => new
            {
                Name = u.Username,
                Bytes = u.Id.ToByteArray()
            });

            foreach (var u in userSummaries)
            {
                Console.WriteLine($"Имя: {u.Name}, Id: {u.Bytes}");
            }
        }

        public static void HandleStandardDelegates()
        {
            var ages = new List<int> { 12, 17, 19, 25, 15 };

            // Action: вывести возраст
            Action<int> print = age => Console.WriteLine($"Возраст: {age}");

            // Func: посчитать удвоенный возраст
            Func<int, int> doubleAge = age => age * 2;

            // Predicate: найти первый возраст >= 18
            Predicate<int> isAdult = age => age >= 18;

            Console.WriteLine($"Первый взрослый: {ages.Find(isAdult)}");
            Console.WriteLine("Удвоенные возраста:");

            foreach (var age in ages)
            {
                print(doubleAge(age));
            }
        }
    }
}
