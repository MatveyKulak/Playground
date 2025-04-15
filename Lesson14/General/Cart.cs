namespace Lesson14.General
{
    public class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddProductToCart(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Товар {product.Name} добавлен в корзину");
        }

        public void DisplayCart()
        {
            Console.WriteLine("Содержимое корзины:");
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
            Console.WriteLine($"Общая стоимость: {CalculateTotal()}");
        }

        public double CalculateTotal()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
