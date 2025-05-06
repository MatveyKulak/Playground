namespace Lesson16
{
    abstract class PaymentMethod
    {
        public abstract string Name { get; }

        public abstract bool IsAvailable(decimal amount);

        public abstract decimal CalculateTotal(decimal amount);

        public abstract void ProcessPayment(decimal amount);

        public virtual void Describe()
        {
            Console.WriteLine($"Метод оплаты: {Name}");
        }
    }
}
