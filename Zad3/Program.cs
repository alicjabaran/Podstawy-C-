using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        /*Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.*/
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Pole koła o promieniu 5 to {0}", pole_kola(5));
            Console.WriteLine("Pole koła o promieniu 10 to {0}", pole_kola(10));
            Console.WriteLine("Pole koła o promieniu 15 to {0}", pole_kola(15));

            Console.ReadKey(true);
        }
    }
}
