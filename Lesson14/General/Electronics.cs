namespace Lesson14.General
{
    public class Electronics : Product
    {
        public string Brand { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Brand: {Brand}");
        }
    }
}