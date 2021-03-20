using System;

namespace Implementacja_Programu_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[N+1];

            int minimalna = 0;

            for(int i = 1; i <= N; i++)
            {
                Console.Write("Podaj wartość a[" + i + "] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 1 || a[i] < minimalna)
                {
                    minimalna = a[i];
                }
            }

            Console.WriteLine("Liczba minimalna = " + minimalna);
            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
