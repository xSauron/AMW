using System;
using System.Collections.Generic;
using System.Text;

namespace Osoby
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rok_urodzenia;

        public Osoba(string imie, string nazwisko, int rok_urodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok_urodzenia = rok_urodzenia;
        }

        public void wyswietl()
        {
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("| Imie: " + this.imie);
            Console.WriteLine("| Nazwisko: " + this.nazwisko);
            Console.WriteLine("| Rok urodzenia: " + this.rok_urodzenia);
            Console.WriteLine("*-------------------------------*");
        }
    }
}
