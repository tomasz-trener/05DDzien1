using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09WczytywanieZSieciWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= new WebClient().DownloadString("http://www.wp.pl");

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
