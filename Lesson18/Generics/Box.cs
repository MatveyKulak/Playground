namespace Lesson18.Generics
{
    public class Box<T>
    {
        private T _value;

        public Box (T value)
        {
            _value = value;
        }

        public T Get ()
        {
            return _value;
        }

        public void Set (T value)
        {
            _value = value;
        }

        public override string ToString ()
        {
            return $"Box содержит: {_value}";
        }
    }
}
