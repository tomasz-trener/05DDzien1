using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KonwersjeTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ala ma kota";
            int b = 3;

            string c = Convert.ToString(b);

            Console.WriteLine(c);

            string d = "6 ala";

            int e = Convert.ToInt32(d);
            
            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
