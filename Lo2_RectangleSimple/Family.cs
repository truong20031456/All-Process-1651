using Lo2_RectangleSimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Age
{

    internal class Family
    {
        private List<Person> familyMembers; // Use a List to store Person objects

        public Family()
        {
            familyMembers = new List<Person>(); // Initialize the list in the constructor
        }

        public void Add(Person member)
        {
            familyMembers.Add(member); // Add a member to the list
        }
        public void FindYoungest()
        {
            Person youngest = null;

            foreach (Person member in familyMembers)
            {
                if (youngest == null || member.Age < youngest.Age)
                {
                    youngest = member;
                }
            }

            if (youngest != null)
            {
                Console.WriteLine($"Youngest Family Member: {youngest.Name}, Age: {youngest.Age}");
            }
            else
            {
                Console.WriteLine("No family members found.");
            }
        }

        public void FindOldest()
        {
            Person oldest = null;

            foreach (Person member in familyMembers)
            {
                if (oldest == null || member.Age > oldest.Age)
                {
                    oldest = member;
                }
            }

            if (oldest != null)
            {
                Console.WriteLine($"Oldest Family Member: {oldest.Name}, Age: {oldest.Age}");
            }
            else
            {
                Console.WriteLine("No family members found.");
            }
        }


        public void Display()
        {
            Console.WriteLine("===== Family Management =====");
            foreach (Person member in familyMembers)
            {
                Console.WriteLine("Name: " + member.Name);
                Console.WriteLine("Age: " + member.Age);
                Console.WriteLine("Gender: " + member.Gender);
                Console.WriteLine();
            }
            
            
        }
       

    }
}
