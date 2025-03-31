using Lesson11.Models;

namespace Lesson11.Practice
{
    public static class MagicSchool
    {
        private static List<Wizard> wizards = new List<Wizard>
        {
            new Wizard("Albus Dumbledore", "Hogwarts", 100),
            new Wizard("Severus Snape", "Hogwarts", 85),
            new Wizard("Minerva McGonagall", "Hogwarts", 90),
            new Wizard("Voldemort", "Dark Arts", 98),
            new Wizard("Sirius Black", "Hogwarts", 80),
            new Wizard("Bellatrix Lestrange", "Dark Arts", 95),
            new Wizard("Harry Potter", "Hogwarts", 89),
            new Wizard("Hermione Granger", "Hogwarts", 92),
            new Wizard("Ron Weasley", "Hogwarts", 70),
            new Wizard("Gellert Grindelwald", "Dark Arts", 97),
        };

        public static void AvgSchoolPower()
        {
            var result = wizards
                .GroupBy(w => w.School)
                .Select(g => new { SchoolName = g.Key, AvgPower = g.Average(w => w.PowerLevel)});

            foreach (var school in result)
            {
                Console.WriteLine($"Школа {school.SchoolName}, Сила {school.AvgPower}");
            }
        }

        public static void StrongestWizard() 
        {
            var result = wizards.OrderBy(w => w.PowerLevel).Last();

            Console.WriteLine($"{result.Name}, {result.School}, {result.PowerLevel}");
        }

        public static void PercentInSchool()
        {
            var result = wizards
                .GroupBy(w => w.School)
                .Select( g => new { Name = g.Key, Percentege = (double)g.Count() / wizards.Count * 100 });

            foreach (var school in result)
            {
                Console.WriteLine($"{school.Name}, {school.Percentege:F2}");
            }
        }

        public static void SumPowerBySchool()
        {
            var result = wizards
                .GroupBy(w => w.School)
                .Select(w => new { SchoolName = w.Key, TotalPower = w.Sum(w => w.PowerLevel) });

            foreach (var school in result)
            {
                Console.WriteLine($"{school.SchoolName}, {school.TotalPower}");
            }
        }

        public static void MaxPowerSchool()
        {
            var result = wizards
                .GroupBy(w => w.School)
                .Select(g => new { SchoolName = g.Key, AvgPower = g.Average(w => w.PowerLevel) })
                .OrderBy(a => a.AvgPower)
                .Last();

            Console.WriteLine($"Школа {result.SchoolName}, Сила {result.AvgPower} ");
        }
    }
}
