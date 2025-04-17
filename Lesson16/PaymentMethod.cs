namespace Lesson16
{
    abstract class PaymentMethod
    {
        public abstract string Name { get; }

        public abstract bool IsAvailable(decimal amount);
        public abstract bool CalculateTotal(decimal amount);
        public abstract bool ProcessPayment(decimal amount);
        public virtual bool Describe()
        {
            Console.WriteLine($"Метод оплаты: {Name}");
        }
    }
}
