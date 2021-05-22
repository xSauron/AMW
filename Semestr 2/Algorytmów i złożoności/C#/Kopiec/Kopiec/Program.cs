using System;

namespace Kopiec
{
    class Program
    {
        static int[] a;
        static void Main(string[] args)
        {
            Console.Write("Podaj N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            a = new int[N+1];

            for (int i7 = 1; i7 <= N; i7++)
            {
                Console.Write("Podaj wartość a[" + i7 + "] = ");
                a[i7] = Convert.ToInt32(Console.ReadLine());
            }

            budujKopiec(N);

            int i = N+1;
            do
            {
                i = i - 1;
                int tym = a[0];
                a[0] = a[i];
                a[i] = tym;

                kopcuj(0, i);
            } while (i > 1);

            Console.WriteLine("----- WYPISANIE -----");
            for (int i7 = 1; i7 <= N; i7++)
            {
                Console.WriteLine("Wartość a[" + i7 + "] = " + a[i7]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }

        static public void budujKopiec(int N)
        {
            int i = N/2;
            do
            {
                i = i - 1;
                kopcuj(i, N);
                
            }while(i >= 1);
            
        }
        static public void kopcuj(int idx, int max)
        {
            int najwiekszy;
            int lewy = 2 * idx + 1;
            int prawy = 2 * idx + 2;

            if (lewy < max && a[lewy] > a[idx])
                najwiekszy = lewy;
            else
                najwiekszy = idx;

            if (prawy < max && a[prawy] > a[najwiekszy])
                najwiekszy = prawy;

            if (idx != najwiekszy)
            {
                int tym = a[idx];
                a[idx] = a[najwiekszy];
                a[najwiekszy] = tym;

                kopcuj(najwiekszy, max);
            }
        }
    }
}
