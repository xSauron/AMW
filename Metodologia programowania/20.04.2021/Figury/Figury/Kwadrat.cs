using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Kwadrat : Figura
    {
        float a;
        public Kwadrat()
        {
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
        }
        public override float Obwód()
        {
            return 4 * a;
        }

        public override float Pole()
        {
            return a * a;
        }
    }
}
