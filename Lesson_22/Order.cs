namespace Lesson_22
{
    public class Order
    {
        public event EventHandler<double> AmountChangesEvent;

        private double amount;
        public int Id { get; set; }

        public string CustomerEmail { get; set; }

        public double Amount
        {
            get => amount;
            set
            {
                if (amount != value)
                {
                    amount = value;
                    OnAmountChanged(amount);
                }
            }
        }

        protected virtual void OnAmountChanged (double newAmount)
        {
            AmountChangesEvent?.Invoke(this, newAmount);
        }
    }
}
