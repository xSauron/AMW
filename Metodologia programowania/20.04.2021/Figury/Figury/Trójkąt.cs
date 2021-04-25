using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Prostokąt : Figura
    {
        float a, b;
        public Prostokąt()
        {
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
        }
        public override float Obwód()
        {
            return 2 * (a + b);
        }

        public override float Pole()
        {
            return a * b;
        }
    }
}
