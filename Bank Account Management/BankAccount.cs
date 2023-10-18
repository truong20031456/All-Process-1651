using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management
{
    internal class BankAccount
    {
        private string _lastName;
        private string _firstName;
        private decimal _balance;

        /*public string LastName
        {
            get { return _lastName; }
            private set
            {
                if (_lastName == null)
                {
                    throw new ArgumentException(" LastName is null");
                }
                _lastName = value;
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            private set
            {
                if (_firstName == null)
                {
                    throw new ArgumentException(" Firstname is null");
                }
                _firstName = value;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
            private set 
            {
                if (_balance <  0)
                {
                    throw new ArgumentException(" Balance must be > 0");
                }
                _balance = value;
            }
        }*/
        public string LastName
        {
            get { return _lastName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "LastName cannot be null");
                }
                _lastName = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "FirstName cannot be null");
                }
                _firstName = value;
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance must be >= 0");
                }
                _balance = value;
            }
        }

        public BankAccount(string firstname, string lastname, decimal balance)
        {
            _firstName = firstname; // Use the property to validate input
            _lastName = lastname;   // Use the property to validate input
            _balance = balance;     // Use the property to validate input
        }

        /*public void Withdraw( decimal amount)
        {
            if(_balance < amount || amount ==1)
            {
                throw new ArgumentException(" Invalid Value");
            }
            _balance -= amount;
            Console.WriteLine($"your balance is {amount}");
        }*/
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid withdrawal amount. Amount must be greater than 0.");
            }

            if (_balance < amount)
            {
                throw new InvalidOperationException("Insufficient balance for withdrawal.");
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Your balance is now {_balance}");
           
        }

        public void Deposit( decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Your deposit do not negative");
            }
            _balance += amount;
            Console.WriteLine($"Deposit {amount}. Your balance is now {_balance}");
        }



    }
}
