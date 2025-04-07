using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {

        static int suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            /*Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
całkowitymi. Napisz program wykorzystujący funkcję suma.*/

            Console.WriteLine("3+6={0}", suma(3, 6));
            Console.ReadKey(true);
            

        }
    }
}
