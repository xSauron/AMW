using System;

namespace Obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Nauczyciel pracownik = new Nauczyciel();
            Instruckja();
            Menu(pracownik);
        }

        static void Instruckja()
        {
            Console.WriteLine(".--------| Informacje |--------.");
            Console.WriteLine("| 1 <- Wczytaj                 |");
            Console.WriteLine("| 2 <- Pensja Netto            |");
            Console.WriteLine("| 3 <- Wyswielt Netto          |");
            Console.WriteLine("| 4 <- Wczytaj Premie          |");
            Console.WriteLine("| 5 <- Wyswietl Składowe       |");
            Console.WriteLine("'------------------------------'");
        }

        static void Menu(Nauczyciel pracownik)
        {
            bool ok = true;
            while (ok) {
                Console.Write("\nWybierz operacje: ");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("\nImie: ");
                        string imie = Console.ReadLine();
                        Console.Write("Nazwisko: ");
                        string nazwisko = Console.ReadLine();
                        Console.Write("Pensja: ");
                        int pensja = int.Parse(Console.ReadLine());

                        pracownik.Wczytaj(imie, nazwisko, pensja);

                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"\nPensja Netto: {pracownik.PensjaNetto()}");
                        break;
                    case ConsoleKey.D3:
                        pracownik.Wyswietl();
                        break;
                    case ConsoleKey.D4:
                        Console.Write("\nPremia: ");
                        int premia = int.Parse(Console.ReadLine());
                        pracownik.WczytajPremia(premia);
                        break;
                    case ConsoleKey.D5:
                        pracownik.WyswietlSkładowe();
                        break;
                }
            }
        }
    }
}
