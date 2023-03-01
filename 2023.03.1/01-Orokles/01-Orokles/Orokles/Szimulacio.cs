using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Szimulacio : TerkepEsJarmuRajzolo
    {
        public Szimulacio(Terkep t, int max) : base(t, max)
        {
            
        }

        public void EgyIdoEgysegEltelt()
        {
            for (int i = 0; i <= jarmuvekN; i++)
            {
                if (jarmuvek[i] is MozgoJarmu)
                {
                    MozgoJarmu mj = (MozgoJarmu)jarmuvek[i];
                    mj.Mozog();
                } 
            }
        }

        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
