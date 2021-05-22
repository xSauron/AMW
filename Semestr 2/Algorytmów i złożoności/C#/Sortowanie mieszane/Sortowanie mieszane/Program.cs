using System;

namespace Sortowanie_mieszane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N + 1];

            for (int i7 = 1; i7 <= N; i7++)
            {
                Console.Write("Podaj wartość a[" + i7 + "] = ");
                a[i7] = Convert.ToInt32(Console.ReadLine());
            }

            int l = 2;
            int p = N;
            int k = N;
            int x;
            do
            {
                for (int j = p; j >= l; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        x = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = x;
                        k = j;
                    }
                }
                l = k + 1;
                for (int j = l; j <= p; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        x = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = x;
                        k = j;
                    }
                }
                p = k - 1;
            }
            while (l <= p);


            Console.WriteLine("----- WYPISANIE -----");
            for (int i7 = 1; i7 <= N; i7++)
            {
                Console.WriteLine("Wartość a[" + i7 + "] = " + a[i7]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
