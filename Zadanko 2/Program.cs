using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanko_2
{
    struct uczen
    {
        public string imie, nazwisko;
        public byte[] ocena;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.*/

            uczen[] uczniowie;
            int liczba_uczniow, liczba_ocen, i, j;

            Console.Write("Ile jest uczniów w klasie: ");
            liczba_uczniow = Convert.ToInt32(Console.ReadLine());

            uczniowie = new uczen[liczba_uczniow];

            for (i = 0; i < liczba_uczniow; i++)
            {
                Console.Write("Imię ucznia {0}: ", i+1);
                uczniowie[i].imie = Console.ReadLine();
            Console.Write("Nazwisko ucznia {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.Write("Ile ocen ma {0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                liczba_ocen = Convert.ToInt32(Console.ReadLine());

                uczniowie[i].ocena = new byte[liczba_ocen];

                for (j = 0; j < liczba_ocen; j++)
                {
                    Console.Write("Ocena {0}: ", j + 1);
                    uczniowie[i].ocena[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();

            }
            for (i = 0; i < liczba_uczniow; i++)
            {
                Console.Write("{0}. {1} {2}: ", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);

                foreach (byte o in uczniowie[i].ocena)
                    Console.Write("{0} ", o);
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
