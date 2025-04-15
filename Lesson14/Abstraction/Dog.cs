namespace Lesson14.Abstraction
{
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
        }

        public Dog(string name)
        {
            this.name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
