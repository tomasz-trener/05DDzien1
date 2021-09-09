using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08WczytywanieZPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s= File.ReadAllText("c:\\dane\\plik.txt");

            string s = File.ReadAllText(@"c:\dane\plik.txt");

            Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
