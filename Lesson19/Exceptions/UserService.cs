namespace Lesson_19.Exceptions
{
    public class UserService
    {
        private readonly Dictionary<Guid, string> _users = new();

        public void CrashApp ()
        {
            //throw new Exception("App is crashed");
        }

        public void AddUser (Guid id, string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException(nameof(username), "Имя пользователя не может быть пустым");
            }

            if (_users.ContainsKey(id))
            {
                throw new InvalidOperationException("Пользователь с таким ID уже существует");
            }

            _users.Add(id, username);
            Console.WriteLine($"Пользователь {username} успешно добавлен.");
        }

        public void LoadUsersFromFile (string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    Guid id = Guid.Parse(parts[0]); // может выбросить FormatException
                    string username = parts[1];

                    AddUser(id, username);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Файл не найден: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка формата: {ex.Message}");
            }
            catch (Exception ex) when (ex is IndexOutOfRangeException || ex is ArgumentNullException)
            {
                Console.WriteLine($"Ошибка при обработке строки: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Загрузка завершена (успешно или с ошибкой).");
            }
        }

        public void DeleteUser (Guid id)
        {
            if (!_users.ContainsKey(id))
            {
                throw new UserNotFoundException(id);
            }

            _users.Remove(id);
            Console.WriteLine($"Пользователь с ID {id} удалён.");
        }

        //public void UpdateUsername (Guid id, string newUsername)
        //{
        //    Guard.Against.NullOrEmpty(newUsername, nameof(newUsername));
        //    Guard.Against.Default(id, nameof(id));

        //    _users[id] = newUsername;
        //    Console.WriteLine($"Имя пользователя с ID {id} обновлено на '{newUsername}'");
        //}
    }
}
