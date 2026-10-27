using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Circle
    {
        private double radius;
        public Circle()
        {
        
        }
        public Circle(double r)
        {
            radius = r;
        }
        public void Value()
        {
            Console.Write("r = ");
            radius=double.Parse(Console.ReadLine());
        }
        public double Area()
        {
            double s = (radius * radius) * Math.PI;
            Console.WriteLine($"S = {s:F2}");
            return s;
        }
    }
}
