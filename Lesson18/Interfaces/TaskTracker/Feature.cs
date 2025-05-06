using Lesson18.Interfaces.TaskTracker.Interfaces;

namespace Lesson18.Interfaces.TaskTracker
{
    public class Feature : ITask
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private string Status { get; set; }
        private string Assignee { get; set; }
        private int Priority { get; set; }
        public string FeatureDescription { get; private set; }

        public Feature (int id, string name, string featureDescription, string priority)
        {
            Id = id;
            Name = name;
            FeatureDescription = featureDescription;
            Status = "Ожидает";
            Priority = priority == "Высокий" ? 1 : (priority == "Средний" ? 3 : 5);
        }

        public string GetStatus () => Status;
        public void UpdateStatus (string status) => Status = status;
        public void Assign (string assignee) => Assignee = assignee;
        public string GetAssignee () => Assignee;
        public void SetPriority (int priority) => Priority = priority;
        public int GetPriority () => Priority;
    }
}