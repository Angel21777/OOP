using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svoistva
{
    internal class Pravoagalnik
    {
        private int a;
        private int b;
        public Pravoagalnik()
        {
            this.a = 0;
            this.b = 0;
        }
        public Pravoagalnik(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Area
        {
            get { return (2 * a) + (2 * b); }
        }
        public void Value()
        {
            Console.Write("a = ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b=int.Parse(Console.ReadLine());
        }
    }
}
