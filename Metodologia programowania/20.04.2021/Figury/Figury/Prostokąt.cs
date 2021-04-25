using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Trójkąt : Figura
    {
        float a, h;
        public Trójkąt()
        {
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("h=");
            h = float.Parse(Console.ReadLine());
        }
        public override float Obwód()
        {
            return a + h + (float)Math.Sqrt(a * a + h * h);
        }

        public override float Pole()
        {
            return (a * h)/2;
        }
    }
}
