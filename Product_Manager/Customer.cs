using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    internal class Customer
    {
        private int CustomerId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int GetCustomerId()
        {
            return CustomerId;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }


    }
}
        

    
