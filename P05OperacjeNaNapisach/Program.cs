using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05OperacjeNaNapisach
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ala\nma kota";
            Console.WriteLine(s);
            int a = s.Length;

            string s2= s.Substring(4);
            string s3= s.Substring(4,2);

            string s4 = s.ToUpper(); // z duzych liter
            string s5 = s.ToLower(); // zamiana na male litery

            string s6 = s.Replace("ma", "bedzie miala"); // zamiana ma na bedzie miala

            bool b1= s.Contains("ma"); // czy s zwiera podciąg: ma

            string s7 = s.Trim(); // usun spacje z poczatku i końca ale nie ze środka 

            int a2 = s.IndexOf("ma"); // pozycja wystąpienia napisu ma
                                      
            



        }
    }
}
