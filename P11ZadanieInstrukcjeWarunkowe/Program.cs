using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieInstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj równanie");
            string rownanie = Console.ReadLine();

            int pozPlus= rownanie.IndexOf("+");
            int pozMinus = rownanie.IndexOf("-");
            int pozMnozenie = rownanie.IndexOf("*");
            int pozDzielenie = rownanie.IndexOf("/");

            int wynik;
            if(pozPlus>0)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozPlus))
                    + Convert.ToInt32(rownanie.Substring(pozPlus + 1));
            else if(pozMinus > 0)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMinus))
                    - Convert.ToInt32(rownanie.Substring(pozMinus + 1));
            else if (pozMnozenie > 0)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMnozenie))
                    * Convert.ToInt32(rownanie.Substring(pozMnozenie + 1));
            else
                wynik = Convert.ToInt32(rownanie.Substring(0, pozDzielenie))
                   / Convert.ToInt32(rownanie.Substring(pozDzielenie + 1));

            Console.WriteLine("wynik to: " + wynik);
            Console.ReadKey();
        }
    }
}
