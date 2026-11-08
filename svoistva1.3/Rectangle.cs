using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svoistva1._3
{
    internal class Rectangle
    {
        private int a;
        private int b;
        public Rectangle()
        {
            this.a = 0;
            this.b = 0;
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Area
        {
            get { return (2 * a) + (2 * b); }
        }
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
  
    }
}
