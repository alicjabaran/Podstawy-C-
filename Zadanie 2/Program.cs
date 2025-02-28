using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            // dodatnia, ujemna, czy też równa zero

            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine($"Liczba {a} jest dodatnia.");
            else if (a < 0)
                    Console.WriteLine($"Liczba {a} jest ujemna.");
            else
                    Console.WriteLine($"Liczba {a} jest równa 0.");

            Console.ReadKey(true);
           


        }
    }
}
