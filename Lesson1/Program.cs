namespace Lesson1
{
    public class Program
    {
        public static void Main()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            string message;

            if (a > b)
            {
                message = "a > b";
            }
            else if (a < b)
            {
                message = "a < b";
            }
            else
            {
                message = "a = b";
            }

            Console.WriteLine(message);
        }
    }
}