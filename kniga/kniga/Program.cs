using System;

namespace kniga
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Kniga k1 = new Kniga("Author", "Title", "Publisher", 2024);
        k1.ValueKniga();
        k1.Print();
        }
    }
}