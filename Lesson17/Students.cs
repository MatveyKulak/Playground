namespace Lesson17
{
    public class Students
    {
        private List<Students> students = new List<Students>
        {
            new Students("Виктория", 17, 60),
            new Students("Артём", 18, 92),
            new Students("Роман", 19, 34)
        };
        public string Name { get; set; }
        public int Age { get; set; }
        public double Points { get; set; }

        public Students(string name, int age, int points)
        {
            Name = name;
            Age = age;
            Points = points;
        }
        public void OrderByLow()
        {
            var low = students.OrderByDescending(p => p.Points);
        }
        public void MoreThen70()
        {
            var seventh = students.Where(p => p.Points > 70);
        }
        public void OnlyNames()
        {
            var list = students.Select(p => p.Name).ToList();
        }
        public void MiddlePoints()
        {
            var middle = students.Average(p => p.Points);
        }
        public void Counting()
        {
            var count = students.Count(p => p.Points > students.Average(p => p.Points));
        }
    }
}
