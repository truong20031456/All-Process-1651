using System;
using System.Collections.Generic;

namespace FindOldestAndYoungest
{
    internal class Program
    {
        class Person1
        {
            private string name;
            private int age;
            private string gender;
            public string Name { get { return name; } set { name = value; } }
            public int Age { get { return age; } set { age = value; } }
            public string Gender { get { return gender; } set { gender = value; } }

            public Person1(string name, int age, string gender)
            {
                this.Name = name;    // Assign the parameter 'name' to the 'Name' property
                this.Age = age;      // Assign the parameter 'age' to the 'Age' property
                this.Gender = gender;// Assign the parameter 'gender' to the 'Gender' property
            }
        }

        class Family
        {
            List<Person1> list1; // Create a list of Person1 objects

            public Family() { list1 = new List<Person1>(); }

            // Add a person to the family
            public void Add(Person1 person)
            {
                list1.Add(person);
            }

            // Find the oldest person in the family
            public void FindOldest()
            {
                Person1 oldest = null;
                foreach (Person1 person in list1)
                {
                    if (oldest == null || person.Age > oldest.Age)
                    {
                        oldest = person;
                    }
                }

                if (oldest != null)
                {
                    Console.WriteLine($"The oldest person is {oldest.Name}");
                }
            }

            // Find the youngest person in the family
            public void FindYoungest()
            {
                Person1 youngest = null;
                foreach (Person1 person in list1)
                {
                    if (youngest == null || person.Age < youngest.Age)
                    {
                        youngest = person;
                    }
                }

                if (youngest != null)
                {
                    Console.WriteLine($"The youngest person is {youngest.Name}");
                }
            }
        }

        static void Main(string[] args)
        {
            Family f = new Family();
            Person1 person11 = new Person1 { Name = "John", Age = 35, Gender = "Male" };
            Person1 person2 = new Person1 { Name = "Jane", Age = 30, Gender = "Female" };
            Person1 person3 = new Person1 { Name = "Bob", Age = 10, Gender = "Male" };
            Person1 person4 = new Person1 { Name = "Alice", Age = 7, Gender = "Female" };

            f.Add(person11);
            f.Add(person2);
            f.Add(person3);
            f.Add(person4);

            f.FindYoungest();
            f.FindOldest();
        }
    }
}
