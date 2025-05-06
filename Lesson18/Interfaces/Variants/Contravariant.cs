namespace Lesson18.Interfaces.Variants
{
    interface IContravariant<in T>
    {
        void Handle (T animal);
    }

    class AnimalProvider : IContravariant<Animal>
    {
        public void Handle (Animal animal)
        {
            Console.WriteLine($"Обработан: {animal.GetType().Name}");
        }
    }

    public class Contravariant
    {
        public static void Run ()
        {
            IContravariant<Animal> handler = new AnimalProvider();
            IContravariant<Dog> dogHandler = handler; // Контрвариантность работает!

            dogHandler.Handle(new Dog());
        }
    }
}
