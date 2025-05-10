namespace Lesson_19.Events
{
    public class Store
    {
        public delegate void PurchaseHandler (string productName, decimal price);
        public event PurchaseHandler? OnPurchase;

        public void Buy (string product, decimal price)
        {
            Console.WriteLine($"Покупка: {product} за {price}₽");

            // Уведомляем подписчиков
            OnPurchase?.Invoke(product, price);
        }
    }
}
