namespace Lesson14.Inheritance
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int teamSize) : base(name)
        {
            TeamSize = teamSize;
        }

        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managin the team");
        }

        public new void TeamBreak ()
        {
            Console.WriteLine("Manager is having a strategic break");
        }
    }
}
