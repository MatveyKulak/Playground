namespace Lesson14.General
{
    public abstract class User
    {
        public virtual string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public abstract void ViewProduct(Product product);
    }
}
