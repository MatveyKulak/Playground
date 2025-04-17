namespace Lesson17
{
    public class StudentsManager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Points { get; set; }

        public StudentsManager(string name, int age, int points)
        {
            Name = name;
            Age = age;
            Points = points;
        }
    }
}
