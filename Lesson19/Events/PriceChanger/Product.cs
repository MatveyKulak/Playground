namespace Lesson_19.Events.PriceChanger
{
    public class Product
    {
        public event EventHandler<PriceChangedEventArgs>? OnPriceChangedEvent;

        private decimal _price;

        public void SetPrice (decimal newPrice)
        {
            if (newPrice != _price)
            {
                var oldPrice = _price;
                _price = newPrice;

                Console.WriteLine($"Цена изменена: {oldPrice} → {newPrice}");

                OnPriceChangedEvent?.Invoke(this, new PriceChangedEventArgs(oldPrice, newPrice));
            }
        }
    }
}
