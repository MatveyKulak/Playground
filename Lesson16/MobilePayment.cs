namespace Lesson16
{
    internal class MobilePayment : PaymentMethod
    {
        public override string Name => "Телефоном";

        public override decimal CalculateTotal(decimal amount)
        {
            return amount * 1.015m;
        }

        public override bool IsAvailable(decimal amount)
        {
            return amount < 1000;
        }

        public override void ProcessPayment(decimal amount)
        {
            decimal total = CalculateTotal(amount);
            Console.WriteLine($"Мобильная оплата: списано {total} с баланса телефона.");
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine("MOBILE!!!!!");
        }
    }
}
