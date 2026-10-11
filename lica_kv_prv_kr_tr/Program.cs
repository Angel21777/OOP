using System;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prilojenie presmqtashto lica\nKvadrat - 1\nPravoagalnik - 2\nKrag - 3\nTriagalnik - 4");
            Console.Write("Vavedete nomera na figurata chieto lice iskate da presmetnete:");
            int figure = int.Parse(Console.ReadLine());

            switch (figure)
            {
                case 1:
                    Console.Write("Vavedete strana a:");
                    int a = int.Parse(Console.ReadLine());
                    double sKvadrat = a * a;
                    Console.WriteLine($"S = {sKvadrat}");
                    break;
                case 2:
                    Console.Write("LVavedete strana a:");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("Vavedete strana b:");
                    int b1 = int.Parse(Console.ReadLine());
                    double sPravoagalnik = a1 * b1;
                    Console.WriteLine($"S = {sPravoagalnik}");
                    break;
                case 3:
                    Console.Write("Vavedete radius r:");
                    int r = int.Parse(Console.ReadLine());
                    double sKrag = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"S = {sKrag:f2}");
                    break;
                case 4:
                    Console.Write("Vavedete strana a:");
                    int a2 = int.Parse(Console.ReadLine());
                    Console.Write("Vavedete strana b:");
                    int b2 = int.Parse(Console.ReadLine());
                    Console.Write("Vavedete strana c:");
                    int c2 = int.Parse(Console.ReadLine());
                    if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
                    {
                        double p = (a2 + b2 + c2) / 2;
                        double sTriagalnik = Math.Sqrt(p * (p - a2) * (p - b2) * (p - c2));
                        Console.WriteLine($"S = {sTriagalnik:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Tova ne sa strani na triagalnik");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}