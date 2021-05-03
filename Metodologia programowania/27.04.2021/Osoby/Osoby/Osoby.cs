using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osoby
{
    class Osoby : List<Osoba>
    {
        public void dodajOsobe()
        {
            Console.Write("> Podaj imie: ");
            string imie = Console.ReadLine();
            Console.Write("> Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Write("> Podaj rok urodzenia: ");
            int rok_urodzenia = int.Parse(Console.ReadLine());

            base.Add(new Osoba(imie, nazwisko, rok_urodzenia));
        }

        public void wyswieltKartoteke()
        {
            foreach(var osoba in this)
            {
                osoba.wyswietl();
                
            }
            
        }


        public Osoba wyszukajOsobe()
        {
            Console.Write("> Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            return this.Where( x => x.nazwisko == nazwisko).FirstOrDefault();

            
        }

        public void usunOsobe()
        {
            var osoba = wyszukajOsobe();

            if(osoba != null) this.Remove(osoba);
        }

    }
}
