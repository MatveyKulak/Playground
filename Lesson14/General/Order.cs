namespace Lesson14.General
{
    public class Order
    {
        public Cart Cart { get; set; }
        public DateTime OrderDate { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"Заказ оформлен {OrderDate}");
            Cart.DisplayCart();
        }
    }
}
