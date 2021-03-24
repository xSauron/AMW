using System;

namespace Implementacja_Programu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj łańcuch znaków : ");
            string zn = Console.ReadLine();
            if(zn == "****")
            {
                return;
            }

            int a = Convert.ToInt32(zn);
            int minimum = a;

            Console.Write("Podaj łańcuch znaków : ");
            zn = Console.ReadLine();
            while (zn != "****")
            {
                a = Convert.ToInt32(zn);
                if(a < minimum)
                {
                    minimum = a;
                }
                Console.Write("Podaj łańcuch znaków : ");
                zn = Console.ReadLine();
            }

            Console.WriteLine("Liczba minimalna = " + minimum);
            Console.WriteLine("Kliknij dowolny klawisz aby zamknąć program!");
            Console.ReadKey();
        }
    }
}
