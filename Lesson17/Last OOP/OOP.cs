namespace Lesson17
{
    public class OOP
    {
        private string Name;
        private int Number;
        public OOP(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Name} {Number}");
        }
    }
}
