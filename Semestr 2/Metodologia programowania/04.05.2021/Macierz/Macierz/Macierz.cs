using System;
using System.Collections.Generic;
using System.Text;

namespace Macierz
{
    class Macierz
    {
        public string nazwa;
        int liczba_w, liczba_k;
        int[,] macierz;

        public Macierz()
        {
            Console.Write("Podaj nazwe macierzy = ");
            nazwa = Console.ReadLine();
            Console.Write("Podaj ilosc wierszy macierzy = ");
            liczba_w = int.Parse(Console.ReadLine());
            Console.Write("Podaj ilosc kolumn macierzy = ");
            liczba_k = int.Parse(Console.ReadLine());

            macierz = new int[liczba_w, liczba_k];

        }
            
        public void wyswietl()
        {
            Console.WriteLine(this.nazwa + ":");
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write(this.macierz[w, k].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        public void wypelnijLosowymi()
        {
            Random random = new Random();
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    
                    this.macierz[w, k] = random.Next(-100,100);
                }
                
            }
            Console.WriteLine("Wypelniono!");
        }

        public void wypelnij()
        {
            Random random = new Random();
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write("Podaj [" + w + "," + k + "] = ");

                    this.macierz[w, k] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Wypelniono!");
        }

        public void dodaj(Macierz B)
        {
            Console.WriteLine();
            this.wyswietl();
            Console.WriteLine();
            B.wyswietl();

            if (this.liczba_w != B.liczba_w || this.liczba_k != B.liczba_k) { 
                Console.WriteLine("\n_!_ Ilosc wierszy i kolumn w obu macierzach musi się zgadzać _!_");
                return;
            }

            Console.WriteLine("\nSuma: ");

            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write((this.macierz[w, k] + B.macierz[w, k]).ToString() + " ");
                }
                    Console.WriteLine();
            }
        }
        
        public void odejmij(Macierz B)
        {
            Console.WriteLine();
            this.wyswietl();
            Console.WriteLine();
            B.wyswietl();

            if (this.liczba_w != B.liczba_w || this.liczba_k != B.liczba_k)
            {
                Console.WriteLine("\n_!_ Ilosc wierszy i kolumn w obu macierzach musi się zgadzać _!_");
                return;
            }

            Console.WriteLine("\nRóznica: ");

            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write((this.macierz[w, k] + B.macierz[w, k]).ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        public  void skalar(int skalar)
        {
            Console.WriteLine();
            this.wyswietl();
            Console.WriteLine("\nMnożenie przez skalar: ");
            for (int w = 0; w < this.liczba_w; w++)
            {
                for (int k = 0; k < this.liczba_k; k++)
                {
                    Console.Write((this.macierz[w, k] * skalar).ToString() + " ");
                }
                Console.WriteLine();
            }
        }
        
        public void pomnoz(Macierz B)
        {
            if (this.liczba_w != B.liczba_k)
            {
                Console.WriteLine("\n_!_ Ilosc wierszy macierzy 1 musi się równać liczbie kolumn w 2 _!_");
                return;
            }

            Console.WriteLine();
            this.wyswietl();
            Console.WriteLine();
            B.wyswietl();

            Console.WriteLine("\nMnożenie przez macierz: ");

            int suma = 0;
            for (int w = 0; w < this.liczba_w; w++)
            {
                
                for (int k = 0; k < B.liczba_k; k++)
                {
                    suma = 0;
                    for (int i = 0; i < this.liczba_k; i++)
                    {
                        //Console.WriteLine(this.macierz[w, i] + " * " + B.macierz[i, k]);
                        suma += this.macierz[w, i] * B.macierz[i, k];
                    }
                        
                    Console.Write(suma + " ");
                    //macierzA[i, 0] * macierzB[0, i];
                }
                
                Console.WriteLine();
            }
        }

    }
}
