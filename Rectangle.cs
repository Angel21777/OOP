using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Rectangle
    {
        private int a;
        private int b;
        public Rectangle()
        {
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public  void Value()
        {
            Console.Write("a =");
            a=int.Parse(Console.ReadLine());
            Console.Write("b =");
            b=int.Parse(Console.ReadLine());
        }
        public int Area()
        {
            int s = a * b;
            Console.WriteLine($"S = {s}");
            return s;
        }
    }
}
