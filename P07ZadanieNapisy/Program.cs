using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieNapisy
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1
            Console.WriteLine("Podaj dowolne zdanie");

            string s = Console.ReadLine();

            int a = s.Length;
            Console.WriteLine("Liczba znaków: " + a);

            string s1 = s.ToLower();

            string pierwsza = s.Substring(0, 1).ToUpper();
            string ostatnia = s.Substring(a - 1).ToUpper();

            string srodek = s.Substring(1, a - 2);

            string wynik = pierwsza + srodek + ostatnia;
            Console.WriteLine(wynik);

            // zadanie 2 

            Console.WriteLine("podaj równanie złożone z sumy dwóch liczb");
            string rownanie = Console.ReadLine();   // 15+5

            int pozPlusa = rownanie.IndexOf("+");

            string liczba1 = rownanie.Substring(0, pozPlusa);
            string liczba2 = rownanie.Substring(pozPlusa + 1);

            int suma = Convert.ToInt32(liczba1) + Convert.ToInt32(liczba2);
            Console.WriteLine("Wynik: " + suma);

            Console.ReadKey();

        }
    }
}
