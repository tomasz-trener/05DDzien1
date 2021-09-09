using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14InnePetle
{
    class Program
    {
        static void Main(string[] args)
        {
            // pętla do while, (gwarancja, że wykona się zawsze przynajmniej 1 raz)
            int i = 30;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<10);


            // pętla for (szczególnie przydatna gdy zwieszamy o 1 )
            int j = 0;
            while (j<10)
            {

                j++;
            }

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            for (int k = 10; k < 30; k=k+3)
            {

            }

            for (int k = 30; k > 0; k-=2)
            {

            }


            
            



            Console.ReadKey();
        }
    }
}
