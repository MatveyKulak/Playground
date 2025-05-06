using Lesson18.Interfaces.TaskTracker.Interfaces;

namespace Lesson18.Interfaces.TaskTracker
{
    public class TaskManager
    {
        private List<ITask> tasks = new List<ITask>();

        public void AddTask (ITask task)
        {
            tasks.Add(task);
        }

        public void RemoveTask (int taskId)
        {
            var task = tasks.FirstOrDefault(t => t.Id == taskId);

            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        public void DisplayTasks ()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Задача: {task.Name}, Статус: {task.GetStatus()}, Исполнитель: {task.GetAssignee()}, Приоритет: {task.GetPriority()}");
            }
        }
    }
}
