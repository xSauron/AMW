using System;

namespace Sortowanie_przez_wstawianie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N + 1];

            for (int k = 1; k <= N; k++)
            {
                Console.Write("Podaj wartość a[" + k + "] = ");
                a[k] = Convert.ToInt32(Console.ReadLine());
            }

            int i = 1;
            int x;
            int j;

            do
            {
                i = i + 1;
                x = a[i];
                j = i - 1;

                //Console.WriteLine("Czy " + x + " < " + a[j] + " J = " + j);

                while (j > 0 && x < a[j])
                {
                    //Console.WriteLine(a[j + 1] + "[" + (j+1) + "]" + " = " + a[j] + "[" + (j) + "]");
                    a[j + 1] = a[j];

                    j--;

                }
                //Console.WriteLine(a[j + 1] + "[" + (j + 1) + "]" + " [=] " + x);
                a[j + 1] = x;

            } while (i < N);


            Console.WriteLine("----- WYPISANIE -----");
            for (int k = 1; k <= N; k++)
            {
                Console.WriteLine("Wartość a[" + k + "] = " + a[k]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
