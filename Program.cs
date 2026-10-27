using System;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area Rectangle");
            Console.WriteLine("Sazfavane na obekt s konstruktor bez parametri");
            Rectangle r1 = new Rectangle();
            r1.Value();
            r1.Area();
            Console.WriteLine("Sazdavane na obekt s konstruktor s parametri");
            Rectangle r2= new Rectangle(2,1);
            r2.Value();
            r2.Area();
            Console.WriteLine("----------------------------\nArea Circle");
            Console.WriteLine("Sazfavane na obekt s konstruktor bez parametri");
            Circle c1 = new Circle();
            c1.Value();
            c1.Area();
            Console.WriteLine("Sazdavane na obekt s konstruktor s parametri");
            Circle c2 = new Circle(1);
            c2.Value();
            c2.Area();
            Console.WriteLine("----------------------------\nArea Triangle");
            Console.WriteLine("Sazfavane na obekt s konstruktor bez parametri");
            Triangle t1 = new Triangle();
            t1.Value();
            t1.Area();
            Console.WriteLine("Sazdavane na obekt s konstruktor s parametri");
            Triangle t2 = new Triangle();
            t2.Value();
            t2.Area();
        }
    }
}
