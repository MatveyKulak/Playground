namespace Lesson14.General
{
    public class Admin : User
    {
        public Admin(string name) : base(name) { }

        public override void ViewProduct(Product product)
        {
            Console.WriteLine($"Администратор {Name} проверяет товар:");
            product.DisplayInfo();
        }

        public void AddProduct(Product product, Store store)
        {
            store.AddProduct(product);
        }
    }
}