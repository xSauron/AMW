using System;

namespace Obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik pracownik;
            Nagl();
            pracownik = Wybor();
            Instruckja();
            Menu(pracownik);
        }

        static void Nagl()
        {
            Console.WriteLine(".--------| Typ |--------.");
            Console.WriteLine("| 1 <- Pracownik        |");
            Console.WriteLine("| 2 <- Nauczyciel       |");
            Console.WriteLine("'-----------------------'");
        }

        static Pracownik Wybor()
        {
            Console.Write("\nWybierz operacje: ");
            ConsoleKeyInfo kl = Console.ReadKey();
            switch (kl.KeyChar)
            {
                case '1':
                    return new Pracownik();
                case '2':
                    return new Nauczyciel();
                default:
                    return null;
            }
        }

        static void Instruckja()
        {
            Console.WriteLine("\n.--------| Informacje |--------.");
            Console.WriteLine("| 1 <- Wczytaj                 |");
            Console.WriteLine("| 2 <- Pensja Netto            |");
            Console.WriteLine("| 3 <- Wyswielt Netto          |");
            Console.WriteLine("| 4 <- Wczytaj Premie          |");
            Console.WriteLine("| 5 <- Wyswietl Składowe       |");
            Console.WriteLine("'------------------------------'");
        }

        static void Menu(Pracownik pracownik)
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
                        if(pracownik is Nauczyciel)
                        {
                            Console.Write("\nPremia: ");
                            int premia = int.Parse(Console.ReadLine());
                            (pracownik as Nauczyciel).WczytajPremia(premia);
                        }
                        else
                        {
                            Console.WriteLine("\nBłąd! Funkcja dla Nauczyciela!");
                        }
                        
                        break;
                    case ConsoleKey.D5:
                        if(pracownik is Nauczyciel)
                        {
                            (pracownik as Nauczyciel).WyswietlSkładowe();
                        }
                        else
                        {
                            Console.WriteLine("\nBłąd! Funkcja dla Nauczyciela!");
                        }
                        break;
                }
            }
        }
    }
}
