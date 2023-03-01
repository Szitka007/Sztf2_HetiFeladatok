using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        protected Jarmu[] jarmuvek;
        protected int jarmuvekN;
        public TerkepEsJarmuRajzolo(Terkep t, int max) : base(t)
        {
            jarmuvek = new Jarmu[max];
            jarmuvekN = -1;
        }

        public void JarmuFelvetele(Jarmu tardis)
        {
            if (jarmuvekN < jarmuvek.Length - 1)
            {
                jarmuvekN++;
                jarmuvek[jarmuvekN] = tardis;
            }
        }
        override protected char MiVanItt(int x, int y)
        {
            
            //side note magamnak: Ha van egy külön counter, hogy a tömb csak odáig van töltve adatokkal, NE AZ EGÉSZ TÖMBÖT AKARD BEJÁRNI EMBER!
            for (int i = 0; i <= jarmuvekN; i++)
            {
                if (x == Math.Round(jarmuvek[i].X) && y == Math.Round(jarmuvek[i].Y))
                {
                    return jarmuvek[i].Azonosito;
                }
            }
            return base.MiVanItt(x, y);
        }
    }
}
