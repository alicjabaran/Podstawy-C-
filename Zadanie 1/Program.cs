using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.

            int a;
            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine($"Liczba {a} jest parzysta.");
            else
                Console.WriteLine($"Liczba {a} jest nieparzysta.");
            
            Console.ReadKey(true);


        }
    }
}
