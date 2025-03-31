namespace Lesson11.Models
{
    public class Book
    {
        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Autor = author;
            Year = year;
            Pages = pages;
        }

        public string Title { get; set; }
        public string Autor { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
    }
}
