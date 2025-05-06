namespace Lesson18.Interfaces.Variants
{
    interface ICovariant<out T>
    {
        T GetAnimal ();
    }

    class CatProvider : ICovariant<Cat>
    {
        public Cat GetAnimal () => new Cat();
    }

    public class Covariant
    {
        public static void Run ()
        {
            ICovariant<Cat> catProvider = new CatProvider();
            ICovariant<Animal> animalProvider = catProvider; // Ковариантность работает!

            Animal animal = animalProvider.GetAnimal();
            Console.WriteLine("Ковариантность: работает!");
        }
    }
}