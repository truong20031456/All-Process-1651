using Library_Catalog;

static void Main(string[] args)
{
    LibraryCatalog library = new LibraryCatalog();

    // Add books to the catalog
    Book book1 = new Book("Introduction to C#", "John Doe", 2021, "978-1234567890", "Available");
    Book book2 = new Book("Programming Basics", "Alice Smith", 2019, "978-9876543210", "Borrow");
    Book book3 = new Book("Data Structures and Algorithms", "Bob Johnson", 2020, "978-5555555555", "Available");

    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3); // add more books if needed

    // Borrow and return books
    book1.Borrow();
    book2.Borrow();
    book2.Return();

    // Display available books
    List<Book> availableBooks = library.FindAvailableBooks("Introduction to C#");
    Console.WriteLine("Available Books:");
    foreach (var book in availableBooks)
    {
        Console.WriteLine($"{book.Title} by {book.Author}");
    }

    // Display all books in the catalog
    library.DisplayAllBooks();
}
