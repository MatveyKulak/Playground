namespace Lesson23
{
    public class MyClass
    {
        static int count = 0;

        public static event Action TenTimes;

        public void MyMethod()
        {
            count++;

            Console.WriteLine($"Вызов метода %{count}");
            TenTimes?.Invoke();
        }
    }
}
