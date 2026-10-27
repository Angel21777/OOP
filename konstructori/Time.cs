using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstructori
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;
        public Time (int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void Value()
        {
            Console.Write("Hour =");
            hour=int.Parse(Console.ReadLine());
            Console.Write("minute = ");
            minute=int.Parse(Console.ReadLine());
            Console.Write("seconds =");
            second=int.Parse(Console.ReadLine());
        }
        public void PrintHour()
        {
            Console.WriteLine($"Time is {hour}:{minute}:{second}");
        }
    }
}
