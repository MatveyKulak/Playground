namespace Lesson_19.Events
{
    public class Store
    {
        public delegate void PurchaseHandler (string productName, decimal price);
        public event PurchaseHandler? OnPurchaseEvent;

        public void Buy (string product, decimal price)
        {
            Console.WriteLine($"Покупка: {product} за {price}₽");

            // Уведомляем подписчиков
            OnPurchaseEvent?.Invoke(product, price);
        }
    }
}
