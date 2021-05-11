using System;

namespace Implementacja_Programu_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N + 1];

            int H = N;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Podaj wartość a[" + i + "] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            int s = 1;
            while (s != 0) {
                s = 0;
                for (int i = 1; i < N; i++)
                    {
                        Console.WriteLine("Czy " + a[i] + " > " + a[i+1]);
                        if (a[i] > a[i+1])
                        {
                            int t = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = t;
                            s = s + 1;
                        }
                    }
                N = N - 1;          
            }

            Console.WriteLine("-----");
            for (int i = 1; i <= H; i++)
            {
                Console.WriteLine("Wartość a[" + i + "] = " + a[i]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
