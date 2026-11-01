using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kniga
{
    internal class Kniga
    {
        private string avtor;
        private string zaglavie;
        private string izdatelstvo;
        private int godina;
        public Kniga(string avtor, string zaglavie, string izdatelstvo, int godina)
        {
            this.avtor = avtor;
            this.zaglavie = zaglavie;
            this.izdatelstvo = izdatelstvo;
            this.godina = godina;
        }
        public void ValueKniga()
        {
            Console.Write("Avtor - ");
            avtor = string.Format("{0}", Console.ReadLine());
            Console.Write("Zaglavie - ");
            zaglavie = string.Format("{0}", Console.ReadLine());
            Console.Write("Izdatelstvo - ");
            izdatelstvo = string.Format("{0}", Console.ReadLine());
            Console.Write("Godina -");
            godina = int.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Zaglavieto na knigata e {zaglavie} s avtor {avtor} na izdatelstvo {izdatelstvo}.\nKnigata e napisana prez {godina} godina");
        }
    }
}
