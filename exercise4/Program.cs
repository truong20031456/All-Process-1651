
using System;
using System.Collections.Generic;

namespace Library_Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryCatalog library = new LibraryCatalog();

            // Add books to the catalog
            Book book1 = new Book("Introduction to C#", "John Doe", 2021, "978-1234567890", "Available");
            Book book2 = new Book("Programming Basics", "Alice Smith", 2019, "978-9876543210", "Available");
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
    }
}

namespace Library_Catalog
{
    internal class LibraryCatalog
    {
        private List<Book> librarycatalog1;

        public LibraryCatalog()
        {
            librarycatalog1 = new List<Book>();
        }

        public IReadOnlyCollection<Book> LibraryCatalog1
        {
            get { return this.librarycatalog1.AsReadOnly(); }
        }

        public void AddBook(Book book)
        {
            // Add the book to the library catalog
            librarycatalog1.Add(book);
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Library Catalog:");
            foreach (Book book in librarycatalog1)
            {
                Console.WriteLine("Book Details:");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Publication Year: {book.PublicationYear}");
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine($"Availability: {book.AvailabilityStatus}");
                Console.WriteLine("--------------");
            }
        }

        public List<Book> FindAvailableBooks(string title)
        {
            List<Book> availableBooks = new List<Book>();

            foreach (var book in LibraryCatalog1)
            {
                if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase) && book.AvailabilityStatus == "Available")
                {
                    availableBooks.Add(book);
                }
            }

            return availableBooks;
        }
    }

    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int PublicationYear { get; private set; }
        public string ISBN { get; private set; }
        public string AvailabilityStatus { get; set; }

        public Book(string title, string author, int publicationYear, string isbn, string availabilityStatus)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            ISBN = isbn;
            AvailabilityStatus = availabilityStatus;
        }

        public void Borrow()
        {
            if (AvailabilityStatus == "Available")
            {
                AvailabilityStatus = "Borrowed";
                Console.WriteLine($"{Title} by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is not available for borrowing.");
            }
        }

        public void Return()
        {
            if (AvailabilityStatus == "Borrowed")
            {
                AvailabilityStatus = "Available";
                Console.WriteLine($"{Title} by {Author} has been returned.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} was not borrowed.");
            }
        }
    }
}


