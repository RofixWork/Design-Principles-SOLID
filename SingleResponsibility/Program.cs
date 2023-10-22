
using SingleResponsibility.Model;

var bookManager = new BookManager();

//bookManager.AddBook(new Book(1, "Book 1", 13, "bla bla bla bla", Convert.ToDateTime("2022-01-23"), 1));

List<Book> books = new ()
{
    new Book(1, "Book 1", 13, "bla bla bla bla", Convert.ToDateTime("2022-01-23")),
    new Book(2, "Book 2", 14, "bla bla bla bla", Convert.ToDateTime("2022-12-01")),
    new Book(3, "Book 3", 34, "bla bla bla bla", Convert.ToDateTime("2022-11-23")),
    new Book(4, "Book 4", 32, "bla bla bla bla", Convert.ToDateTime("2023-07-23")),
};
bookManager.AddBooks(books);
bookManager.ShowAllBooks();
//Console.WriteLine("Enter Book Id here: ");
//int id = Convert.ToInt32(Console.ReadLine());
//var findBook = bookManager.FindBook(id);
//Console.Clear();
//if(findBook is null)
//    Console.WriteLine("Not exist");
//else Console.WriteLine(findBook);
