using System;

namespace konstructori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Time chas = new Time(12,55,20);
            chas.Value();
            chas.PrintHour();
        }
    }
}
