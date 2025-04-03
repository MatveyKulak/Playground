namespace Lesson12
{
    public class CurriculumVitae
    {
        public const int MaxDescriptionLength = 1000;

        public string FullName { get; set; }
        public string ContactInfo { get; set; }
        public string Summary { get; set; }
        public int YearsOfExperience { get; set; }
        public ConsoleColor TextColor { get; private set; }

        public List<string> Skills { get; set; }

        public List<string> WorkExperience { get; set; }

        public CurriculumVitae()
        {
            FullName = string.Empty;
            ContactInfo = string.Empty;
            Summary = string.Empty;
            YearsOfExperience = 0;
            Skills = new List<string>();
            WorkExperience = new List<string>();
            TextColor = ConsoleColor.Green;
        }

        public CurriculumVitae(string fullName, string contactInfo, int yearsOfExperience)
        {
            FullName = fullName;
            ContactInfo = contactInfo;
            YearsOfExperience = yearsOfExperience;
            Skills = new List<string>();
            WorkExperience = new List<string>();
        }

        public void PrintResume()
        {
            Console.ForegroundColor = TextColor;
            Console.WriteLine("Резюме");
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Контактная информация: {ContactInfo}");
            Console.WriteLine($"Опыт работы (лет): {YearsOfExperience}");
            Console.WriteLine($"Краткое описание: {Summary}");

            Console.WriteLine("Навыки:");
            foreach (var skill in Skills)
            {
                Console.WriteLine($"{skill}");
            }

            Console.WriteLine("Опыт работы:");
            foreach (var job in WorkExperience)
            {
                Console.WriteLine($"{job}");
            }
        }

        public void FillResume(string summary)
        {
            if (summary.Length > MaxDescriptionLength)
            {
                Console.WriteLine("Краткая информация о себе не должна превышать 1000 символов");
            }
            else
            {
                Summary = summary;
            }
        }

        public void CalculateExperience(int startYear)
        {
            if (startYear < 0 || startYear > DateTime.Now.Year)
            {
                Console.WriteLine("Некорректный год начала работы.");
                return;
            }

            YearsOfExperience = DateTime.Now.Year - startYear;
        }

        public void ChangeTextColor(ConsoleColor color)
        {
            TextColor = color;
        }

        public void AddSkill(string skill)
        {
            if (string.IsNullOrWhiteSpace(skill))
            {
                Console.WriteLine("Навык не может быть пустым.");
                return;
            }

            if (!Skills.Contains(skill))
            {
                Skills.Add(skill);
            }
        }

        public void AddWorkExperience(string job)
        {
            if (string.IsNullOrWhiteSpace(job))
            {
                Console.WriteLine("Работа не может быть пустой.");
                return;
            }

            if (!WorkExperience.Contains(job))
            {
                WorkExperience.Add(job);
            }
        }

        public void RemoveSkill(string skill)
        {
            Skills.Remove(skill);
        }

        public void RemoveWorkExperience(string job)
        {
            WorkExperience.Remove(job);
        }

        public void ClearResume()
        {
            FullName = string.Empty;
            ContactInfo = string.Empty;
            Summary = string.Empty;
            YearsOfExperience = 0;
            Skills.Clear();
            WorkExperience.Clear();
        }

        public void UpdateContactInfo(string newContactInfo)
        {
            if (string.IsNullOrWhiteSpace(newContactInfo))
            {
                Console.WriteLine("Контактная информация не может быть пустой.");
                return;
            }

            ContactInfo = newContactInfo;
        }
    }
}
