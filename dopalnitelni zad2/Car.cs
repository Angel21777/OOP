using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopalnitelni_zad2
{
    internal class Car
    {
        private int power;
        private string adress;
        private int year;
        private int eco;
        public Car()
        { 
            this.power = 0;
            this.adress = "";
            this.year = 0;
            this.eco = 0;
        }
        public Car(int power, string adress, int year,int eco)
        {
            this.power = power;
            this.adress = adress;
            this.year = year;
            this.eco = eco;
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public int Year
        { 
            get { return year; }
            set { year = value; }
        }
        public int Eco
        {
            get { return eco; }
            set { eco = value; }
        }
        public void Value()
        {
            Console.Write("Adress: ");
            adress =Console.ReadLine();
            Console.Write("Power: ");
            power = int.Parse(Console.ReadLine());
            Console.WriteLine("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Eco:");
            eco = int.Parse(Console.ReadLine());
        }
    }
}
