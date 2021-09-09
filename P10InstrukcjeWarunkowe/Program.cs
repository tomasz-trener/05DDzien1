using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10InstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            /*
            if (a>20)  // >, <, >=, <=, ==, !=
            {
                Console.WriteLine("bardzo duża");
            }
            else
            {
                if (a>10)
                {
                    Console.WriteLine("duża");
                }
                else
                {
                    Console.WriteLine("mała");
                }
            }
            */

            if (a > 20)
                Console.WriteLine("bardzo duża");
            else if (a > 10)
                Console.WriteLine("duza");
            else if(a>5)
                Console.WriteLine("mała");
            else
                Console.WriteLine("bardzo mała");

            // napisz czy to kobieta czy mężczyzna bazując na wzroście
            // jezeli wzrost > 188 to jest mężyczna w przeciwnym wypadku to kobieta 

            string plec;
            int wzrost = 180;

            if (wzrost>188)
                plec = "meżczyzna";
            else
                plec = "kobieta";
       
            string plec2 = wzrost > 188 ? "mężczyzna" : "kobieta";

            Console.WriteLine(plec);
        }
    }
}
