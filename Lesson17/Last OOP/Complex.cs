namespace Lesson17.Last_OOP
{
    public class Complex : OOP
    {
        private string Check;

        public Complex(string name, int number, string check) : base(name, number)
        {
            Check = check;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Проверка: комплексное? {Check}");
        }

        public void NoComplex()
        {
            Console.WriteLine("НЕ БУДЕТ КОМПЛЕКСНОГО 100%");
        }
    }
}
