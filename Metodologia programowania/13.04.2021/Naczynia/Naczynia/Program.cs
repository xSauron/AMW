using System;

namespace Naczynia
{
    class Program
    {
        static void Main(string[] args)
        {

            Start();
            bool ok = true;

            while (ok)
            {
                Console.Write("Operacja: ");
                ConsoleKeyInfo kl = Console.ReadKey();
                

                if (int.TryParse(kl.KeyChar.ToString(), out int numer))
                {
                    if(numer < 0 || Naczynie.Naczynia.Length < numer)
                    {
                        Console.WriteLine("\nNiedozwolona operacja! Indeks naczynia poza zakresem.");
                        continue;
                    }
                    Console.Write(" : ");

                    ConsoleKeyInfo kl2 = Console.ReadKey();
                    if (int.TryParse(kl2.KeyChar.ToString(), out int numer2))
                    {
                        if (numer2 < 0 || Naczynie.Naczynia.Length < numer2)
                        {
                            Console.WriteLine("\nNiedozwolona operacja! Indeks naczynia poza zakresem.");
                            continue;
                        }
                        Naczynie.Przelej(numer, numer2);
                        Naczynie.Wyswietl();
                    }
                    else
                    {
                        switch (kl2.Key)
                        {
                            case ConsoleKey.UpArrow:
                                Console.Write("↑");
                                Naczynie.Naczynia[numer - 1].Napelnij();
                                Naczynie.Wyswietl();
                                break;
                            case ConsoleKey.DownArrow:
                                Console.Write("↓");
                                Naczynie.Naczynia[numer - 1].Oproznij();
                                Naczynie.Wyswietl();
                                break;
                            default:
                                Console.WriteLine("\nNiedozwolona operacja! Przycisk spoza instrukcji.");
                                break;
                        }
                    }

                }
                else
                {
                    switch (kl.Key)
                    {
                        case ConsoleKey.N:
                            Restart();
                            break;
                        case ConsoleKey.K:
                            ok = false;
                            break;
                        default:
                            Console.WriteLine("\nNiedozwolona operacja! Przycisk spoza instrukcji.");
                            break;
                    }
                }
            }

        }

        public static void Start()
        {
            Console.Write("Wprowadź pojemność naczyń odzielone spacją: ");
            string pojemnosci = Console.ReadLine();

            bool rezultat = Naczynie.Stworz(pojemnosci);

            Instrukcja();
        }

        public static void Instrukcja()
        {
            Console.WriteLine(".--------| Informacje |--------.");
            Console.WriteLine("| <Numer> : ↑ - Napełnij       |");
            Console.WriteLine("| <Numer> : ↓ - Opróżnij       |");
            Console.WriteLine("| <Numer> : <Numer2> - Przelej |");
            Console.WriteLine("| N - Nowe                     |");
            Console.WriteLine("| K - Koniec                   |");
            Console.WriteLine("'------------------------------'");
            Console.WriteLine("\nStan początkowy: ");
            Naczynie.Wyswietl();
        }

        public static void Restart()
        {
            Console.Clear();
            Start();
        }
    }
}
