namespace Lesson14
{
    class Cat : Animal
    {
        private string name;
        public override string Name => name;

        public Cat(string name)
        {
            this.name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
