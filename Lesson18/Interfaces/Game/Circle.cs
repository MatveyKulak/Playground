namespace Lesson18.Interfaces.Game
{
    public class Circle : IDrawable, IMovable
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; }

        public Circle (int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw ()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }

        public void Move (int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
