using System;

namespace Svoistva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pravoagalnik p1=new Pravoagalnik();//Konstruktor bez parametri
            p1.Value();
            Console.WriteLine($"Area is {p1.Area}");
            Pravoagalnik p2 = new Pravoagalnik(2,5);//Konstruktor s parametri
            p2.Value();
            Console.WriteLine($"Area is {p2.Area}");
            Pravoagalnik p3 = new Pravoagalnik(10,2);//Konstruktor s parametri i bez vavejdane izpolzvame svoistovo
            Console.WriteLine("Samo predvaritelno zadadenite parametri ot konstruktora");
            Console.WriteLine($"The area is {p3.Area}");
            

            
        }
    }
}
