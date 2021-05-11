using System;
using System.Collections.Generic;

namespace Macierz
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static public void Instrukcja()
        {
            Console.WriteLine(".-----| Wybierz działanie |-----.");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1 - Dodaj nowa macierz        |");
            Console.WriteLine("| 2 - Wypelnij macierz          |");
            Console.WriteLine("| 3 - Wypelnij losowymi         |");
            Console.WriteLine("| 4 - Wyświetl macierz          |");
            Console.WriteLine("| 5 - Kalkulator                |");
            Console.WriteLine("| k - Koniec                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("*-------------------------------*");
        }

        static public void Menu()
        {
            bool koniec = false;

            Dictionary<string, Macierz> Macierze = new Dictionary<string, Macierz>();
            string nazwa;
            do
            {
                Instrukcja();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        var macierz = new Macierz();
                        Macierze[macierz.nazwa] = macierz;
                        break;
                    case ConsoleKey.D2:
                        szukaj(Macierze, "0").wypelnij();
                        break;
                    case ConsoleKey.D3:
                        szukaj(Macierze, "0").wypelnijLosowymi();
                        break;
                    case ConsoleKey.D4:
                        szukaj(Macierze, "0").wyswietl();
                        break;
                    case ConsoleKey.D5:
                        operacje(Macierze);
                        break;
                    case ConsoleKey.K:
                        koniec = true;
                        return;
                    default:
                        Console.WriteLine("___Wybierz opcje z menu!___");
                        break;
                }



                Console.WriteLine("\n_>_ Wciśnij dowolny przycisk aby kontynuować _<_");
                Console.ReadKey();
                Console.Clear();
            } while (koniec == false);
        }

        public static void operacje(Dictionary<string, Macierz> Macierze)
        {
            Console.Write("Podaj operacje np. A + B, A * B, A - B, A * 3: \n");
            string operacja = Console.ReadLine();
            string[] op = operacja.Split(' ');

            switch(op[1]){
                case "+":
                    szukaj(Macierze, op[0].ToString()).dodaj(szukaj(Macierze,op[2].ToString()));
                    break;
                case "-":
                    szukaj(Macierze, op[0].ToString()).odejmij(szukaj(Macierze, op[2].ToString()));
                    break;
                case "*":
                    int sk;
                    char B;

                    if (int.TryParse(op[2],out sk))
                    {
                        szukaj(Macierze, op[0].ToString()).skalar(sk);
                    }
                    else
                    {
                        szukaj(Macierze, op[0].ToString()).pomnoz(szukaj(Macierze, op[2].ToString()));
                    }
                    break;
            }
        }

        public static Macierz szukaj(Dictionary<string, Macierz> Macierze, string nazwa)
        {
            if(nazwa == "0") { 
                Console.Write("Podaj nazwe macierzy = ");
                string wczytaj = Console.ReadLine();
                if (Macierze.TryGetValue(wczytaj, out var macierz))
                    return macierz;
                else if (wczytaj == "k")
                    return null;
                else
                    return szukaj(Macierze, "0");
            }
            else
            {
                if (Macierze.TryGetValue(nazwa, out var macierz))
                    return macierz;
                else
                    return null;
            }
        }
    }
}
