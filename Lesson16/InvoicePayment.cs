namespace Lesson16
{
    internal class InvoicePayment : PaymentMethod
    {
        public override string Name => "По счёту";

        public override decimal CalculateTotal(decimal amount)
        {
            return amount * 1.035m;
        }

        public override bool IsAvailable(decimal amount)
        {
            return amount > 1000;
        }

        public override void ProcessPayment(decimal amount)
        {
            decimal total = CalculateTotal(amount);
            Console.WriteLine($"Счёт на сумму {total} выставлен.");
        }
    }
}
