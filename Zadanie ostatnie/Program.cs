using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_ostatnie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.

            double a, b, c, d, e, min, max;

            Console.Write($"Podaj liczbę pierwszą: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Podaj liczbę drugą: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Podaj liczbę trzecią: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Podaj liczbę czwartą: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Podaj liczbę piątą: ");
            e = Convert.ToDouble(Console.ReadLine());

         

            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
          


            Console.WriteLine("Liczba {0} jest najmniejszą ze zbioru.", min);


       

            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;

            Console.WriteLine("Liczba {0} jest największa ze zbioru.", max);

            Console.ReadKey(true);



        }
    }
}
