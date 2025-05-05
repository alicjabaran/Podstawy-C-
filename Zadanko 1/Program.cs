using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanko_1
{
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
użytkownika i wypisz wszystkie pobrane wartości pól na ekranie*/


            Osoba o;

            Console.WriteLine("Podaj imie: ");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj roku urodzenia: ");
            o.rok = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} urodzil/a się w {2} roku.", o.imie, o.nazwisko, o.rok);
            Console.ReadKey(true);
        }
    }
}
