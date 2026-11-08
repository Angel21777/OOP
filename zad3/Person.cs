using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Person
    {
        private string name;
        private string familyName;
        private int age;
        public Person()
        {

        }
        public Person(string name, string familyName, int age)
        {
            this.name = name;
            this.familyName = familyName;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Print()
        { 
            Console.WriteLine($"Name: {name}\nFamily Name: {familyName}\nAge: {age}");
        }
    }
}
