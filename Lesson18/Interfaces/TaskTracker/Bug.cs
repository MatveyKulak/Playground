using Lesson18.Interfaces.TaskTracker.Interfaces;

namespace Lesson18.Interfaces.TaskTracker
{
    public class Bug : ITask
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private string Status { get; set; }
        private string Assignee { get; set; }
        private int Priority { get; set; }
        public string BugLocation { get; private set; }
        public string Severity { get; private set; }

        public Bug (int id, string name, string bugLocation, string severity)
        {
            Id = id;
            Name = name;
            BugLocation = bugLocation;
            Severity = severity;
            Status = "Ожидает";
            Priority = 3;
        }

        public string GetStatus () => Status;
        public void UpdateStatus (string status) => Status = status;
        public void Assign (string assignee) => Assignee = assignee;
        public string GetAssignee () => Assignee;
        public void SetPriority (int priority) => Priority = priority;
        public int GetPriority () => Priority;
    }
}
