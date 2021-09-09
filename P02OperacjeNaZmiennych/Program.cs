using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;

            a = a + 1;
            // + , - , * , / 

            int b = 10 / 3;

            Console.WriteLine(b);

            double c0 = 10;

            double c = c0 / 3;

            Console.WriteLine(c);


            // operacje skrótowe

            int d = 1;
            d = d + 1;
            d++;

            d--; // d = d-1;

            d += 5; // d=d+5 zwiększenie wartości o podaną liczbe 
            d -= 3; // d=d-3;
            d *= 2; // d=d*2;
            d /= 4; // d=d/4




            Console.ReadKey();

        }
    }
}
