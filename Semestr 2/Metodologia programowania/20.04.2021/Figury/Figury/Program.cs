using System;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f = null;
            Menu(f);
        }
        static public void Instrukcja()
        {
            Console.WriteLine("Wybierz figurę:");
            Console.WriteLine(" 1 - Prostokąt");
            Console.WriteLine(" 2 - Kwadrat:");
            Console.WriteLine(" 3 - Koło:");
            Console.WriteLine(" 4 - Trójkąt Prostokątny:");
            Console.WriteLine(" k - Koniec:");
        }

        static public void Menu(Figura f)
        {
            bool koniec = false;
            do
            {
                Instrukcja();
                f = null;
                do
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            f = new Prostokąt();
                            break;
                        case ConsoleKey.D2:
                            f = new Kwadrat();
                            break;
                        case ConsoleKey.D3:
                            f = new Koło();
                            break;
                        case ConsoleKey.D4:
                            f = new Trójkąt();
                            break;
                        case ConsoleKey.K:
                            koniec = true;
                            return;
                    }
                } while (f == null);

                Wyswietl(f);
            } while (koniec == false);
        }

        static public void Wyswietl(Figura f)
        {
            bool ok = true;
            Console.WriteLine("Wyświetlić pole[p], obwód[o] czy oba[b]");
            do
            {  
                var key = Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop);
                switch (key.Key)
                {
                    case ConsoleKey.P:
                        Console.WriteLine($"Pole wynosi : {f.Pole()}");
                        ok = true;
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine($"Obwód wynosi : {f.Obwód()}");
                        ok = true;
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine($"Pole wynosi : {f.Pole()}");
                        Console.WriteLine($"Obwód wynosi : {f.Obwód()}");
                        ok = true;
                        break;
                    default:
                        ok = false;
                        break;
                }
            } while (ok == false);
            
            Console.WriteLine("___Wciśnij dowolny przycisk!!!___");
            Console.ReadKey();
            Console.Clear();
        }
    }


}
