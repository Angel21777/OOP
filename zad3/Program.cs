using System;


namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Family name: ");
            p1.FamilyName = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p1.Print();
            Console.WriteLine("--------------------");
            Person p2 = new Person("Angel", "Angelov", 20);
            Console.WriteLine();
            p2.Print();
            Console.WriteLine("--------------------");
            Person p3= new Person("Angel", "Angelov", 20);
            Console.Write("Name: ");
            p3.Name = Console.ReadLine();
            Console.Write("Family name: ");
            p3.FamilyName = Console.ReadLine();
            Console.Write("Age: ");
            p3.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p3.Print();
        }
    }
}

