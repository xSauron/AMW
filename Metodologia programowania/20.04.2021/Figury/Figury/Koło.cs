using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Koło : Figura
    {
        float r;
        public Koło()
        {
            Console.Write("r=");
            r = float.Parse(Console.ReadLine());
        }
        public override float Obwód()
        {
            return (float)Math.PI * 2 * r;
        }

        public override float Pole()
        {
            return (float)Math.PI * r * r;
        }
    }
}
