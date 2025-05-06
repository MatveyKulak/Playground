namespace Lesson16
{
    class CardPayment : PaymentMethod
    {
        public override string Name => "Картой";

        public override decimal CalculateTotal(decimal amount)
        {
            return amount * 1.02m;
        }

        public override bool IsAvailable(decimal amount) => true;

        public override void ProcessPayment(decimal amount)
        {
            decimal total = CalculateTotal(amount);
            Console.WriteLine($"Оплата картой: списано {total}");
        }
    }
}
