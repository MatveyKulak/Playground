namespace Lesson_19.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public string CustomMessage { get; set; }
        public UserNotFoundException (Guid userId) : base($"Пользователь с ID {userId} не найден.")
        {
            CustomMessage = "This is a special exception!";
        }
    }
}
