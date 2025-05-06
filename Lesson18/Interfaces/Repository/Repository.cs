namespace Lesson18.Interfaces.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private List<T> _items = new();

        public void Add (T item) => _items.Add(item);

        public T CreateNew ()
        {
            return new T();
        }
    }
}
