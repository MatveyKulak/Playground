using System.Globalization;

namespace Lesson13.Practice
{
    class Order
    {
        public const decimal TaxRate = 0.15m;

        private string customerName;

        public int Id { get; set; }
        public List<Product> Items { get; private set; }
        public string CustomerName
        {
            get => customerName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Имя клиента не должно быть пустым или содержать только пробелы");
                }

                customerName = value;
            }
        }

        public Order()
        {
            Id = 0;
            CustomerName = "John Doe";
            Items = new List<Product>();
        }

        public Order(int id, string name, List<Product> items)
        {
            Id = id;
            CustomerName = name;
            Items = items;
        }

        public void AddItem(Product product)
        {
            Items.Add(product);
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var item in Items)
            {
                total += item.Price;
            }

            total += total * TaxRate;

            return total;
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Заказ ID: {Id}");
            Console.WriteLine($"Имя клиента: {CustomerName}");
            Console.WriteLine($"Общая стоимость: {GetTotal():C2}");

            var byCulture = new CultureInfo("be-BY");

            decimal total = GetTotal();

            string formattedTotal = total.ToString("C2", new CultureInfo("be-BY").NumberFormat);

            Console.WriteLine($"Общая стоимость: {formattedTotal}");

            formattedTotal = formattedTotal.Replace("Br", "BYN");

            Console.WriteLine($"Общая стоимость: {formattedTotal}");
        }
    }

}
