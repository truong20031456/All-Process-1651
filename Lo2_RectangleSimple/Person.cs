using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo2_RectangleSimple
{
    internal class Person
    {
        private string name;
        private int age;
        private string gender;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}
