namespace Lesson18.PersonManagment
{
    public interface IPersonManagement<T>
    {
        void Add(T person);
        void Remove(int id);
        void DisplayAll();
    }
}
