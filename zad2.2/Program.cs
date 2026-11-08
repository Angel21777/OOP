using System;



namespace zad2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Console.Write("Model:");
            c1.Model = Console.ReadLine();
            Console.Write("Cvqt:");
            c1.Color = Console.ReadLine();
            Console.Write("Godina:");
            c1.RegNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(c1.Info);
        }
    }
}

