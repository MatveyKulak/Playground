namespace Lesson17
{
    public class Students
    {
        private List<StudentsManager> students = new List<StudentsManager>
        {
            new StudentsManager("Виктория", 17, 60),
            new StudentsManager("Артём", 18, 92),
            new StudentsManager("Роман", 19, 34)
        };

        public void OrderByLow()
        {
            var low = students.OrderByDescending(p => p.Points);
        }
        public void MoreThan70()
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
