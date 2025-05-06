namespace Lesson18.Generics
{
    public class DataStore<T>
    {
        private List<T> _items = new List<T>();

        public void Add (T item)
        {
            _items.Add(item);
            Console.WriteLine($"Добавлено: {item}");
        }

        public void RemoveWhere (Func<T, bool> predicate)
        {
            int before = _items.Count;

            _items.RemoveAll(item => predicate(item));

            int removed = before - _items.Count;

            Console.WriteLine($"Удалено элементов: {removed}");
        }

        public List<T> GetAll ()
        {
            return new List<T>(_items);
        }

        public List<T> Filter (Func<T, bool> predicate)
        {
            return _items.Where(predicate).ToList();
        }

        public int Count => _items.Count;
    }
}
