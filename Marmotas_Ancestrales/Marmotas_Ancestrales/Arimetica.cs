using System;
using System.Collections.Generic;
using System.Text;

namespace Marmotas_Ancestrales
{
    public class Arimetica
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Sumar(int a, object b)
        {
            if (b == null)
            { return 0; }
            else { return a + System.Convert.ToInt32(b); }
        }
    }
}
