using System;

namespace Osoby
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static public void Start()
        {
            var osoby = new Osoby();
            Menu(osoby);
            
        }

        static public void Menu(Osoby osoby)
        {
            bool koniec = false;
            do
            {
                Instrukcja();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        osoby.dodajOsobe();
                        break;
                    case ConsoleKey.D2:
                        osoby.wyswieltKartoteke();
                        break;
                    case ConsoleKey.D3:
                        osoby.wyszukajOsobe()?.wyswietl();
                        break;
                    case ConsoleKey.D4:
                        osoby.Clear();
                        break;
                    case ConsoleKey.D5:
                        osoby.usunOsobe();
                        break;
                    case ConsoleKey.K:
                        koniec = true;
                        return;
                    default:
                        Console.WriteLine("___Wybierz opcje z menu!___");
                        break;
                }



                Console.WriteLine("___Wciśnij dowolny przycisk aby kontynuować!___");
                Console.ReadKey();
                Console.Clear();
            } while (koniec == false);
        }

        static public void Instrukcja()
        {
            Console.WriteLine(".-----| Wybierz działanie |-----.");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1 - Dodaj osobę               |");
            Console.WriteLine("| 2 - Wyświetl listę            |");
            Console.WriteLine("| 3 - Wyszukaj                  |");
            Console.WriteLine("| 4 - Wyczyść kartotekę         |");
            Console.WriteLine("| 5 - Usuń osobę                |");
            Console.WriteLine("| k - Koniec                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("*-------------------------------*");
        }
    }
}
