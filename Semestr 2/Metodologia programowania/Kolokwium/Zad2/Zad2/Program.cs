using System;

namespace Zad2
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
            Console.WriteLine("| 1 - Stworz tablice            |");
            Console.WriteLine("| 2 - Wczytaj dane do tablicy   |");
            Console.WriteLine("| 3 - Wczytaj losowe do tablicy |");
            Console.WriteLine("| 4 - Wyswietl max              |");
            Console.WriteLine("| 5 - Wyswietl sumy             |");
            Console.WriteLine("| k - Koniec                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("*-------------------------------*");
        }

        static public void Menu()
        {
            bool koniec = false;
            Tablica tablica = null;
            do
            {
                Instrukcja();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        tablica = new Tablica();
                        break;
                    case ConsoleKey.D2:
                        tablica.wypelnij();
                        break;
                    case ConsoleKey.D3:
                        tablica.wypelnijLosowymi();
                        break;
                    case ConsoleKey.D4:
                        tablica.wyswietl(false);
                        break;
                    case ConsoleKey.D5:
                        tablica.wyswietl(true);
                        break;
                    case ConsoleKey.K:
                        koniec = true;
                        return;
                    default:
                        Console.WriteLine("_!_ Wybierz opcje z menu _!_");
                        break;
                }

                Console.WriteLine("\n_>_ Wciśnij dowolny przycisk aby kontynuować _<_");
                Console.ReadKey();
                Console.Clear();
            } while (koniec == false);
        }
    }

    class Tablica
    {
        int[,] tablica;
        int liczba_w, liczba_k;

        public Tablica()
        {
            Console.Write("Podaj ilosc wierszy tablicy = ");
            liczba_w = int.Parse(Console.ReadLine());
            Console.Write("Podaj ilosc kolumn tablicy = ");
            liczba_k = int.Parse(Console.ReadLine());

            tablica = new int[liczba_w, liczba_k];
        }

        public void wyswietl(bool suma)
        {
            if (suma) {
                Console.WriteLine("Suma:");
            }
            else
            {
                Console.WriteLine("Max:");
            }


            for (int w = 0; w < this.liczba_w; w++)
            {

                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write(this.tablica[w, k].ToString() + " ");

                }
                Console.WriteLine();
            }

            int max, s;
            for (int k = 0; k < this.liczba_k; k++)
            {
                max = int.MinValue;
                s = 0;
                for (int w = 0; w < this.liczba_w; w++)
                {
                    s += this.tablica[w, k];
                    if (this.tablica[w, k] > max)
                    {
                        max = this.tablica[w, k];
                    }
                }
                if (suma)
                {
                    Console.Write(s + " ");
                }
                else
                {
                    Console.Write(max + " ");
                }
                
            }
        }

        public void wypelnijLosowymi()
        {
            Random random = new Random();
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {

                    this.tablica[w, k] = random.Next(-100, 100);
                }

            }
            Console.WriteLine("Wypelniono losowymi!");
        }

        public void wypelnij()
        {
            Random random = new Random();
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write("Podaj [" + w + "," + k + "] = ");

                    this.tablica[w, k] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Wypelniono wlasnymi!");
        }


    }

}

