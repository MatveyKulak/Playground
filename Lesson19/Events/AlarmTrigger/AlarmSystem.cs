namespace Lesson_19.Events.AlarmTrigger
{
    public class AlarmSystem
    {
        public delegate void AlarmHandler (string location);
        public event AlarmHandler? OnAlarm;

        public void Trigger (string location)
        {
            Console.WriteLine($"Тревога в {location}!");
            OnAlarm?.Invoke(location);
        }
    }
}
