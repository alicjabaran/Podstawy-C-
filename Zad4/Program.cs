using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        /*Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr.*/

        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i+1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 1 ma {0} cyfr", ile_cyfr(1));
            Console.WriteLine("Liczba 4212 ma {0} cyfry", ile_cyfr(4212));

            Console.ReadKey(true);
        }
    }
}
