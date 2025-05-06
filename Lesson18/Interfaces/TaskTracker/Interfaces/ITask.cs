namespace Lesson18.Interfaces.TaskTracker.Interfaces
{
    public interface ITrackable
    {
        string GetStatus ();
        void UpdateStatus (string status);
    }

    public interface IAssignable
    {
        void Assign (string assignee);
        string GetAssignee ();
    }

    public interface IPrioritizable
    {
        void SetPriority (int priority);
        int GetPriority ();
    }

    public interface ITask : ITrackable, IAssignable, IPrioritizable
    {
        int Id { get; }
        string Name { get; }
    }
}
