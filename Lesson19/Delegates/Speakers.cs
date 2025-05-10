namespace Lesson_19.Delegates
{
    public class Speakers
    {
        public delegate void Speaker(string name);

        public static void SaySomething(string name, Speaker speaker)
        {
            speaker(name);
        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }

        public static void Bye(string name)
        {
            Console.WriteLine($"Пока, {name}!");
        }
    }
}