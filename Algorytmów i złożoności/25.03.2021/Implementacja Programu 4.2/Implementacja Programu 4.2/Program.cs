using System;

namespace Implementacja_Programu_4._2
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

            int s = 1;
            int i = 1;
            while (s != 0)
            {
                s = 0;
                

                for (int j = N; j > i; j--)
                {
                    Console.WriteLine("Czy " + a[j] + " > " + a[j - 1]);
                    if (a[j] < a[j - 1])
                    {
                        int t = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = t;
                        s = 1;
                    }
                }
                i++;
            }

            Console.WriteLine("-----");
            for (int k = 1; k <= N; k++)
            {
                Console.WriteLine("Wartość a[" + i + "] = " + a[i]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
