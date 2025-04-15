namespace Lesson14.General
{
    public class Store
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            var productNames = products.Select(p => p.Name);
            Console.WriteLine(string.Join(", ", productNames));
        }

        public void DisplayUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
