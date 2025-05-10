namespace Lesson_19.Events.PriceChanger
{
    public class PriceChangedEventArgs : EventArgs
    {
        public decimal OldPrice { get; }
        public decimal NewPrice { get; }

        public PriceChangedEventArgs (decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
