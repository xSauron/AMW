using System;

namespace Merge
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
            Console.WriteLine("\n----- OPERACJE -----");
            SortMerge(1, N);

            Console.WriteLine("\n----- WYPISANIE -----");
            for (int i7 = 1; i7 <= N; i7++)
            {
                Console.WriteLine("Wartość a[" + i7 + "] = " + a[i7]);

            }

            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
        public static void SortMerge(int lewy, int prawy)
        {
            Console.WriteLine("");
            if (prawy > lewy)
            {
                int srodek = (lewy + prawy) / 2;

                Console.WriteLine("P = " + lewy + " S = " + srodek +  " K = " + prawy);

                SortMerge(lewy, srodek);
                Console.WriteLine("SortMerge  (" + a[lewy] + ", " + a[prawy] + ")");
                SortMerge(srodek + 1, prawy);
                Console.WriteLine("SortMerge  (" + a[srodek + 1] + ", " + a[prawy] + ")");
                Merge(lewy, srodek, prawy);
                Console.WriteLine("Merge  (" + a[lewy] + ", " + a[srodek] + ", " + a[prawy] + ")");
            }
            
        }
        public static void Merge(int lewy, int srodek, int prawy)
        {
            int i = lewy;
            int j = srodek + 1;
            int[] pom = new int[a.Length];

            for (int k = lewy; k <= prawy; k++)
                pom[k] = a[k];

            for (int k = lewy; k <= prawy; k++)
            {
                if (i <= srodek)
                {
                    if (j <= prawy)
                    {
                        if (pom[j] < pom[i])
                        {
                            a[k] = pom[j++];
                        }
                        else
                        {
                            a[k] = pom[i++];
                        }
                    }
                    else
                        a[k] = pom[i++];
                }
                else
                    a[k] = pom[j++];
            }
        }
    }
}
