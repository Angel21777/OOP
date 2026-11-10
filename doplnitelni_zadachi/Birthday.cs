using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doplnitelni_zadachi
{
    internal class Birthday
    {
        private int day;
        private int month;
        private int year;
        private string name;
        public Birthday()//за да може да взема името в празния конструктор нулираме ден месец година и четем името
        {
            this.day = 0;
            this.month = 0;
            this.year = 0;
            this.name = Console.ReadLine();
        }
        public Birthday(int day,int month,int year,string name)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.name = Console.ReadLine();
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void Value()
        {
            Console.Write("day:");
            day = int.Parse(Console.ReadLine());
            Console.Write("month:");
            month = int.Parse(Console.ReadLine());
            Console.Write("year:");
            year = int.Parse(Console.ReadLine());
        }
        public string getName()
        {
            return name;
        }
    }
}
