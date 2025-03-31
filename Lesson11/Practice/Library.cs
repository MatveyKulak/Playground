using Lesson11.Models;

namespace Lesson11.Practice
{
    public static class Library
    {
        private static Dictionary<int, Book> books = new Dictionary<int, Book>
        {
            { 1, new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997, 223) },
            { 2, new Book("Harry Potter and the Chamber of Secrets", "J. K. Rowling", 1998, 251) },
            { 3, new Book("Harry Potter and the Prisoner of Azkaban", "Rowling", 1999, 317) },
            { 4, new Book("Harry Potter and the Goblet of Fire", "J. K. Rowling", 2000, 636) },
            { 5, new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling", 2003, 766) },
            { 6, new Book("Harry Potter and the Half-Blood Prince", "J. K. Rowling", 2005, 607) },
            { 7, new Book("Harry Potter and the Deathly Hallows", "Rowling", 2007, 607) }
        };

        public static void BooksByAuthor()
        {
            var result = books.Values.Where(b => b.Autor.Contains("Rowling")).ToList();

            foreach (var book in result)
            {
                Console.WriteLine($"{book.Title}, {book.Autor}, {book.Year}, {book.Pages}");
            }
        }

        public static void BookCount()
        {
            Console.WriteLine(books.Count);
        }

        public static void FindMaxPages()
        {
            Book result = books.Values.OrderByDescending(b => b.Pages).FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine($"{result.Title}, {result.Autor}, {result.Year}, {result.Pages}");
            }
        }

        public static void BooksByYear()
        {
            var result = books.Values.Where(b => b.Year > 2000).Select(b => b.Title).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}