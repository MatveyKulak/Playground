public class Lecture
{
    public string Theme;
    public int Duration;

    public Lecture() : this("Undefined")
    {
        Console.WriteLine($"{Theme}, {Duration}");
    }

    public Lecture(string theme) : this(theme, 60)
    {
        Console.WriteLine($"{Theme}, {Duration}");
    }

    public Lecture(string theme, int duration)
    {
        Theme = theme;
        Duration = duration;
        Console.WriteLine($"{Theme}, {Duration}");
    }
}