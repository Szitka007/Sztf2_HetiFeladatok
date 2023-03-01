using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    abstract internal class MozgoJarmu : Jarmu
    {
        protected float iranyX;
        protected float iranyY;

        public void UjIranyVektor(float x, float y)
        { 
            iranyX = x;
            iranyY = y;
        }
        
        public MozgoJarmu(char az, float i, float j, Terkep t) : base(az, i, j, t)
        {
            
        }

        abstract public void Mozog();
    }
}
