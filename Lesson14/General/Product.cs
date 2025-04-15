namespace Lesson14.General
{
    public abstract class Product
    {
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }

        public abstract void DisplayInfo();
    }
}