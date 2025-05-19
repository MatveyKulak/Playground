namespace Lesson_19.Events
{
    class Button
    {
        public object Name { get; set; }

        public event EventHandler? OnClickEvent;

        public void Click ()
        {
            Console.WriteLine("Кнопка нажата");
            OnClickEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
