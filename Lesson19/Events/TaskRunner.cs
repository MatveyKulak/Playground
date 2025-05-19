namespace Lesson_19.Events
{
    public class TaskRunner
    {
        public delegate void TaskCompletedHandler ();
        public event TaskCompletedHandler? TaskCompletedEvent;

        public void Run ()
        {
            Console.WriteLine("Задача выполняется...");

            // Эмуляция работы
            Thread.Sleep(1000);
            Console.WriteLine("Задача завершена!");

            // Вызов события
            TaskCompletedEvent?.Invoke();
        }
    }
}
