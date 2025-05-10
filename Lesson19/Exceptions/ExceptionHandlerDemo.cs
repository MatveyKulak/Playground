namespace Lesson_19.Exceptions
{
    public static class ExceptionHandlerDemo
    {
        public static void Handle ()
        {
            var service = new UserService();

            service.CrashApp();

            try
            {
                service.AddUser(Guid.NewGuid(), null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"[AddUser] Исключение: {ex.Message}");
            }

            try
            {
                service.DeleteUser(Guid.NewGuid());
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine($"[DeleteUser] Исключение: {ex.Message}, {ex.CustomMessage}");
            }

            try
            {
                service.LoadUsersFromFile("nonexistent.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LoadUsersFromFile] Неожиданная ошибка: {ex.Message}");
            }

            //try
            //{
            //    var id = Guid.NewGuid();
            //    service.UpdateUsername(id, "");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"[UpdateUsername] Ошибка: {ex.Message}");
            //}
        }
    }
}
