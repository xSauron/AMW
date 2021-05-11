using System;

namespace Licznik_znakow
{
    class Program
    {
        static void Instrukcja()
        {
            Console.WriteLine("----- Licznik Znaków -----");
            Console.WriteLine("+ -> Przechodzi do następnego znaku");
            Console.WriteLine("- -> Przechodzi do poprzedniego znaku");
            Console.WriteLine("0 -> Przechodzi do początku (A)");
            Console.WriteLine("k -> Konczy program");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Wciśnij odpowiedni klawisz:");
        }

        static bool Menu(LicznikZn lzn)
        {
            bool koniec = false;

            ConsoleKeyInfo klawisz;
            klawisz = Console.ReadKey(true);
            if (klawisz.KeyChar == '+') lzn.Plus();
            if (klawisz.KeyChar == '-') lzn.Minus();
            if (klawisz.KeyChar == '0') lzn.Zero();
            if (klawisz.KeyChar == 'k') koniec = true;

            return koniec;
        }

        static void Main(string[] args)
        {
            Instrukcja();

            LicznikZn liczn = new LicznikZn();
            liczn.Zero();
            while (!Menu(liczn));
        }
    }
}
