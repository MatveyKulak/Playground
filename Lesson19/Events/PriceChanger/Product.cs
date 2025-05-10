namespace Lesson_19.Events.PriceChanger
{
    public class Product
    {
        public event EventHandler<PriceChangedEventArgs>? PriceChanged;

        private decimal _price;

        public void SetPrice (decimal newPrice)
        {
            if (newPrice != _price)
            {
                var oldPrice = _price;
                _price = newPrice;

                Console.WriteLine($"Цена изменена: {oldPrice} → {newPrice}");

                PriceChanged?.Invoke(this, new PriceChangedEventArgs(oldPrice, newPrice));
            }
        }
    }
}
