using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car c1= new Car();
            c1.Model=Console.ReadLine();
            c1.Color=Console.ReadLine();
            c1.RegNumber=int.Parse(Console.ReadLine());
            c1.Print();
        }
    }
}
