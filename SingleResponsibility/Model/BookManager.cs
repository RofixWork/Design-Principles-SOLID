namespace SingleResponsibility.Model
{
    public class BookManager
    {
        private List<Book> Books { get; set; } = new List<Book>();
        private static bool IsEmptyList(List<Book> books) => !books.Any();
        public void AddBook(Book book)
        {
            if (book is not null)
                Books.Add(book);
        }

        public void AddBooks(List<Book> books)
        {
            if (CheckList(books, "This List is Empty."))
                return;

            Books.AddRange(books);
        }

        public Book? FindBook(int id)
        {
  
            var book = Books.FirstOrDefault(b => b.Id.Equals(id));
            return book;
        }

        public void ShowAllBooks()
        {
            if (CheckList(Books, "Not exist any Book in the List..."))
                return;

            Print(Books);
        }

        private static void Print(List<Book> books)
        {
            Console.WriteLine("*****************************************");
            foreach (var book in books)
            {
                Console.WriteLine(book);

                if(books.Count > 1) Console.WriteLine("---------------------");
            }
            Console.WriteLine("*****************************************");
        }

        private static bool CheckList(List<Book> books, string message)
        {
            if (IsEmptyList(books))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Gray;
                return true;
            }
            return false;
        }
    }
}
