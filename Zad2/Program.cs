using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        /*Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.*/
        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Max z 4 i 9 to {0}", max(4, 9));
            Console.WriteLine("Max z 5 i 15 to {0}", max(5, 15));
            Console.WriteLine("Max z 4 i 4 to {0}", max(4, 4));

            Console.ReadKey(true);

        }
    }
}
