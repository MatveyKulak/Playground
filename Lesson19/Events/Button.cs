namespace Lesson_19.Events
{
    class Button
    {
        public event EventHandler? Clicked;

        public void Click ()
        {
            Console.WriteLine("Кнопка нажата");
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
