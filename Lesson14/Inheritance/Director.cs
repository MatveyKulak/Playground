namespace Lesson14.Inheritance
{
    class Director : Manager
    {
        public string CompanyName { get; set; }

        public Director(string company, string name, int teamSize) : base(name, teamSize)
        {
            CompanyName = company;
        }

        public override void Work()
        {
            base.Work();
            Console.WriteLine("Director is overseeing the entire company");
        }

        public new void TameBreak()
        {
            Console.WriteLine("Director is having a high-level strategic break");
        }
    }
}
