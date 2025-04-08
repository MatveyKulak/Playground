namespace Lesson13.Practice
{
    public class Library
    {
        private List<Book> books;
        public IReadOnlyList<Book> Books => books.AsReadOnly();

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public double GetTotalPrice()
        {
            double total = 0;

            foreach (var book in books)
            {
                total += book.Price;
            }

            return total;
        }

        public void DisplayLibraryInfo()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.GetBookInfo()}");
                Console.WriteLine($"{book.Author.GetAuthorInfo()}");
            }
        }
    }

}
