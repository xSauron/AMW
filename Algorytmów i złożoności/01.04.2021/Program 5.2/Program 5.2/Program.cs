using System;

namespace Program_5._2
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

            int j = 0;
            int i;
            int mini;
            int pom;

            do
            {
                j = j + 1;
                mini = j;
                i = j;

                do
                {
                    i = i + 1;
                    if (a[i] < a[mini])
                    {
                        mini = i;
                    }
                } while (i < N);

                pom = a[j];
                a[j] = a[mini];
                a[mini] = pom;
            } while (j < N - 1);


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
