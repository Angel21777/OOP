using System;


namespace Km
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Km/h to m/s converter");
            Console.WriteLine("Opcii\nkm/h to m/s - 1\nm/s to km/h - 2");
            Console.Write("Izberete opcija:");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Vavedete km/h:");
                    double kmh = double.Parse(Console.ReadLine());
                    double ms = kmh / 3.6;
                    Console.WriteLine($"{kmh} km/h = {ms} m/s");
                    break;
                case 2:
                    Console.Write("Vavedete m/s:");
                    double ms2 = double.Parse(Console.ReadLine());
                    double kmh2 = ms2 * 3.6;
                    Console.WriteLine($"{ms2} m/s = {kmh2} km/h");
                    break;
                default:
                    break;
            }
        }
    }
}

