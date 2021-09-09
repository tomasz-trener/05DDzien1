using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadaniePetle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę do pliku");
            string sciezka = Console.ReadLine();

            Console.WriteLine("Podaj szukany wyraz");
            string wyraz = Console.ReadLine().ToLower() ;

            string tekst = File.ReadAllText(sciezka).ToLower();

            int suma = 0;
            int i = 0;
            int maksDlugosc = tekst.Length - wyraz.Length + 1;
            while (i< maksDlugosc)
            {
                string podciag = tekst.Substring(i, wyraz.Length);
                if (podciag == wyraz)
                    suma++;
                i++;
            }

            //   string wynik = "wyraz: " + wyraz + " występuje " + suma + " razy";
            string wynik = string.Format("wyraz: {0} występuje {1} razy",
                wyraz, suma);

            string wynik2 = $"wyraz: {wyraz} występuje {suma} razy";

            Console.Write(wynik);
            Console.ReadKey();
        }
    }
}
