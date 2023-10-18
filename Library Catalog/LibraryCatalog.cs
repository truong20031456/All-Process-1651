using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        public void RemoveBook(Book book)
        {
            librarycatalog1.Remove(book);
        }
        public void DisplayAllBooks() {
            foreach (Book book in librarycatalog1)
            {
                Console.WriteLine(book);
            }
        
  }
        public List<Book> FindAvailableBooks(string title)//introduce c#
        {
            List<Book> availableBooks1 = new List<Book>();

            foreach (var book in LibraryCatalog1)
            {
                if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase) && book.Availabilitystatus == "Available")
                {
                    availableBooks1.Add(book);
                }
            }

            return availableBooks1;
        }




    }
}
