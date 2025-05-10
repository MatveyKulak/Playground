namespace Lesson_19.Delegates { 
public class UserService
{
    public delegate int Comparison (User a, User b);

    public void SortByName (List<User> users)
    {
        users.Sort((a, b) => a.Username.CompareTo(b.Username));
    }

    public void SortByAge (List<User> users)
    {
        users.Sort((a, b) => a.Id.CompareTo(b.Id));
    }

    public void SortUsers (List<User> users, Comparison compare)
    {
        users.Sort((a, b) => compare(a, b));
    }
}
}
