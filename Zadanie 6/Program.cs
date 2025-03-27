using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            int pole;
            double a, b;
            do
            {
                Console.WriteLine("Wybierz liczbę. Którego pola chcesz użyć?");
                Console.WriteLine(" 1 - pole prostokąta");
                Console.WriteLine(" 2 - pole kwadratu");
                Console.WriteLine(" 3 - pole trójkąta");
                pole = Convert.ToInt32(Console.ReadLine());
                switch (pole)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Podaj dlugość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj dlugość boku b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi = {0}", a * b);
                        break;
                    case 2:
                        Console.WriteLine("Podaj dlugość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi = {0}", a * a);
                        break;
                    case 3:
                        Console.WriteLine("Podaj dlugość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj dlugość boku h = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi = {0}", a * b / 2.0);
                        break;
                    default:
                        Console.WriteLine("Bląd");
                        break;

                }
            } while (pole != 0);
        }
    }
}
 