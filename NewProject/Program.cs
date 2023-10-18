using System.Security.Cryptography.X509Certificates;

namespace NewProject
{
    internal class Program
    {
        class Person
        {
            private string firstname;
            private string lastname;
            private int age;
            private decimal salary;

            public string Firstname
            {
                get { return firstname; }
                private set
                {
                    if (value.Length < 3)
                    {
                        throw new ArgumentException("...");

                    }
                    Firstname = value;
                }
            }

            public string Lastname { get { return lastname; }  private set { if (value.Length < 3) 
                    {
                    throw new ArgumentException("...");

                    }
            this.lastname = value;
                } }
            public int Age
            {
                get { return age; }
                private set
                {
                    if (age < 1)
                        throw new ArgumentException("...");
                    this.age = value;
                }
            }

            public decimal Salary
            {
                get { return salary; }
                set
                {
                    if (value < 460)
                        throw new ArgumentException("...");
                    this.salary = value;
                }
            }
            public Person(string firstName, string lastName,
              int age, decimal salary)
            {
                this.Firstname = firstName;
                this.Lastname = lastName;
                this.Age = age;
                this.Salary = salary;
            }

        }
        
        







        static void Main(string[] args)
        {
            var people = new List<Person>();
            var line = int.Parse(Console.ReadLine());
            for(int i = 1; i <= line; i++) 
            {
                var cmdArgs = Console.ReadLine().Split("");
                var people =  new Person(cmdArgs[0]), cmdArgs[1],int.Parse(cmdArgs[2]),decimal.Parse(cmdArgs[3]);   
            }
            
    }
}
