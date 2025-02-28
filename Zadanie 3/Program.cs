using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.

            double a, b, c;
            Console.Write("Podaj liczbę pierwszą: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę drugą: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę trzecią: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a <= b) && (a <= c))
                Console.WriteLine($"Liczba {a} jest najmniejsza.");
            else if ((b <= c) && (b <= a))
                Console.WriteLine($"Liczba {b} jest najmniejsza.");
            else
                Console.WriteLine($"Liczba {c} jest najmniejsza.");


            if ((a >= b) && (a >= c))
                Console.WriteLine($"Liczba {a} jest największa.");
            else if ((b >= c) && (b >= a))
                Console.WriteLine($"Liczba {b} jest największa.");
            else
                Console.WriteLine($"Liczba {c} jest największa.");

            Console.ReadKey(true);


        }
    }
}
