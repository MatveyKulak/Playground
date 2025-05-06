namespace Lesson18.PersonManagment
{
    public class Student : Person
    {
        public int CourseNumber { get; }
        public double AvgGrade { get; }

        public Student(int id, string name, int age, int courseNumber, double avgGrade)
            : base(id, name, age)
        {
            CourseNumber = courseNumber;
            AvgGrade = avgGrade;
        }

        public override string ToString()
        {
            return base.ToString() + $", {CourseNumber}, {AvgGrade}";
        }
    }
}
