using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
            //uwzględnieniem części całkowitej i reszty z dzielenia.

            double a, b;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wynik wynosi {0}/{1}={2} a reszta {3}", a, b, a / b, a % b);

            Console.ReadKey(true);
        }
    }
}
