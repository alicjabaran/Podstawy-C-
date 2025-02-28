using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód

            int a;
            int b; 
            Console.Write("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b=");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pole={0}", a * b);
            Console.WriteLine("Obwód={0}", 2*a + 2*b);
            Console.ReadKey(true);
    
        }
    }
}
