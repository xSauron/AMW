using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    public abstract class Figura
    {
        public Figura()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        public abstract float Pole();
        public abstract float Obwód();
    }
}
