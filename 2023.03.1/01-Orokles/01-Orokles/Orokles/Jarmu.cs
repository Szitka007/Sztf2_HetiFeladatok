using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Jarmu
    {
        //Fields
        char azonosito; //Megjelenik
        protected float x;
        protected float y;
        Terkep terkep;

        //Property
        public char Azonosito { get; }
        public float X { get; }
        public float Y { get; }

        public Jarmu(char az, float i, float j, Terkep t)
        {
            azonosito = az;
            x = i;
            y = j;
            terkep = t;

            Azonosito = azonosito;
            X = x; Y = y;
        }

        virtual protected bool IdeLephet(float x, float y)
        {
            return terkep.TerkepenBeluliPozicio(x, y);
        }

    }
}
