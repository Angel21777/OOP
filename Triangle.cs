using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Value()
        {
            Console.Write("a =");
            a=double.Parse(Console.ReadLine());
            Console.Write("b =");
            b=double.Parse(Console.ReadLine());
            Console.Write("c =");
            c=double.Parse(Console.ReadLine());
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine($"S = {s:F2}");
            return s;
        }
    }
}
