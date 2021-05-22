using System;

namespace Zad2
{
    class Program
    {
        //Deklaracja globalnej tablicy
        static int[] m;

        static void Main(string[] args)
        {
            Console.Write("Podaj wielkosc tablicy v = ");
            int v = Convert.ToInt32(Console.ReadLine());
            v = v + 1;
            m = new int[v];

            //Wczytywanie danych do tablicy
            Console.WriteLine("\n------| Wpisz dane |------");
            for (int p = 1; p < v; p++)
            {
                Console.Write("Wpisz m[" + p + "] = ");
                m[p] = Convert.ToInt32(Console.ReadLine());
            }

            //Wywoływanie właściwych metod
            budujKopiec(v);
            sortuj(v);

            //Wypisywanie danych
            Console.WriteLine("\n------| Posortowany Kopiec |------");
            for (int p = 1; p < v; p++)
            {
                Console.WriteLine("Wartość m[" + p + "] = " + m[p]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }

        static public void budujKopiec(int v)
        {
            for (int p = v / 2; p >= 1; p--)
                kopcuj(p, v);
        }

        static public void sortuj(int v)
        {
            for (int p = v - 1; p >= 2; p--)
            {

                int tym = m[1];
                m[1] = m[p];
                m[p] = tym;
                kopcuj(1, p);
            }
        }

        
        static public void kopcuj(int p, int max)
        {
            int najwiekszy = p;
            int lewy = 2 * p;
            int prawy = 2 * p + 1;

            if (lewy < max && m[lewy] > m[najwiekszy])
                najwiekszy = lewy;

            if (prawy < max && m[prawy] > m[najwiekszy])
                najwiekszy = prawy;

            if (p != najwiekszy)
            {
                int tym = m[p];
                m[p] = m[najwiekszy];
                m[najwiekszy] = tym;

                kopcuj(max, najwiekszy);
            }
        }
    }
}
