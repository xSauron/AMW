using System;
using System.Collections.Generic;
using System.Text;

namespace Obiekty
{
    class Nauczyciel : Pracownik
    {

        int premia;

        public void WczytajPremia(int premia)
        {
            this.premia = premia;
        }

        public void WyswietlSkładowe()
        {
            Console.WriteLine($"\n{pensja} (Pensja) + {premia} (Premia) = {pensja+premia}");
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine($"Premia: {premia}");
        }

        public override float PensjaNetto()
        {
            return (pensja + premia) * 0.81f;
        }
    }
}
