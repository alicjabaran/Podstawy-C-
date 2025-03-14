using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_dziewiąte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Wypisz tabliczkę mnożenia do 100 w formie tabelki:

            int i, j;
            for (i = 1;  i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                    Console.Write("{0}, ", i*j);
                Console.WriteLine("");

                
            }
            Console.ReadKey(true);
        }
    }
}
