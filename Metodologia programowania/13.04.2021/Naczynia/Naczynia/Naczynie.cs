using System;
using System.Collections.Generic;
using System.Text;

namespace Naczynia
{
    class Naczynie
    {
        public static Naczynie[] Naczynia;

        public int pojemnosc;

        public int zawartosc;

        public Naczynie(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }

        public static bool Stworz(string arg)
        {
            string[] tab = arg.Split(" ");

            if(tab.Length >= 2)
            {
                Naczynia = new Naczynie[tab.Length];

                for(int i = 0; i < tab.Length; i++)
                {
                    Naczynia[i] = new Naczynie(int.Parse(tab[i]));
                }

            }


            return true;
        }

        public static void Wyswietl()
        {
            for (int i = 0; i < Naczynia.Length; i++)
            {
                Console.Write($" <{i + 1}> |{Naczynia[i].zawartosc.ToString("00")}\\{Naczynia[i].pojemnosc.ToString("00")}|");
            }
            Console.WriteLine();
        }

        public static void Przelej(int n1, int n2)
        {
            Naczynie naczynie1 = Naczynia[n1 - 1];
            Naczynie naczynie2 = Naczynia[n2 - 1];

            int brakuje = naczynie2.pojemnosc - naczynie2.zawartosc;

            if(naczynie1.zawartosc >= brakuje)
            {
                naczynie2.zawartosc = naczynie2.zawartosc + brakuje;
                naczynie1.zawartosc = naczynie1.zawartosc - brakuje;
            }
            else
            {
                naczynie2.zawartosc = naczynie2.zawartosc + naczynie1.zawartosc;
                naczynie1.zawartosc = 0;
            }

        }

        public void Napelnij()
        {
            this.zawartosc = this.pojemnosc;
        }
        public void Oproznij()
        {
            this.zawartosc = 0;
        }
    }
}
