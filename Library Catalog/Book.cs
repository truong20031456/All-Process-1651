using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Catalog
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _publiccationyear;
        private string _ibsn;
        private string _availabilitystatus;

        public Book(string Title, string Author, int Publicationyear, string Inbs, string Availabilitystatus)
        {
            this._title = Title;
            this._author = Author;
            this._publiccationyear = Publicationyear;
            this._ibsn = Inbs;
            this._availabilitystatus = Availabilitystatus;

        }
        public string Title
        {
            get { return _title; }
            private set
            {
                if (_title == null)
                {
                    throw new ArgumentException("....");
                }
                _title = value;

            }
        }
        public string Author
        {
            get { return _author; }
            private set
            {
                if (_author == null)
                {
                    throw new ArgumentException("....");
                }
                _author = value;
            }
        }
        public int Publiccationyear
        {
            get { return _publiccationyear; }
            private set
            {
                _publiccationyear = value;
            }
        }
        public string Ibsn
        {
            get { return _ibsn; }
            private set
            {
                if (Ibsn == null)
                {
                    throw new ArgumentException(".....");
                }
                Ibsn = value;
            }

        }
        public string Availabilitystatus
        {
            get { return _availabilitystatus; }
            private set
            {
                if (_availabilitystatus == null)
                { throw new ArgumentException("..."); }
                _availabilitystatus = value;    
            }
        }
       
        public void Borrow()
        {
            if (this.Availabilitystatus == "Available")
            {
                this.Availabilitystatus = "Borrowed";
                Console.WriteLine($"{Title} by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is not available for borrowing.");
            }
        }
        public void Return()
        {
            if (this.Availabilitystatus == "Borrow")
            {
                Console.WriteLine($"{Title} by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} has been return.");
            }
        }


    }
}


    

