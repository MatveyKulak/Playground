namespace Lesson18.Interfaces.Game
{
    public class Square : IDrawable, IMovable
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Size { get; }

        public Square (int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;
        }

        public void Draw ()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("#");
        }

        public void Move (int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}