using System;

namespace doplnitelni_zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се създаде клас Birthday.С полета day,monyh,year,всяко едно от полетата съдържа свойство за четене и запис
            //Класът съдържа два конструктора (нулиращ и с параметри). Да се създаде метод който да въвежда стойностите на 
            //полетата и метод който да отпечатва следната информация "My birthday is: 12:05:1992g.", чрд Пешо
            //При стартиране курсора мига и чака да напиша името
            Birthday pesho=new Birthday();
            pesho.Value();
            Console.WriteLine($"Your birthday is:{pesho.Day}.{pesho.Month}.{pesho.Year}g.");
            Console.WriteLine($"Happy birthday {pesho.getName()}");

        }
    }
}
