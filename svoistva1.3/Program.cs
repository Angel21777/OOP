
using System;

namespace svoistva1._3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZAD 1.3 Dobavqne na obrabotka koi obekt e nai golqm
            Rectangle p1 = new Rectangle();
            Console.Write("a = ");
            p1.A = int.Parse(Console.ReadLine());// Vavejdane direktno ot klaviaturata
            Console.Write("b = ");
            p1.B = int.Parse(Console.ReadLine());
            Console.WriteLine($"1 - area is {p1.Area}");
            Rectangle p2 = new Rectangle(2, 8);//Konstruktora se izvikva 1 pat v rezultat vrashta instanciqta na obekta(adres)
                                               //poleto se prezapisva 4rez svoistvo
            p2.A = 10;                      // dostap direktno do svoistvo i zadavane na stoinost
            p2.B = 5;
            Console.WriteLine($"2 - area is {p2.Area}");// vzimat se prezapisanite stoinosti na tezi poleta
            Rectangle p3 = new Rectangle(2, 8);
            Console.WriteLine($"3 - area is {p3.Area}");
            Console.WriteLine("-----------------------");
            if (p1.Area>p2.Area && p1.Area>p3.Area)
            {
                Console.WriteLine($"Pravoagalnik 1 = {p1.Area} e s nai golqma obikolka");
            }
            else if (p2.Area > p3.Area)
            {
                Console.WriteLine($"Pravoagalnik 2 = {p2.Area} e s nai golqma obikolka");
            }
            else
            {
                Console.WriteLine($"Pravoagalnik 3 = {p3.Area} e s nai golqma obikolka");
            }
        }
    }
}
