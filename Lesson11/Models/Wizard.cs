namespace Lesson11.Models
{
    public class Wizard
    {
        public string Name { get; set; }
        public string School { get; set; }
        public int PowerLevel { get; set; }

        public Wizard(string name, string school, int power)
        {
            Name = name;
            School = school;
            PowerLevel = power;
        }
    }
}