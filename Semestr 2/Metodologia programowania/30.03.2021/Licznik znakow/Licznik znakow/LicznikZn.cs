using System;
using System.Collections.Generic;
using System.Text;

namespace Licznik_znakow
{
    class LicznikZn
    {
        char znak;

        public void Plus()
        {
            if (znak == 'Z') znak = 'A';
            else znak++;
            Wyswietl();
        }

        public void Minus()
        {
            if (znak == 'A') znak = 'Z';
            else znak--;

            Wyswietl();
        }

        public void Zero()
        {
            znak='A';
            Wyswietl();
        }

        public void Wyswietl()
        {
            Console.Write("> {0}            \r",znak);
        }
    }
}
