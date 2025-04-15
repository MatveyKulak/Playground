namespace Lesson14.Inheritance
{
    class Employee
    {
        public virtual string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }

        public virtual void TakeBreak()
        {
            Console.WriteLine("Employee is taking a break");
        }
    }


}
