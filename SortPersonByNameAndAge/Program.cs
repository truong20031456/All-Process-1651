namespace SortPersonByNameAndAge
{
    internal class Program
    {
        public class Person
        {
            private string firstName;
            private string lastname;
            private int age;
            public string FirstName { get { return firstName; } private set { firstName = value; } }
            public string LastName { get { return lastname; } private set { lastname = value; } }
            public int Age { get { return age; } private set { age = value; } }
            
            public Person( string firstName, string lastname, int age) {
               FirstName = firstName;
                LastName = lastname;
                Age = age;
            }
            public override string ToString()
            {
                return $"{FirstName}{LastName} is {Age} years old.";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Join","Handsome",17);
            string person1 = person.ToString();
           Console.WriteLine(person1);
            
        }
    }
}