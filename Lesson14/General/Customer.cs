namespace Lesson14.General
{
    public class Customer : User
    {
        public Customer(string name) : base(name) {}
        public override void ViewProduct(Product product)
        {
            Console.WriteLine($"Покупатель {Name} просматривает товар:");
            product.DisplayInfo();
        }
    }
}