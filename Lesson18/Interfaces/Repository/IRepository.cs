namespace Lesson18.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add (T item);
        T CreateNew ();
    }
}