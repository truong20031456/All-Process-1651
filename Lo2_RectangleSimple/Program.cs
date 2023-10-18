using Age;
using Lo2_RectangleSimple;
using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace AGe


{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Family family = new Family();
            Person person1 = new Person { Name = "Join", Age = 35, Gender = "Male" };
            Person person2 = new Person { Name = "Jane", Age = 30, Gender = "Female" };
            Person person3 = new Person {Name = "Bob", Age = 10, Gender = "Male" };
            Person person4 = new Person {Name = "Alice", Age = 7, Gender = "Female" };

            family.Add(person1);
            family.Add(person2);
            family.Add(person3);
            family.Add(person4);
            
            family.Display();
            family.FindYoungest();
            family.FindOldest();
           






        }
    }
}