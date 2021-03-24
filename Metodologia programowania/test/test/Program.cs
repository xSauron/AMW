using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----| Wieksza | -----!");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wieksza({0},{1})={2}", a, b, niezbędnik.Wieksza(a, b));

            Console.WriteLine("-----| Zamien | -----!");
            Console.WriteLine("a={0}, b={1} ", a, b);
            Console.WriteLine("Zamiana a <=> b");
            niezbędnik.Zamien(ref a, ref b);
            Console.WriteLine("a={0}, b={1} ", a, b);

            Console.WriteLine("-----| Silnia | -----!");
            int c;
            niezbędnik.Silnia(a, out c);
            Console.WriteLine("Silnia({0})={1}", a, c);

            Console.WriteLine("-----| Silnia Rekurencyjna | -----!");
            Console.WriteLine("Silnia Rekurencyjna({0})={1}", a, niezbędnik.RekurencyjnaSilnia(a));

            if (c == 0 || a == 0)
            {
                Console.WriteLine("Wyniki = 0 w silniach mogą oznaczać przepełnienie! (Overflow)");
            }

            Console.WriteLine("Wciśnij dowolony klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
    
    class niezbędnik
    {
        public static int Wieksza(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        public static void Zamien(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        public static bool Silnia(int a, out int c)
        {
            try
            {
                c = 1;
                while(a > 1)
                {
                    checked { c *= a; }
                    a--;
                }
                return true;
            }
            catch (Exception)
            {

                c = 0;
                return false;
            }
            
        }

        public static int RekurencyjnaSilnia(int a)
        {
            try
            {
                checked
                {
                    if (a > 1)
                        return a * RekurencyjnaSilnia(a - 1);
                    else
                        return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
