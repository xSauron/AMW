using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static public void Instrukcja()
        {
            Console.WriteLine(".-----| Wybierz działanie |-----.");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1 - Trójkat z boków           |");
            Console.WriteLine("| 2 - Trójkat z wierzchołków    |");
            Console.WriteLine("| k - Koniec                    |");
            Console.WriteLine("|                               |");
            Console.WriteLine("*-------------------------------*");
        }

        static public void Menu()
        {
            bool koniec = false;

            do
            {
                Instrukcja();
                Trojkat trojkat;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        trojkat = new TrBoki();
                        Console.WriteLine("Pole: " + trojkat.pole() + "\nObwód: " + trojkat.obwod());
                        break;
                    case ConsoleKey.D2:
                        trojkat = new TrWierzch();
                        Console.WriteLine("Pole: " + trojkat.pole() + "\nObwód: " + trojkat.obwod());
                        break;
                    case ConsoleKey.K:
                        koniec = true;
                        return;
                    default:
                        Console.WriteLine("_!_ Wybierz opcje z menu _!_");
                        break;
                }

                Console.WriteLine("\n_>_ Wciśnij dowolny przycisk aby kontynuować _<_");
                Console.ReadKey();
                Console.Clear();
            } while (koniec == false);
        }
    }

    abstract class Trojkat
    {

        public abstract double obwod();

        public abstract double pole();

    }

    class TrBoki : Trojkat
    {
        double a, b, c;

        public TrBoki(){
            Console.Write("Podaj a= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj b= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Podaj c= ");
            c = double.Parse(Console.ReadLine());
        }

        public override double obwod()
        {
            return a + b + c;
        }

        public override double pole()
        {
            double s = 0.5f * (a + b + c);
            double p = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Sprawdzamy czy da się obliczyć
            if (double.IsNaN(p))
                return 0;
            else
                return p;
        }
    }
    class TrWierzch : Trojkat
    {
        double x1,x2,x3,y1,y2,y3;

        public TrWierzch()
        {
            Console.Write("Podaj x1= ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj y1= ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj x2= ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Podaj y2= ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Podaj x3= ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("Podaj y3= ");
            y3 = double.Parse(Console.ReadLine());
        }

        public override double obwod()
        {
            double p1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double p2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double p3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            return p1 + p2 + p3;
        }

        public override double pole()
        {
            //Poprawione brakowało jednego nawiasu w poleceniu - Bledna kolejnosc wykonywania
            double p = Math.Abs((0.5 * ((x1 * y2 - x2 * y1) + (x2 * y3 - x3 * y2) + (x3 * y1 - x1 * y3))));

            return p;
        }
    }

}
