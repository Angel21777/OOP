using System;
namespace Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius - Fahrenheit Converter");
            Console.WriteLine("Opcii:\nCelsius to Fahrenheit - 1\nFahrenheit to Celsius - 2");
            Console.Write("Izberete opciq:");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.Write("Vavedete gradusi Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 1.8) + 32;
                    Console.WriteLine($"{celsius:f}°C = {fahrenheit:f}°F"); 
                    break;
                case 2:
                    Console.Write("Vavedete gradusi Fahrenheit:");
                    double fahrenheit2 = double.Parse(Console.ReadLine());
                    double celsius2 = (fahrenheit2 - 32) / 1.8;
                    Console.WriteLine($"{fahrenheit2:f}°F = {celsius2:f}°C");
                    break;
                default:
                    break;
            }





        }
    }
}