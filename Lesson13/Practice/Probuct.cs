namespace Lesson13.Practice
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string name, decimal price)
        {
            Id = productId;
            Name = name;
            Price = price;
        }
    }
}
