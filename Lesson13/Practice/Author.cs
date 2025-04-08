namespace Lesson13.Practice
{
    public class Author
    {
        public string Name { get; set; }
        private int birthYear;

        public int BirthYear
        {
            get => birthYear;

            set
            {
                if (value < 0 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Некорректный год!");
                }

                birthYear = value;
            }
        }

        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        public string GetAuthorInfo()
        {
            return $"{Name} (род. {BirthYear} г.)";
        }
    }
}
