using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    abstract internal class GepiJatekos : ITippelo
    {
        protected int alsoHatar;
        protected int felsoHatar;
        protected int nyertDB;
        protected int veszitettDB;
        
        public virtual void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        abstract public int KovetkezoTipp();

        public void Nyert()
        {
            nyertDB++;
        }

        public void Veszitett()
        {
            veszitettDB++;
        }
    }
}
