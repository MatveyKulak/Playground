namespace Lesson18.Interfaces.Variants
{
    interface IInvariant<T>
    {
        T Get ();
        void Set (T item);
    }

    class DogProvider : IInvariant<Dog>
    {
        private Dog _dog = new Dog();

        public Dog Get () => _dog;
        public void Set (Dog item) => _dog = item;
    }

    class Invariant
    {
        static void Run ()
        {
            IInvariant<Dog> dogBox = new DogProvider();

            // Попытка присвоить dogBox переменной типа IInvariant<Animal>
            // IInvariant<Animal> animalBox = dogBox; //Ошибка компиляции: несовместимые типы

            Console.WriteLine("Инвариантность интерфейса: типы строго должны совпадать.");
        }
    }
}