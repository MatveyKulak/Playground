namespace Lesson16
{
    internal class InvoicePayment : PaymentMethod
    {
        public override string Name => "По счёту";

        public override bool CalculateTotal(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override bool IsAvailable(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
