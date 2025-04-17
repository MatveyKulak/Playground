namespace Lesson17.Last_OOP
{
    public class Signs : OOP
    {
        private string Sign;

        public Signs(string name, int number, string sign) : base(name, number)
        {
            Sign = sign;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Знак: {Sign}");
        }

        public void MyOpinion()
        {
            Console.WriteLine("Я не знаю какой знак)");
        }
    }
}
