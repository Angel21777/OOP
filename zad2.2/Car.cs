using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2._2
{
    internal class Car
    {
        private string model;
        private string color;
        private int regNumber;
        public Car()
        {
        }
        public Car(string model, string color, int regNumber)
        {
            this.model = model;
            this.color = color;
            this.regNumber = regNumber;
        }
        public string Model//svoistvo
        {
            get { return model; }
            set { model = value; }
        }
        public string Color//svoistvo
        {
            get { return color; }
            set { color = value; }
        }
        public int RegNumber//svoistvo
        {
            get { return regNumber; }
            set { regNumber = value; }
        }
        public string Info
        {
            get { return $"Modela na kolata e {Model},{Color} cvqt i s registracionen nomer {RegNumber}"; }
        }
    }
}
