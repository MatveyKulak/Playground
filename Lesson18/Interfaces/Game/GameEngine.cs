namespace Lesson18.Interfaces.Game
{
    public class GameEngine
    {
        public static void Play ()
        {
            Console.CursorVisible = false;

            List<IDrawable> drawables = [];
            List<IMovable> movables = new();

            var circle = new Circle(10, 5, 2);
            var square = new Square(20, 8, 3);

            drawables.Add(circle);
            drawables.Add(square);

            movables.Add(circle);
            movables.Add(square);

            while (true)
            {
                Console.Clear();

                foreach (var drawable in drawables)
                {
                    drawable.Draw();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Нажми любую клавишу для движения, Esc — выход.");

                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                foreach (var movable in movables)
                {
                    movable.Move(1, 1);
                }

                Thread.Sleep(200);
            }

            Console.CursorVisible = true;
        }
    }
}
