using System;
using System.Collections.Generic;
using System.Text;

namespace Obiekty
{
    class Pracownik
    {
        protected string imie;
        protected string nazwisko;
        protected int pensja;

        public void Wczytaj(string imie, string nazwisko, int pensja){
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pensja = pensja;
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine($"\nNazwisko: {nazwisko}");
            Console.WriteLine($"Imie: {imie}");
            Console.WriteLine($"Pensja: {pensja}");
            Console.WriteLine($"PensjaNetto: {PensjaNetto()}");
        }
        public virtual float PensjaNetto()
        {
            return pensja * 0.81f;
        }
    }
}
