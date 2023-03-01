using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Helikopter : MozgoJarmu
    {
        float sebesseg;

        public Helikopter(float i, float j, Terkep t) : base('H',i,j,t)
        {
            sebesseg = 1;
        }
        
        public override void Mozog()
        {
            if (IdeLephet(iranyX,iranyY))
            {
                x = iranyX * sebesseg;
                y = iranyY * sebesseg;
            }
        }

        protected void Gyorsit()
        { sebesseg += (float)0.1; }
        protected void Lassit()
        {
            if (sebesseg > 0)
            {
                sebesseg -= (float)0.1;
            } 
        }
    }
}
